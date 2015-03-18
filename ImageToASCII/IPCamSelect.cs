using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageToASCII
{
    public partial class IPCamSelect : Form
    {
        public static string ipCamURL="";
        public static int delay=2000;

        public IPCamSelect()
        {
            InitializeComponent();
            tbx_delay.Text = delay.ToString();
            tbx_IP.Text = ipCamURL.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ipCamURL = tbx_IP.Text.ToString();
            int.TryParse(tbx_delay.Text, out delay);
            this.Close();
        }
    }
}
