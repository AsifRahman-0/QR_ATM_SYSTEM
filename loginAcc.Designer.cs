namespace ATM
{
    partial class loginAcc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginAcc));
            this.otpVerifyHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Acc_no = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passWord = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sendOtp = new Guna.UI2.WinForms.Guna2Button();
            this.scanEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.verifyEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.accountNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // otpVerifyHeading
            // 
            this.otpVerifyHeading.BackColor = System.Drawing.Color.Transparent;
            this.otpVerifyHeading.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.otpVerifyHeading.ForeColor = System.Drawing.Color.Navy;
            this.otpVerifyHeading.Location = new System.Drawing.Point(366, 21);
            this.otpVerifyHeading.Margin = new System.Windows.Forms.Padding(2);
            this.otpVerifyHeading.Name = "otpVerifyHeading";
            this.otpVerifyHeading.Size = new System.Drawing.Size(90, 43);
            this.otpVerifyHeading.TabIndex = 3;
            this.otpVerifyHeading.Text = "Login";
            this.otpVerifyHeading.Click += new System.EventHandler(this.otpVerifyHeading_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(40, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 125);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Acc_no
            // 
            this.Acc_no.BackColor = System.Drawing.Color.Transparent;
            this.Acc_no.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Acc_no.ForeColor = System.Drawing.Color.Navy;
            this.Acc_no.Location = new System.Drawing.Point(291, 208);
            this.Acc_no.Margin = new System.Windows.Forms.Padding(2);
            this.Acc_no.Name = "Acc_no";
            this.Acc_no.Size = new System.Drawing.Size(90, 24);
            this.Acc_no.TabIndex = 7;
            this.Acc_no.Text = "Pin Code";
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(291, 242);
            this.passWord.Margin = new System.Windows.Forms.Padding(2);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(268, 23);
            this.passWord.TabIndex = 8;
            this.passWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(291, 133);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(164, 24);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Account Number";
            // 
            // sendOtp
            // 
            this.sendOtp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendOtp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendOtp.FillColor = System.Drawing.Color.PaleTurquoise;
            this.sendOtp.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendOtp.ForeColor = System.Drawing.Color.White;
            this.sendOtp.Location = new System.Drawing.Point(415, 272);
            this.sendOtp.Margin = new System.Windows.Forms.Padding(2);
            this.sendOtp.Name = "sendOtp";
            this.sendOtp.Size = new System.Drawing.Size(143, 29);
            this.sendOtp.TabIndex = 11;
            this.sendOtp.Text = "Enter";
            this.sendOtp.Click += new System.EventHandler(this.sendOtp_Click);
            // 
            // scanEllipse
            // 
            this.scanEllipse.ElipseRadius = 90;
            this.scanEllipse.TargetControl = this;
            // 
            // verifyEllipse
            // 
            this.verifyEllipse.ElipseRadius = 40;
            this.verifyEllipse.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.sendOtp;
            // 
            // accountNo
            // 
            this.accountNo.Location = new System.Drawing.Point(293, 160);
            this.accountNo.Margin = new System.Windows.Forms.Padding(2);
            this.accountNo.Name = "accountNo";
            this.accountNo.ReadOnly = true;
            this.accountNo.Size = new System.Drawing.Size(266, 23);
            this.accountNo.TabIndex = 12;
            this.accountNo.TextChanged += new System.EventHandler(this.accountNo_TextChanged);
            // 
            // loginAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 429);
            this.Controls.Add(this.accountNo);
            this.Controls.Add(this.sendOtp);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Acc_no);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.otpVerifyHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginAcc";
            this.Load += new System.EventHandler(this.loginAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel otpVerifyHeading;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Acc_no;
        private TextBox passWord;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button sendOtp;
        private Bunifu.Framework.UI.BunifuElipse scanEllipse;
        private Bunifu.Framework.UI.BunifuElipse verifyEllipse;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public TextBox accountNo;
    }
}