using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using ATM;

namespace WinFormsApp1
{
    public partial class SplashScreen : Form
    {




        SoundPlayer sound = new SoundPlayer(@"F:\Project\ATM\Audio\welcome.wav");
        public SplashScreen()
        {
            InitializeComponent();
            sound.Play();
            
            





        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void innerProgress_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            innerProgress.Width = 0;
            Timer.Start();
            
           


        }





        



        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                innerProgress.Width = innerProgress.Width + 6;

                gifBox.Update();
                

                Thread.Sleep(20);
            }
            
            Timer.Stop();

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
