namespace ImageToASCII
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbx_ascii = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_reduceCharLib = new System.Windows.Forms.CheckBox();
            this.cbx_invert = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_fontList = new System.Windows.Forms.ComboBox();
            this.tbar_fontSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbar_brightness = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbx_image = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_selectCompressedFile = new System.Windows.Forms.Button();
            this.rb_textFile = new System.Windows.Forms.RadioButton();
            this.btn_IPcamera = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.rb_IPcamera = new System.Windows.Forms.RadioButton();
            this.rb_file = new System.Windows.Forms.RadioButton();
            this.btn_convert = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label_request = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.menu_exportMenu = new System.Windows.Forms.MenuStrip();
            this.exportAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exportText = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exportHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exportJPG = new System.Windows.Forms.ToolStripMenuItem();
            this.compressedTextFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_90degcw = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_90degccw = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_180deg = new System.Windows.Forms.ToolStripMenuItem();
            this.flipASCIIImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_flipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_flipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menu_exportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbx_ascii
            // 
            this.rtbx_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbx_ascii.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbx_ascii.Location = new System.Drawing.Point(0, 23);
            this.rtbx_ascii.Margin = new System.Windows.Forms.Padding(1);
            this.rtbx_ascii.Name = "rtbx_ascii";
            this.rtbx_ascii.Size = new System.Drawing.Size(783, 639);
            this.rtbx_ascii.TabIndex = 0;
            this.rtbx_ascii.Text = "";
            this.rtbx_ascii.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_reduceCharLib);
            this.groupBox2.Controls.Add(this.cbx_invert);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbx_fontList);
            this.groupBox2.Controls.Add(this.tbar_fontSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbx_height);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbx_width);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbar_brightness);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 225);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture options";
            // 
            // cbx_reduceCharLib
            // 
            this.cbx_reduceCharLib.AutoSize = true;
            this.cbx_reduceCharLib.BackColor = System.Drawing.Color.Transparent;
            this.cbx_reduceCharLib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_reduceCharLib.Location = new System.Drawing.Point(11, 193);
            this.cbx_reduceCharLib.Name = "cbx_reduceCharLib";
            this.cbx_reduceCharLib.Size = new System.Drawing.Size(182, 21);
            this.cbx_reduceCharLib.TabIndex = 22;
            this.cbx_reduceCharLib.Text = "Reduced Character Library";
            this.cbx_reduceCharLib.UseVisualStyleBackColor = false;
            // 
            // cbx_invert
            // 
            this.cbx_invert.AutoSize = true;
            this.cbx_invert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_invert.Location = new System.Drawing.Point(11, 160);
            this.cbx_invert.Name = "cbx_invert";
            this.cbx_invert.Size = new System.Drawing.Size(132, 21);
            this.cbx_invert.TabIndex = 21;
            this.cbx_invert.Text = "Invert ASCII Image";
            this.cbx_invert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Font:";
            // 
            // cbx_fontList
            // 
            this.cbx_fontList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_fontList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_fontList.FormattingEnabled = true;
            this.cbx_fontList.Location = new System.Drawing.Point(56, 123);
            this.cbx_fontList.Name = "cbx_fontList";
            this.cbx_fontList.Size = new System.Drawing.Size(154, 25);
            this.cbx_fontList.TabIndex = 10;
            // 
            // tbar_fontSize
            // 
            this.tbar_fontSize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbar_fontSize.LargeChange = 4;
            this.tbar_fontSize.Location = new System.Drawing.Point(72, 93);
            this.tbar_fontSize.Margin = new System.Windows.Forms.Padding(0);
            this.tbar_fontSize.Maximum = 32;
            this.tbar_fontSize.Minimum = 2;
            this.tbar_fontSize.Name = "tbar_fontSize";
            this.tbar_fontSize.Size = new System.Drawing.Size(143, 45);
            this.tbar_fontSize.TabIndex = 4;
            this.tbar_fontSize.TickFrequency = 4;
            this.tbar_fontSize.Value = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(134, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution:";
            // 
            // tbx_height
            // 
            this.tbx_height.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_height.Location = new System.Drawing.Point(162, 27);
            this.tbx_height.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_height.Name = "tbx_height";
            this.tbx_height.Size = new System.Drawing.Size(50, 25);
            this.tbx_height.TabIndex = 2;
            this.tbx_height.Text = "100";
            this.tbx_height.Leave += new System.EventHandler(this.tbx_height_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Font Size:";
            // 
            // tbx_width
            // 
            this.tbx_width.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_width.Location = new System.Drawing.Point(81, 27);
            this.tbx_width.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_width.Name = "tbx_width";
            this.tbx_width.Size = new System.Drawing.Size(46, 25);
            this.tbx_width.TabIndex = 1;
            this.tbx_width.Text = "200";
            this.tbx_width.Leave += new System.EventHandler(this.tbx_width_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brightness:";
            // 
            // tbar_brightness
            // 
            this.tbar_brightness.LargeChange = 20;
            this.tbar_brightness.Location = new System.Drawing.Point(80, 62);
            this.tbar_brightness.Margin = new System.Windows.Forms.Padding(0);
            this.tbar_brightness.Maximum = 100;
            this.tbar_brightness.Minimum = -100;
            this.tbar_brightness.Name = "tbar_brightness";
            this.tbar_brightness.Size = new System.Drawing.Size(135, 45);
            this.tbar_brightness.SmallChange = 20;
            this.tbar_brightness.TabIndex = 20;
            this.tbar_brightness.TickFrequency = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded image";
            // 
            // pbx_image
            // 
            this.pbx_image.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbx_image.Location = new System.Drawing.Point(18, 33);
            this.pbx_image.Name = "pbx_image";
            this.pbx_image.Size = new System.Drawing.Size(209, 153);
            this.pbx_image.TabIndex = 0;
            this.pbx_image.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.b_selectCompressedFile);
            this.groupBox3.Controls.Add(this.rb_textFile);
            this.groupBox3.Controls.Add(this.btn_IPcamera);
            this.groupBox3.Controls.Add(this.btn_file);
            this.groupBox3.Controls.Add(this.rb_IPcamera);
            this.groupBox3.Controls.Add(this.rb_file);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Source";
            // 
            // b_selectCompressedFile
            // 
            this.b_selectCompressedFile.Enabled = false;
            this.b_selectCompressedFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_selectCompressedFile.Location = new System.Drawing.Point(10, 129);
            this.b_selectCompressedFile.Name = "b_selectCompressedFile";
            this.b_selectCompressedFile.Size = new System.Drawing.Size(96, 32);
            this.b_selectCompressedFile.TabIndex = 5;
            this.b_selectCompressedFile.Text = "Select File";
            this.b_selectCompressedFile.UseVisualStyleBackColor = true;
            this.b_selectCompressedFile.Click += new System.EventHandler(this.b_selectCompressedFile_Click);
            // 
            // rb_textFile
            // 
            this.rb_textFile.AutoSize = true;
            this.rb_textFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_textFile.Location = new System.Drawing.Point(10, 102);
            this.rb_textFile.Name = "rb_textFile";
            this.rb_textFile.Size = new System.Drawing.Size(125, 21);
            this.rb_textFile.TabIndex = 4;
            this.rb_textFile.Text = "Compressed text";
            this.rb_textFile.UseVisualStyleBackColor = true;
            this.rb_textFile.CheckedChanged += new System.EventHandler(this.rb_textFile_CheckedChanged);
            // 
            // btn_IPcamera
            // 
            this.btn_IPcamera.Enabled = false;
            this.btn_IPcamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_IPcamera.Location = new System.Drawing.Point(114, 61);
            this.btn_IPcamera.Name = "btn_IPcamera";
            this.btn_IPcamera.Size = new System.Drawing.Size(98, 30);
            this.btn_IPcamera.TabIndex = 3;
            this.btn_IPcamera.Text = "Properties";
            this.btn_IPcamera.UseVisualStyleBackColor = true;
            this.btn_IPcamera.Click += new System.EventHandler(this.btn_IPcamera_Click);
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_file.Location = new System.Drawing.Point(114, 23);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(99, 28);
            this.btn_file.TabIndex = 2;
            this.btn_file.Text = "Select File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // rb_IPcamera
            // 
            this.rb_IPcamera.AutoSize = true;
            this.rb_IPcamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_IPcamera.Location = new System.Drawing.Point(10, 66);
            this.rb_IPcamera.Name = "rb_IPcamera";
            this.rb_IPcamera.Size = new System.Drawing.Size(85, 21);
            this.rb_IPcamera.TabIndex = 1;
            this.rb_IPcamera.Text = "IP Camera";
            this.rb_IPcamera.UseVisualStyleBackColor = true;
            this.rb_IPcamera.CheckedChanged += new System.EventHandler(this.rb_IPcamera_CheckedChanged_1);
            // 
            // rb_file
            // 
            this.rb_file.AutoSize = true;
            this.rb_file.Checked = true;
            this.rb_file.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_file.Location = new System.Drawing.Point(11, 27);
            this.rb_file.Name = "rb_file";
            this.rb_file.Size = new System.Drawing.Size(85, 21);
            this.rb_file.TabIndex = 0;
            this.rb_file.TabStop = true;
            this.rb_file.Text = "Image File";
            this.rb_file.UseVisualStyleBackColor = true;
            this.rb_file.CheckedChanged += new System.EventHandler(this.rb_file_CheckedChanged);
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_convert.Location = new System.Drawing.Point(144, 611);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(89, 38);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_convert);
            this.splitContainer1.Panel1.Controls.Add(this.pbx_image);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel2.Controls.Add(this.label_request);
            this.splitContainer1.Panel2.Controls.Add(this.label_time);
            this.splitContainer1.Panel2.Controls.Add(this.rtbx_ascii);
            this.splitContainer1.Panel2.Controls.Add(this.menu_exportMenu);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 662);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stop.Location = new System.Drawing.Point(12, 611);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(89, 38);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label_request
            // 
            this.label_request.AutoSize = true;
            this.label_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_request.Location = new System.Drawing.Point(445, 5);
            this.label_request.Name = "label_request";
            this.label_request.Size = new System.Drawing.Size(96, 15);
            this.label_request.TabIndex = 3;
            this.label_request.Text = "Request time:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_time.Location = new System.Drawing.Point(605, 5);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(114, 15);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "Processing time:";
            // 
            // menu_exportMenu
            // 
            this.menu_exportMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_exportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsTextFileToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.flipASCIIImageToolStripMenuItem});
            this.menu_exportMenu.Location = new System.Drawing.Point(0, 0);
            this.menu_exportMenu.Name = "menu_exportMenu";
            this.menu_exportMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_exportMenu.Size = new System.Drawing.Size(784, 24);
            this.menu_exportMenu.TabIndex = 1;
            this.menu_exportMenu.Text = "Export Menu";
            // 
            // exportAsTextFileToolStripMenuItem
            // 
            this.exportAsTextFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exportText,
            this.menu_exportHTML,
            this.menu_exportJPG,
            this.compressedTextFiletxtToolStripMenuItem});
            this.exportAsTextFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportAsTextFileToolStripMenuItem.Name = "exportAsTextFileToolStripMenuItem";
            this.exportAsTextFileToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.exportAsTextFileToolStripMenuItem.Text = "Export ASCII Image as";
            // 
            // menu_exportText
            // 
            this.menu_exportText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_exportText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_exportText.Name = "menu_exportText";
            this.menu_exportText.Size = new System.Drawing.Size(213, 22);
            this.menu_exportText.Text = "Text file (*.txt)";
            this.menu_exportText.Click += new System.EventHandler(this.menu_exportText_Click);
            // 
            // menu_exportHTML
            // 
            this.menu_exportHTML.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_exportHTML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_exportHTML.Name = "menu_exportHTML";
            this.menu_exportHTML.Size = new System.Drawing.Size(213, 22);
            this.menu_exportHTML.Text = "HTML file (*.html)";
            this.menu_exportHTML.Click += new System.EventHandler(this.menu_exportHTML_Click);
            // 
            // menu_exportJPG
            // 
            this.menu_exportJPG.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_exportJPG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_exportJPG.Name = "menu_exportJPG";
            this.menu_exportJPG.Size = new System.Drawing.Size(213, 22);
            this.menu_exportJPG.Text = "Image file (*.jpeg)";
            this.menu_exportJPG.Click += new System.EventHandler(this.menu_exportJPG_Click);
            // 
            // compressedTextFiletxtToolStripMenuItem
            // 
            this.compressedTextFiletxtToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.compressedTextFiletxtToolStripMenuItem.Name = "compressedTextFiletxtToolStripMenuItem";
            this.compressedTextFiletxtToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.compressedTextFiletxtToolStripMenuItem.Text = "Compressed text file (*.txt)";
            this.compressedTextFiletxtToolStripMenuItem.Click += new System.EventHandler(this.compressedTextFiletxtToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_90degcw,
            this.menu_90degccw,
            this.menu_180deg});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.rotateToolStripMenuItem.Text = "Rotate Image";
            // 
            // menu_90degcw
            // 
            this.menu_90degcw.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_90degcw.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_90degcw.Name = "menu_90degcw";
            this.menu_90degcw.Size = new System.Drawing.Size(121, 22);
            this.menu_90degcw.Text = "90° CW";
            this.menu_90degcw.Click += new System.EventHandler(this.degreesClockwiseToolStripMenuItem_Click);
            // 
            // menu_90degccw
            // 
            this.menu_90degccw.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_90degccw.Name = "menu_90degccw";
            this.menu_90degccw.Size = new System.Drawing.Size(121, 22);
            this.menu_90degccw.Text = "90° CCW";
            this.menu_90degccw.Click += new System.EventHandler(this.degreesCounterclockwiseToolStripMenuItem_Click);
            // 
            // menu_180deg
            // 
            this.menu_180deg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_180deg.Name = "menu_180deg";
            this.menu_180deg.Size = new System.Drawing.Size(121, 22);
            this.menu_180deg.Text = "180°";
            this.menu_180deg.Click += new System.EventHandler(this.degreesToolStripMenuItem_Click);
            // 
            // flipASCIIImageToolStripMenuItem
            // 
            this.flipASCIIImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_flipHorizontal,
            this.menu_flipVertical});
            this.flipASCIIImageToolStripMenuItem.Name = "flipASCIIImageToolStripMenuItem";
            this.flipASCIIImageToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.flipASCIIImageToolStripMenuItem.Text = "Flip Image";
            // 
            // menu_flipHorizontal
            // 
            this.menu_flipHorizontal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_flipHorizontal.Name = "menu_flipHorizontal";
            this.menu_flipHorizontal.Size = new System.Drawing.Size(151, 22);
            this.menu_flipHorizontal.Text = "Flip Horizontal";
            this.menu_flipHorizontal.Click += new System.EventHandler(this.menu_flipHorizontal_Click);
            // 
            // menu_flipVertical
            // 
            this.menu_flipVertical.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_flipVertical.Name = "menu_flipVertical";
            this.menu_flipVertical.Size = new System.Drawing.Size(151, 22);
            this.menu_flipVertical.Text = "Flip Vertical";
            this.menu_flipVertical.Click += new System.EventHandler(this.menu_flipVertical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 662);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageToASCII (Adrian Bece, 2015.)";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.menu_exportMenu.ResumeLayout(false);
            this.menu_exportMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_ascii;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbar_brightness;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbx_image;
        private System.Windows.Forms.TextBox tbx_width;
        private System.Windows.Forms.TextBox tbx_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_IPcamera;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.RadioButton rb_file;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RadioButton rb_IPcamera;
        private System.Windows.Forms.TrackBar tbar_fontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_fontList;
        private System.Windows.Forms.CheckBox cbx_invert;
        private System.Windows.Forms.CheckBox cbx_reduceCharLib;
        private System.Windows.Forms.MenuStrip menu_exportMenu;
        private System.Windows.Forms.ToolStripMenuItem exportAsTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_exportText;
        private System.Windows.Forms.ToolStripMenuItem menu_exportHTML;
        private System.Windows.Forms.ToolStripMenuItem menu_exportJPG;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_90degcw;
        private System.Windows.Forms.ToolStripMenuItem menu_90degccw;
        private System.Windows.Forms.ToolStripMenuItem menu_180deg;
        private System.Windows.Forms.ToolStripMenuItem flipASCIIImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_flipHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menu_flipVertical;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_request;
        private System.Windows.Forms.ToolStripMenuItem compressedTextFiletxtToolStripMenuItem;
        private System.Windows.Forms.Button b_selectCompressedFile;
        private System.Windows.Forms.RadioButton rb_textFile;


    }
}

