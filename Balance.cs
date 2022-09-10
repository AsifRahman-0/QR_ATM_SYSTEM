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
    public partial class Balance : Form
    {
        static String bal="";
        public Balance()
        {
            InitializeComponent();
            AccNoDis.Text = loginAcc.Acc;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Balance From [dbo].[Table] Where AccountNumber = '"+AccNoDis.Text+"'";
            cmd.Connection = conn;
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                bal = rd["Balance"].ToString(); ;
            }
            BalShow.Text = bal;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AccNo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BalShow_Click(object sender, EventArgs e)
        {

        }
    }
}
