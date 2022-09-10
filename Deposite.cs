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
    public partial class Deposite : Form
    {

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        public int balnce, newbalnce;
        string accnum = loginAcc.Acc;
        
        public Deposite()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
            guna2HtmlLabel3.Text = accnum;
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dsda = new SqlDataAdapter("select Balance from [dbo].[table] where AccountNumber= '" + accnum + "'  ", conn);
            DataTable dtbl = new DataTable();
            dsda.Fill(dtbl);
            balnce = Convert.ToInt32(dtbl.Rows[0][0].ToString());
            conn.Close();
            if (guna2HtmlLabel3.Text == "")
            {
                MessageBox.Show("Enter some Amount");
            }
            else if (Convert.ToInt32(guna2HtmlLabel3.Text) <= 0)
            {
                MessageBox.Show("Enter Valid amount");
            }

            else
            {
                newbalnce = balnce + Convert.ToInt32(guna2HtmlLabel3.Text);
                try
                {
                    conn.Open();
                    string q = " update [dbo].[table] set balance= " + newbalnce + " where AccountNumber='" + accnum + "'; ";
                    SqlCommand sqlc = new SqlCommand(q, conn);
                    sqlc.ExecuteNonQuery();
                    MessageBox.Show("Amount Deposited");
                    conn.Close();
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
