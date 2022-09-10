using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void picATM_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2vProgressBar3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2vSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Withdrawl_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithDrawal wd = new WithDrawal();
            wd.ShowDialog();
            
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposite dp = new Deposite();
                dp.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pin_Change_Click(object sender, EventArgs e)
        {
            this.Hide();
            PinChange pin = new PinChange();
            pin.ShowDialog();

        }

        private void Mini_Statement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance bal = new Balance();
            bal.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void profileImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pf = new profile();
            pf.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void exit_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
