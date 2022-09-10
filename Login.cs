using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;

namespace ATM
{
    public partial class Login : Form
    {

        bool flag = false;
        public static String barCode = "";
        public static string acount1 = "";
        SoundPlayer sound = new SoundPlayer(@"F:\Project\ATM\Audio\login.wav");
        public Login()
        {
            InitializeComponent();
            sound.Play();
        }
        

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;  

        private void signUp_Click(object sender, EventArgs e)
        {

            regForm regForm = new regForm();
            regForm.Show();
            this.Hide();



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);

            
            cboDevice.SelectedIndex = 0;

            captureDevice = new VideoCaptureDevice();
            
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone(); ;
             
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            



            if (!(captureDevice == null))
                if (captureDevice.IsRunning)
                {
                    captureDevice.SignalToStop();
                    captureDevice = null;
                }

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            try {
                if (pictureBox1.Image != null)
                {
                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                    {

                        acount1 = result.ToString();
                        


                        timer1.Stop();
                        if (!(captureDevice == null))
                            if (captureDevice.IsRunning)
                            {
                                captureDevice.SignalToStop();
                                captureDevice = null;
                            }

                        loginAcc loginAcc = new loginAcc();
                        loginAcc.Show();
                        this.Hide();


                    } 
                }
            }
            catch (Exception ex)
            {

            }





        }

        private void Start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            captureDevice.Start();
            timer1.Start();
            
                

        }

        private void qrDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
