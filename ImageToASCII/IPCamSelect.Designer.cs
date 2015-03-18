namespace ImageToASCII
{
    partial class IPCamSelect
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_delay = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP Address:";
            // 
            // tbx_IP
            // 
            this.tbx_IP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_IP.Location = new System.Drawing.Point(112, 49);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.Size = new System.Drawing.Size(254, 29);
            this.tbx_IP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delay:";
            // 
            // tbx_delay
            // 
            this.tbx_delay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_delay.Location = new System.Drawing.Point(112, 94);
            this.tbx_delay.Name = "tbx_delay";
            this.tbx_delay.Size = new System.Drawing.Size(59, 29);
            this.tbx_delay.TabIndex = 7;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_confirm.Location = new System.Drawing.Point(292, 218);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(82, 36);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_close.Location = new System.Drawing.Point(199, 218);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(82, 36);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Cancel";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 188);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 51);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recommended delays: 1400 ms minimum.\r\nResolution 200x100: 1500 ms\r\nResolution 400" +
    "x200: 2000 ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(171, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "ms";
            // 
            // IPCamSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(384, 266);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_delay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_IP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IPCamSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPCamSelect";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_delay;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}