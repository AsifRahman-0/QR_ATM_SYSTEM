namespace ATM
{
    partial class Deposite
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.regAccNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.damount = new System.Windows.Forms.TextBox();
            this.ellipseBackground = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.depositbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ellipseButton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(320, 50);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(384, 63);
            this.guna2HtmlLabel2.TabIndex = 29;
            this.guna2HtmlLabel2.Text = "Deposit Money";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(113, 243);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(241, 37);
            this.guna2HtmlLabel1.TabIndex = 31;
            this.guna2HtmlLabel1.Text = "Account Number";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(487, 243);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(241, 37);
            this.guna2HtmlLabel3.TabIndex = 32;
            this.guna2HtmlLabel3.Text = "Account Number";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // regAccNo
            // 
            this.regAccNo.BackColor = System.Drawing.Color.Transparent;
            this.regAccNo.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regAccNo.ForeColor = System.Drawing.Color.Navy;
            this.regAccNo.Location = new System.Drawing.Point(113, 358);
            this.regAccNo.Name = "regAccNo";
            this.regAccNo.Size = new System.Drawing.Size(204, 37);
            this.regAccNo.TabIndex = 33;
            this.regAccNo.Text = "Enter Amount";
            // 
            // damount
            // 
            this.damount.Location = new System.Drawing.Point(487, 358);
            this.damount.Name = "damount";
            this.damount.Size = new System.Drawing.Size(217, 31);
            this.damount.TabIndex = 34;
            // 
            // ellipseBackground
            // 
            this.ellipseBackground.ElipseRadius = 100;
            this.ellipseBackground.TargetControl = this;
            // 
            // depositbtn
            // 
            this.depositbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.depositbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.depositbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.depositbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.depositbtn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.depositbtn.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositbtn.ForeColor = System.Drawing.Color.White;
            this.depositbtn.Location = new System.Drawing.Point(398, 534);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(172, 56);
            this.depositbtn.TabIndex = 36;
            this.depositbtn.Text = "Confirm";
            // 
            // ellipseButton
            // 
            this.ellipseButton.ElipseRadius = 40;
            this.ellipseButton.TargetControl = this.depositbtn;
            // 
            // Deposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 715);
            this.Controls.Add(this.depositbtn);
            this.Controls.Add(this.damount);
            this.Controls.Add(this.regAccNo);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Deposite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel regAccNo;
        private TextBox damount;
        private Bunifu.Framework.UI.BunifuElipse ellipseBackground;
        private Guna.UI2.WinForms.Guna2Button depositbtn;
        private Bunifu.Framework.UI.BunifuElipse ellipseButton;
    }
}