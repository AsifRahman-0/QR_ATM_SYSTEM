namespace WinFormsApp1
{
    partial class SlctLang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlctLang));
            this.English = new System.Windows.Forms.Button();
            this.Hindi = new System.Windows.Forms.Button();
            this.ellipseEnglish = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ellipseHindi = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.select = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ellipseBack = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // English
            // 
            this.English.BackColor = System.Drawing.Color.LightCyan;
            this.English.Font = new System.Drawing.Font("Viner Hand ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.English.ForeColor = System.Drawing.Color.Navy;
            this.English.Location = new System.Drawing.Point(340, 191);
            this.English.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(164, 48);
            this.English.TabIndex = 0;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = false;
            this.English.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hindi
            // 
            this.Hindi.BackColor = System.Drawing.Color.LightCyan;
            this.Hindi.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Hindi.ForeColor = System.Drawing.Color.Navy;
            this.Hindi.Location = new System.Drawing.Point(340, 287);
            this.Hindi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hindi.Name = "Hindi";
            this.Hindi.Size = new System.Drawing.Size(164, 48);
            this.Hindi.TabIndex = 1;
            this.Hindi.Text = "हिन्दी";
            this.Hindi.UseVisualStyleBackColor = false;
            // 
            // ellipseEnglish
            // 
            this.ellipseEnglish.ElipseRadius = 100;
            this.ellipseEnglish.TargetControl = this.English;
            // 
            // ellipseHindi
            // 
            this.ellipseHindi.ElipseRadius = 100;
            this.ellipseHindi.TargetControl = this.Hindi;
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.BackColor = System.Drawing.Color.Transparent;
            this.select.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.select.ForeColor = System.Drawing.Color.Navy;
            this.select.Location = new System.Drawing.Point(223, 20);
            this.select.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(415, 53);
            this.select.TabIndex = 2;
            this.select.Text = "Please Select Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(288, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "कृपया भाषा चुनें";
            // 
            // ellipseBack
            // 
            this.ellipseBack.ElipseRadius = 100;
            this.ellipseBack.TargetControl = this;
            // 
            // SlctLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.Hindi);
            this.Controls.Add(this.English);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SlctLang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectLanguage";
            this.Load += new System.EventHandler(this.SlctLang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button English;
        private Button Hindi;
        private Bunifu.Framework.UI.BunifuElipse ellipseEnglish;
        private Bunifu.Framework.UI.BunifuElipse ellipseHindi;
        private Label select;
        private Label label1;
        private Bunifu.Framework.UI.BunifuElipse ellipseBack;
    }
}