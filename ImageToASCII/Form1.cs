using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.IO.Compression;

namespace ImageToASCII
{
    public partial class Form1 : Form
    {

        int colorAverage = 0, height = 100, width = 200;
        Stopwatch time = new Stopwatch();
        List<string> fonts = new List<string>();
        string path = string.Empty;
        StringBuilder asciiImage = new StringBuilder();
        Image img;
        Bitmap bmp;
        int bmpHeight, bmpWidth;
        private System.Timers.Timer t;
        int delay = 2000;
        string ipCamURL = "";

        private void getCamPicture(object s, EventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {
                time.Reset();
                time.Start();
                var request = WebRequest.Create(ipCamURL);
                using (var response = (HttpWebResponse)request.GetResponse()) // Request
                {
                    using (var stream = response.GetResponseStream()) // Get image from ipCam
                        img = Image.FromStream(stream);
                }
                // save captured image and convert it
                bmp = new Bitmap(img, width, height);
                pbx_image.Image = img;
                pbx_image.SizeMode = PictureBoxSizeMode.Zoom;
                time.Stop();
                label_request.Text = "Request time: " + time.ElapsedMilliseconds + " ms";
                convert_image(bmp);
            });
        }

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            splitContainer1.IsSplitterFixed = true;

            foreach (FontFamily font in System.Drawing.FontFamily.Families) { cbx_fontList.Items.Add(font.Name); }
            cbx_fontList.SelectedIndex = cbx_fontList.FindStringExact("Consolas");
        }

        private void convert_image(Bitmap bmp)
        {
            // image conversion algorithm
            asciiImage.Length = 0;
            asciiImage.Capacity = 0;
            bmpHeight = bmp.Height;
            bmpWidth = bmp.Width;
            int yRise = bmpHeight / height;
            int xRise = bmpWidth / width;

            time.Reset();
            time.Start();
            for (int y = 0; y < bmpHeight; y = y + yRise)
            {
                for (int x = 0; x < bmpWidth; x = x + xRise)
                {
                    Color clr = bmp.GetPixel(x, y);
                    // convert image to grayscale with RGB average (fast and precise)
                    if (cbx_invert.Checked == true) colorAverage = 255 - (tbar_brightness.Value + (clr.R + clr.G + clr.B) / 3);
                    else colorAverage = tbar_brightness.Value + (clr.R + clr.G + clr.B) / 3;
                    asciiImage.Append(getAsciiChar(colorAverage).ToString());
                }
                asciiImage.Append(Environment.NewLine);
            }
            rtbx_ascii.ResetText();
            // show ASCII art in textbox
            rtbx_ascii.Text = asciiImage.ToString();
            time.Stop();
            btn_convert.Enabled = true;
            label_time.Text = "Processing time: " + time.ElapsedMilliseconds + " ms";
        }

        private char getAsciiChar(int colorAverage)
        {
            // reduced character library
            if (cbx_reduceCharLib.Checked == true)
            { 
                if (colorAverage >= 235) return '.';
                if (colorAverage >= 200) return ';';
                if (colorAverage >= 170) return '>';
                if (colorAverage >= 140) return 'r';
                if (colorAverage >= 110) return 'j';
                if (colorAverage >= 80) return 'k';
                if (colorAverage >= 60) return 'q';
                if (colorAverage >= 30) return 'B';
                if (colorAverage >= 20) return '&';
                if (colorAverage >= 5) return '#';
                return '@';
            }

            else // full character library
            {
                if (colorAverage >= 235) return '.';
                if (colorAverage >= 225) return '`';
                if (colorAverage >= 220) return ',';
                if (colorAverage >= 215) return '^';
                if (colorAverage >= 210) return ':';
                if (colorAverage >= 205) return '"';
                if (colorAverage >= 200) return ';';
                if (colorAverage >= 195) return '~';
                if (colorAverage >= 190) return '-';
                if (colorAverage >= 185) return '_';
                if (colorAverage >= 180) return '+';
                if (colorAverage >= 170) return '>';
                if (colorAverage >= 165) return 'i';
                if (colorAverage >= 160) return '!';
                if (colorAverage >= 155) return 'l';
                if (colorAverage >= 150) return 'I';
                if (colorAverage >= 145) return '?';
                if (colorAverage >= 140) return 'r';
                if (colorAverage >= 135) return 'c';
                if (colorAverage >= 130) return 'v';
                if (colorAverage >= 125) return 'u';
                if (colorAverage >= 120) return 'x';
                if (colorAverage >= 115) return 'z';
                if (colorAverage >= 110) return 'j';
                if (colorAverage >= 105) return 'f';
                if (colorAverage >= 100) return 't';
                if (colorAverage >= 95) return 'o';
                if (colorAverage >= 90) return 'a';
                if (colorAverage >= 85) return 'h';
                if (colorAverage >= 80) return 'k';
                if (colorAverage >= 75) return 'b';
                if (colorAverage >= 70) return 'd';
                if (colorAverage >= 65) return 'p';
                if (colorAverage >= 60) return 'q';
                if (colorAverage >= 55) return 'w';
                if (colorAverage >= 40) return 'W';
                if (colorAverage >= 35) return 'M';
                if (colorAverage >= 30) return 'B';
                if (colorAverage >= 25) return '8';
                if (colorAverage >= 20) return '&';
                if (colorAverage >= 15) return '%';
                if (colorAverage >= 10) return '$';
                if (colorAverage >= 5) return '#';
                return '@';
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            // load image
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif, *jpeg)|*.bmp;*.jpg;*.png;*.gif;*.jpeg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = string.Empty;
                path = file.FileName;
                img = Image.FromFile(path.Trim('\\'));
                bmp = new Bitmap(img, width, height);
                pbx_image.Image = img;
                pbx_image.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void rb_file_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_file.Checked == true)
            {
                btn_file.Enabled = true;
            }
            else btn_file.Enabled = false;
        }

        private void rb_IPcamera_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_IPcamera.Checked == true)
            {
                btn_IPcamera.Enabled = true;
            }
            else btn_IPcamera.Enabled = false;
        }

        private void btn_IPcamera_Click(object sender, EventArgs e)
        {
            IPCamSelect ipcam = new IPCamSelect();
            ipcam.Show();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            // convert uploaded image
            if (img == null && rb_file.Checked == true) MessageBox.Show("Please select the image you want to convert to ASCII", "No image selected");
            else
            {
                if (rb_file.Checked == true)
                {
                    btn_convert.Enabled = false;
                    rtbx_ascii.Clear();
                    rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                    bmp = new Bitmap(img, width, height);
                    convert_image(bmp);
                }

                if (rb_IPcamera.Checked == true)
                {
                    rtbx_ascii.Clear();
                    rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                    if (IPCamSelect.ipCamURL == null || IPCamSelect.ipCamURL == "") { MessageBox.Show("Please add IP Camera URL", "IP Camera"); }
                    else
                    {
                        delay = IPCamSelect.delay;
                        ipCamURL = IPCamSelect.ipCamURL;
                        t = new System.Timers.Timer(delay);
                        t.Elapsed += new System.Timers.ElapsedEventHandler(getCamPicture);
                        t.Start();
                        btn_convert.Enabled = false;
                        btn_stop.Enabled = true;
                    }
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            // stop IPcam stream
            t.Stop();
            btn_convert.Enabled = true;
            btn_stop.Enabled = false;
        }

        private void menu_exportText_Click(object sender, EventArgs e)
        {
            // export ASCII art

            SaveFileDialog savePath = new SaveFileDialog();
            savePath.Filter = "Text files (*.txt)|*.txt";
            savePath.FilterIndex = 1;
            savePath.RestoreDirectory = true;
            string initialDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            savePath.InitialDirectory = initialDir;
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(savePath.FileName)) { }
                using (StreamWriter sr = new StreamWriter(savePath.FileName))
                {
                    sr.Write(asciiImage.ToString());
                    sr.Close();
                }
            }
        }

        private void menu_exportHTML_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePath = new SaveFileDialog();
            savePath.Filter = "HTML files (*.html)|*.html";
            savePath.FilterIndex = 1;
            savePath.RestoreDirectory = true;
            savePath.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(savePath.FileName)) { }
                using (StreamWriter sr = new StreamWriter(savePath.FileName))
                {
                    asciiImage.Replace("\r\n", "<br>");
                    sr.Write(String.Empty);
                    sr.Write("<html><body><font face=\"" + cbx_fontList.GetItemText(this.cbx_fontList.SelectedItem) + "\"> <span style=\"font-size:" + tbar_fontSize.Value + "px\">" + asciiImage.ToString() + "</span></font></body></html>");
                    sr.Close();
                    asciiImage.Replace("<br>", "\r\n");
                }
            }
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            SizeF textSize = drawing.MeasureString(text, font);

            img.Dispose();
            drawing.Dispose();

            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            drawing.Clear(backColor);

            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();
            return img;
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        // JPG export
        private void menu_exportJPG_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                SaveFileDialog savePath = new SaveFileDialog();
                savePath.Filter = "JPEG file|*.jpeg";
                savePath.FilterIndex = 1;
                savePath.RestoreDirectory = true;
                string initialDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                savePath.InitialDirectory = initialDir;
                if (savePath.ShowDialog() == DialogResult.OK)
                {
                    string selFont = cbx_fontList.GetItemText(this.cbx_fontList.SelectedItem);
                    float size = tbar_fontSize.Value;
                    Font font = new Font(selFont, size);
                    Image export_img = DrawText(asciiImage.ToString(), font, Color.FromName("Black"), Color.FromName("White"));

                    System.Drawing.Imaging.Encoder myEncoder;
                    ImageCodecInfo myImageCodecInfo;
                    EncoderParameter myEncoderParameter;
                    EncoderParameters myEncoderParameters;
                    myEncoder = System.Drawing.Imaging.Encoder.Quality;

                    myEncoderParameters = new EncoderParameters(1);
                    myEncoderParameter = new EncoderParameter(myEncoder, 75L);
                    myEncoderParameters.Param[0] = myEncoderParameter;

                    myImageCodecInfo = GetEncoderInfo("image/jpeg");
                    export_img.Save(savePath.FileName, myImageCodecInfo, myEncoderParameters);
                }
            }
        }

        // rotate and convert image
        private void degreesClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                btn_convert.Enabled = false;
                rtbx_ascii.Clear();
                rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbx_image.Image = img;
                bmp = new Bitmap(img, width, height);
                convert_image(bmp);
            }
        }

        // rotate and convert image
        private void degreesCounterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                btn_convert.Enabled = false;
                rtbx_ascii.Clear();
                rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pbx_image.Image = img;
                bmp = new Bitmap(img, width, height);
                convert_image(bmp);
            }
        }

        // rotate and convert image
        private void degreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                btn_convert.Enabled = false;
                rtbx_ascii.Clear();
                rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pbx_image.Image = img;
                bmp = new Bitmap(img, width, height);
                convert_image(bmp);
            }
        }

        // flip and convert image
        private void menu_flipHorizontal_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                btn_convert.Enabled = false;
                rtbx_ascii.Clear();
                rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pbx_image.Image = img;
                bmp = new Bitmap(img, width, height);
                convert_image(bmp);
            }
        }

        // flip and convert image
        private void menu_flipVertical_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                btn_convert.Enabled = false;
                rtbx_ascii.Clear();
                rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                img.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pbx_image.Image = img;
                bmp = new Bitmap(img, width, height);
                convert_image(bmp);
            }
        }

        // textbox value validation
        private void tbx_width_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(tbx_width.Text, out width)) { }
            else
            {
                tbx_width.Text = "200";
                width = 200;
            }
        }

        private void tbx_height_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(tbx_height.Text, out height)) { }
            else
            {
                tbx_height.Text = "100";
                height = 100;
            }
        }

        // compress string
        static byte[][] Compress(string[] array)
        {
            byte[][] output = new byte[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                output[i] = ASCIIEncoding.ASCII.GetBytes(array[i]);
            }
            return output;
        }


        public static string CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }

        // decompress string
        public static string DecompressString(string compressedText)
        {
            byte[] gZipBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }

        private void compressedTextFiletxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePath = new SaveFileDialog();
            savePath.Filter = "Text files (*.txt)|*.txt";
            savePath.FilterIndex = 1;
            savePath.RestoreDirectory = true;
            string initialDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            savePath.InitialDirectory = initialDir;
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                string compressedOutput = CompressString(asciiImage.ToString());
                using (StreamWriter sr = new StreamWriter(savePath.FileName)) { }
                using (StreamWriter sr = new StreamWriter(savePath.FileName))
                {
                    sr.Write(compressedOutput);
                    sr.Close();
                }
            }
        }

        private void rb_textFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_textFile.Checked == true)
            {
                b_selectCompressedFile.Enabled = true;
            }

            else b_selectCompressedFile.Enabled = false;
        }

        private void b_selectCompressedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.Filter = "Text files (*.txt)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {

                path = string.Empty;
                path = file.FileName;
                string decompressedInput = DecompressString(File.ReadAllText(path));
                rtbx_ascii.ResetText();
                rtbx_ascii.Font = new Font(cbx_fontList.SelectedItem.ToString(), tbar_fontSize.Value);
                rtbx_ascii.Text = decompressedInput;
            }
        }
    }
}