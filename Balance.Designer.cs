namespace ATM
{
    partial class Balance
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
            this.label4 = new System.Windows.Forms.Label();
            this.AccNo = new System.Windows.Forms.Label();
            this.Bal = new System.Windows.Forms.Label();
            this.AccNoDis = new System.Windows.Forms.Label();
            this.BalShow = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(259, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(618, 83);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance Window";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AccNo
            // 
            this.AccNo.AutoSize = true;
            this.AccNo.BackColor = System.Drawing.Color.Transparent;
            this.AccNo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccNo.Location = new System.Drawing.Point(181, 268);
            this.AccNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(226, 47);
            this.AccNo.TabIndex = 4;
            this.AccNo.Text = "Account No";
            this.AccNo.Click += new System.EventHandler(this.AccNo_Click);
            // 
            // Bal
            // 
            this.Bal.AutoSize = true;
            this.Bal.BackColor = System.Drawing.Color.Transparent;
            this.Bal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bal.Location = new System.Drawing.Point(181, 390);
            this.Bal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bal.Name = "Bal";
            this.Bal.Size = new System.Drawing.Size(160, 47);
            this.Bal.TabIndex = 5;
            this.Bal.Text = "Balance";
            // 
            // AccNoDis
            // 
            this.AccNoDis.AutoSize = true;
            this.AccNoDis.BackColor = System.Drawing.Color.Transparent;
            this.AccNoDis.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccNoDis.Location = new System.Drawing.Point(564, 268);
            this.AccNoDis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccNoDis.Name = "AccNoDis";
            this.AccNoDis.Size = new System.Drawing.Size(216, 47);
            this.AccNoDis.TabIndex = 6;
            this.AccNoDis.Text = "Account No";
            this.AccNoDis.Click += new System.EventHandler(this.label1_Click);
            // 
            // BalShow
            // 
            this.BalShow.AutoSize = true;
            this.BalShow.BackColor = System.Drawing.Color.Transparent;
            this.BalShow.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalShow.Location = new System.Drawing.Point(564, 392);
            this.BalShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalShow.Name = "BalShow";
            this.BalShow.Size = new System.Drawing.Size(150, 47);
            this.BalShow.TabIndex = 7;
            this.BalShow.Text = "Balance";
            this.BalShow.Click += new System.EventHandler(this.BalShow_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.BalShow);
            this.Controls.Add(this.AccNoDis);
            this.Controls.Add(this.Bal);
            this.Controls.Add(this.AccNo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Balance";
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label AccNo;
        private Label Bal;
        private Label AccNoDis;
        private Label BalShow;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}