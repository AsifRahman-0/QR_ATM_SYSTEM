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
    public partial class profile : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        static string name;
        static string mobile;
        static string email;

        public profile()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
            string accunnum = loginAcc.Acc;
            con.Open();
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Name From [dbo].[Table] Where AccountNumber = '" + accunnum + "'";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                name = rd["Name"].ToString();
                
               
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "Select Mobile From [dbo].[Table] Where AccountNumber = '" + accunnum + "'";
            cmd1.Connection = con;
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                mobile = dr["Mobile"].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "Select Email From [dbo].[Table] Where AccountNumber = '" + accunnum + "'";
            cmd2.Connection = con;
            SqlDataReader drd = cmd2.ExecuteReader();
            if (drd.Read())
            {
                email = drd["Email"].ToString();
            }
            con.Close();
            label6.Text = name;
            label7.Text = accunnum;
            label8.Text = mobile;
            label10.Text = email;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
