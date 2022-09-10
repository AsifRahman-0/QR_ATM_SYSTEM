namespace ATM
{
    partial class PinChange
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
            this.ellipseBackground = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pincodeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pinCode = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cnfrmPincode = new System.Windows.Forms.TextBox();
            this.cnfrm = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // ellipseBackground
            // 
            this.ellipseBackground.ElipseRadius = 100;
            this.ellipseBackground.TargetControl = this;
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.pincodeLabel.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pincodeLabel.ForeColor = System.Drawing.Color.Navy;
            this.pincodeLabel.Location = new System.Drawing.Point(232, 166);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(242, 37);
            this.pincodeLabel.TabIndex = 28;
            this.pincodeLabel.Text = "Set your Pincode";
            // 
            // pinCode
            // 
            this.pinCode.Location = new System.Drawing.Point(233, 229);
            this.pinCode.Name = "pinCode";
            this.pinCode.Size = new System.Drawing.Size(381, 31);
            this.pinCode.TabIndex = 27;
            this.pinCode.TextChanged += new System.EventHandler(this.PassCode_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(232, 366);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(313, 37);
            this.guna2HtmlLabel1.TabIndex = 30;
            this.guna2HtmlLabel1.Text = "Confirm your Pincode";
            // 
            // cnfrmPincode
            // 
            this.cnfrmPincode.Location = new System.Drawing.Point(233, 429);
            this.cnfrmPincode.Name = "cnfrmPincode";
            this.cnfrmPincode.Size = new System.Drawing.Size(381, 31);
            this.cnfrmPincode.TabIndex = 29;
            this.cnfrmPincode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cnfrm
            // 
            this.cnfrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cnfrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cnfrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cnfrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cnfrm.FillColor = System.Drawing.Color.PaleTurquoise;
            this.cnfrm.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cnfrm.ForeColor = System.Drawing.Color.White;
            this.cnfrm.Location = new System.Drawing.Point(496, 557);
            this.cnfrm.Name = "cnfrm";
            this.cnfrm.Size = new System.Drawing.Size(172, 56);
            this.cnfrm.TabIndex = 31;
            this.cnfrm.Text = "Confirm";
            this.cnfrm.Click += new System.EventHandler(this.cnfrm_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.cnfrm;
            // 
            // PinChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 715);
            this.Controls.Add(this.cnfrm);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cnfrmPincode);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.pinCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PinChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ellipseBackground;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TextBox cnfrmPincode;
        private Guna.UI2.WinForms.Guna2HtmlLabel pincodeLabel;
        private TextBox pinCode;
        private Guna.UI2.WinForms.Guna2Button cnfrm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}