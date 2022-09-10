using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM
{
    public partial class WithDrawal : Form
    {
        string conStr= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        string acco = loginAcc.Acc;
        public WithDrawal()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
            AccNoDis.Text = loginAcc.Acc;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
        public int bal, newbal;

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter wsda = new SqlDataAdapter("select Balance from [dbo].[table] where AccountNumber= '" + acco + "'  ", con);
            DataTable dtb = new DataTable();
            wsda.Fill(dtb);
            bal = Convert.ToInt32(dtb.Rows[0][0].ToString());


            con.Close();

            if (withDraw.Text == "")
            {
                MessageBox.Show("Enter some Amount");
            }
            else if (Convert.ToInt32(withDraw.Text) <= 0)
            {
                MessageBox.Show("Enter Valid amount");
            }
            else if (Convert.ToInt32(withDraw.Text) >= bal)
            {
                MessageBox.Show("Not Sufficient Balance");
            }
            else
            {
                newbal = bal - Convert.ToInt32(withDraw.Text);
                try
                {
                    con.Open();
                    string query = " update [dbo].[table] set Balance= " + newbal + " where AccountNumber='" + acco + "'; ";
                    SqlCommand sqlc = new SqlCommand(query, con);
                    sqlc.ExecuteNonQuery();
                    MessageBox.Show("Amount withdrawn");
                    con.Close();
                    Dashboard d = new Dashboard();
                    this.Hide();
                    d.Show();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            }

       
    }
}
