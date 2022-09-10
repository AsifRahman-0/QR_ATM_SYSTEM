namespace ATM
{
    partial class regForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regForm));
            this.verifyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sendOtp = new Guna.UI2.WinForms.Guna2Button();
            this.oTp = new System.Windows.Forms.TextBox();
            this.regAccNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.otpVerifyHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.scanEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.verifyEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ellipseDone = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Done = new Guna.UI2.WinForms.Guna2Button();
            this.RegAccNoText = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PassCode = new System.Windows.Forms.TextBox();
            this.pincodeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // verifyBtn
            // 
            this.verifyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verifyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verifyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verifyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verifyBtn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.verifyBtn.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verifyBtn.ForeColor = System.Drawing.Color.White;
            this.verifyBtn.Location = new System.Drawing.Point(582, 424);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(172, 56);
            this.verifyBtn.TabIndex = 21;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
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
            this.sendOtp.Location = new System.Drawing.Point(559, 270);
            this.sendOtp.Name = "sendOtp";
            this.sendOtp.Size = new System.Drawing.Size(204, 49);
            this.sendOtp.TabIndex = 20;
            this.sendOtp.Text = "Send OTP";
            this.sendOtp.Click += new System.EventHandler(this.sendOtp_Click);
            // 
            // oTp
            // 
            this.oTp.Location = new System.Drawing.Point(382, 363);
            this.oTp.Name = "oTp";
            this.oTp.PlaceholderText = "Enter OTP";
            this.oTp.Size = new System.Drawing.Size(381, 31);
            this.oTp.TabIndex = 19;
            // 
            // regAccNo
            // 
            this.regAccNo.BackColor = System.Drawing.Color.Transparent;
            this.regAccNo.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regAccNo.ForeColor = System.Drawing.Color.Navy;
            this.regAccNo.Location = new System.Drawing.Point(382, 140);
            this.regAccNo.Name = "regAccNo";
            this.regAccNo.Size = new System.Drawing.Size(241, 37);
            this.regAccNo.TabIndex = 15;
            this.regAccNo.Text = "Account Number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(41, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 208);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // otpVerifyHeading
            // 
            this.otpVerifyHeading.BackColor = System.Drawing.Color.Transparent;
            this.otpVerifyHeading.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.otpVerifyHeading.ForeColor = System.Drawing.Color.Navy;
            this.otpVerifyHeading.Location = new System.Drawing.Point(382, -60);
            this.otpVerifyHeading.Name = "otpVerifyHeading";
            this.otpVerifyHeading.Size = new System.Drawing.Size(395, 63);
            this.otpVerifyHeading.TabIndex = 13;
            this.otpVerifyHeading.Text = "OTP Verification";
            // 
            // scanEllipse
            // 
            this.scanEllipse.ElipseRadius = 90;
            this.scanEllipse.TargetControl = this;
            // 
            // verifyEllipse
            // 
            this.verifyEllipse.ElipseRadius = 40;
            this.verifyEllipse.TargetControl = this.verifyBtn;
            // 
            // ellipseDone
            // 
            this.ellipseDone.ElipseRadius = 40;
            this.ellipseDone.TargetControl = this.Done;
            // 
            // Done
            // 
            this.Done.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Done.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Done.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Done.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Done.FillColor = System.Drawing.Color.PaleTurquoise;
            this.Done.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Done.ForeColor = System.Drawing.Color.White;
            this.Done.Location = new System.Drawing.Point(956, 621);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(172, 56);
            this.Done.TabIndex = 24;
            this.Done.Text = "Done";
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // RegAccNoText
            // 
            this.RegAccNoText.Location = new System.Drawing.Point(382, 198);
            this.RegAccNoText.Name = "RegAccNoText";
            this.RegAccNoText.Size = new System.Drawing.Size(381, 31);
            this.RegAccNoText.TabIndex = 18;
            this.RegAccNoText.TextChanged += new System.EventHandler(this.RegAccNoText_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(292, 34);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(590, 63);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "ATM Registration Page";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            this.bunifuElipse2.TargetControl = this.sendOtp;
            // 
            // PassCode
            // 
            this.PassCode.Location = new System.Drawing.Point(382, 584);
            this.PassCode.Name = "PassCode";
            this.PassCode.Size = new System.Drawing.Size(381, 31);
            this.PassCode.TabIndex = 25;
            this.PassCode.TextChanged += new System.EventHandler(this.PassCode_TextChanged);
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.pincodeLabel.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pincodeLabel.ForeColor = System.Drawing.Color.Navy;
            this.pincodeLabel.Location = new System.Drawing.Point(381, 521);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(242, 37);
            this.pincodeLabel.TabIndex = 26;
            this.pincodeLabel.Text = "Set your Pincode";
            this.pincodeLabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 715);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.PassCode);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.sendOtp);
            this.Controls.Add(this.oTp);
            this.Controls.Add(this.regAccNo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.otpVerifyHeading);
            this.Controls.Add(this.RegAccNoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regForm";
            this.Load += new System.EventHandler(this.regForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button verifyBtn;
        private Guna.UI2.WinForms.Guna2Button sendOtp;
        private TextBox oTp;
        private Guna.UI2.WinForms.Guna2HtmlLabel regAccNo;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel otpVerifyHeading;
        private Bunifu.Framework.UI.BunifuElipse scanEllipse;
        private TextBox RegAccNoText;
        private Bunifu.Framework.UI.BunifuElipse verifyEllipse;
        private Bunifu.Framework.UI.BunifuElipse ellipseDone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button Done;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private TextBox PassCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel pincodeLabel;
    }
}