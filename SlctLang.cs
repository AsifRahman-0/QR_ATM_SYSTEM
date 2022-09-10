using ATM;
using System.Media;

namespace WinFormsApp1

{
    public partial class SlctLang : Form
    {

        SoundPlayer sound = new SoundPlayer(@"F:\Project\ATM\Audio\Please_Select_Language.wav");
        public SlctLang()
        {
            InitializeComponent();
            sound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            
        }

        private void SlctLang_Load(object sender, EventArgs e)
        {

        }
    }
}