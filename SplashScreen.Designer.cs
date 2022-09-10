namespace WinFormsApp1
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.ellipseBackground = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gifBox = new System.Windows.Forms.PictureBox();
            this.outerProgress = new System.Windows.Forms.Panel();
            this.innerProgress = new System.Windows.Forms.Panel();
            this.elipseInnerProgress = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseOuterEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.text = new System.Windows.Forms.Label();
            this.ellipseText = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).BeginInit();
            this.outerProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // ellipseBackground
            // 
            this.ellipseBackground.ElipseRadius = 100;
            this.ellipseBackground.TargetControl = this;
            // 
            // gifBox
            // 
            this.gifBox.BackColor = System.Drawing.Color.Transparent;
            this.gifBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gifBox.BackgroundImage")));
            this.gifBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gifBox.Location = new System.Drawing.Point(267, -2);
            this.gifBox.Name = "gifBox";
            this.gifBox.Size = new System.Drawing.Size(636, 432);
            this.gifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifBox.TabIndex = 0;
            this.gifBox.TabStop = false;
            this.gifBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // outerProgress
            // 
            this.outerProgress.BackColor = System.Drawing.Color.Transparent;
            this.outerProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.outerProgress.Controls.Add(this.innerProgress);
            this.outerProgress.Location = new System.Drawing.Point(230, 564);
            this.outerProgress.Margin = new System.Windows.Forms.Padding(0);
            this.outerProgress.Name = "outerProgress";
            this.outerProgress.Padding = new System.Windows.Forms.Padding(5);
            this.outerProgress.Size = new System.Drawing.Size(809, 50);
            this.outerProgress.TabIndex = 1;
            // 
            // innerProgress
            // 
            this.innerProgress.BackColor = System.Drawing.Color.Aquamarine;
            this.innerProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.innerProgress.Location = new System.Drawing.Point(5, 5);
            this.innerProgress.Name = "innerProgress";
            this.innerProgress.Size = new System.Drawing.Size(112, 40);
            this.innerProgress.TabIndex = 0;
            this.innerProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // elipseInnerProgress
            // 
            this.elipseInnerProgress.ElipseRadius = 40;
            this.elipseInnerProgress.TargetControl = this.innerProgress;
            // 
            // elipseOuterEllipse
            // 
            this.elipseOuterEllipse.ElipseRadius = 50;
            this.elipseOuterEllipse.TargetControl = this.outerProgress;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text.Font = new System.Drawing.Font("Forte", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.Color.Orchid;
            this.text.Location = new System.Drawing.Point(361, 487);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(523, 52);
            this.text.TabIndex = 2;
            this.text.Text = "QR Based ATM System";
            // 
            // ellipseText
            // 
            this.ellipseText.ElipseRadius = 30;
            this.ellipseText.TargetControl = this.text;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1200;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.text);
            this.Controls.Add(this.outerProgress);
            this.Controls.Add(this.gifBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplasScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).EndInit();
            this.outerProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ellipseBackground;
        private Panel outerProgress;
        private PictureBox gifBox;
        private Bunifu.Framework.UI.BunifuElipse elipseInnerProgress;
        private Bunifu.Framework.UI.BunifuElipse elipseOuterEllipse;
        private Label text;
        private Bunifu.Framework.UI.BunifuElipse ellipseText;
        private System.Windows.Forms.Timer Timer;
        private Panel innerProgress;
    }
}