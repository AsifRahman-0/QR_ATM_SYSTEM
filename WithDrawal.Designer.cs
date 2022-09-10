namespace ATM
{
    partial class WithDrawal
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.withDraw = new System.Windows.Forms.TextBox();
            this.AccNoDis = new System.Windows.Forms.Label();
            this.Bal = new System.Windows.Forms.Label();
            this.AccNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ellipseButton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BackgroundImage = global::ATM.Properties.Resources.background;
            this.guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 30;
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientPanel1.BorderThickness = 50;
            this.guna2GradientPanel1.Controls.Add(this.button1);
            this.guna2GradientPanel1.Controls.Add(this.withDraw);
            this.guna2GradientPanel1.Controls.Add(this.AccNoDis);
            this.guna2GradientPanel1.Controls.Add(this.Bal);
            this.guna2GradientPanel1.Controls.Add(this.AccNo);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label18);
            this.guna2GradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1143, 750);
            this.guna2GradientPanel1.TabIndex = 6;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // button1
            // 
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(438, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 30;
            this.button1.Text = "Confirm";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // withDraw
            // 
            this.withDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withDraw.Location = new System.Drawing.Point(516, 363);
            this.withDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.withDraw.Multiline = true;
            this.withDraw.Name = "withDraw";
            this.withDraw.Size = new System.Drawing.Size(264, 52);
            this.withDraw.TabIndex = 6;
            this.withDraw.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AccNoDis
            // 
            this.AccNoDis.AutoSize = true;
            this.AccNoDis.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccNoDis.Location = new System.Drawing.Point(516, 248);
            this.AccNoDis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccNoDis.Name = "AccNoDis";
            this.AccNoDis.Size = new System.Drawing.Size(229, 49);
            this.AccNoDis.TabIndex = 5;
            this.AccNoDis.Text = "Account No";
            this.AccNoDis.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Bal
            // 
            this.Bal.AutoSize = true;
            this.Bal.BackColor = System.Drawing.Color.Transparent;
            this.Bal.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Bal.ForeColor = System.Drawing.Color.Navy;
            this.Bal.Location = new System.Drawing.Point(171, 363);
            this.Bal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bal.Name = "Bal";
            this.Bal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bal.Size = new System.Drawing.Size(261, 61);
            this.Bal.TabIndex = 4;
            this.Bal.Text = "Withdraw";
            this.Bal.Click += new System.EventHandler(this.label2_Click);
            // 
            // AccNo
            // 
            this.AccNo.AutoSize = true;
            this.AccNo.BackColor = System.Drawing.Color.Transparent;
            this.AccNo.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AccNo.ForeColor = System.Drawing.Color.Navy;
            this.AccNo.Location = new System.Drawing.Point(157, 248);
            this.AccNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(320, 61);
            this.AccNo.TabIndex = 3;
            this.AccNo.Text = "Account No";
            this.AccNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Forte", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(283, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 61);
            this.label4.TabIndex = 2;
            this.label4.Text = "Withdrawal Window";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(1646, 48);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 23);
            this.label18.TabIndex = 2;
            this.label18.Text = "4:00 pm 6 Jun 2022";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ellipseButton
            // 
            this.ellipseButton.ElipseRadius = 40;
            this.ellipseButton.TargetControl = this.button1;
            // 
            // WithDrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WithDrawal";
            this.Text = "WithDrawal";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label18;
        private Label Bal;
        private Label AccNo;
        private Label label4;
        private Label AccNoDis;
        private TextBox withDraw;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse ellipseButton;
        private Guna.UI2.WinForms.Guna2Button button1;
    }
}