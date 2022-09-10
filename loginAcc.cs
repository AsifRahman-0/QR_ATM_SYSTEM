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
    public partial class loginAcc : Form
    {

        public static bool flag = false;
        public static String Acc = "";
        string acc = Login.acount1;
        public static bool flags = false;

        public loginAcc()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT AccountNumber FROM [DBO].[Table] ";
            cmd.Connection = conn;
            SqlDataReader rd = cmd.ExecuteReader();

            List<string> list = new List<string>();

            try
            {
                while (rd.Read())
                {
                    list.Add(rd[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                rd.Close();
                conn.Close();
            }
            if(list.Contains(acc))
            {
                flag = true;
            }

        }

        private void otpVerifyHeading_Click(object sender, EventArgs e)
        {

        }

        private void sendOtp_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();





            
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from [DBO].[Table] where AccountNumber='" + accountNo.Text + "' and PassWord= '" + passWord.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid Pin Code");
            }
















            /*SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select PassWord From [DBO].[Table]  ";
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                flags = true;
            }
            else
            {
                flags = false;
            }
            dr.Close();




            if (flags == true)
            {



                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                conn.Close();


            }
            */
            /*  this.Hide();
              Dashboard dashboard = new Dashboard();
              dashboard.ShowDialog();*/
        }

        private void accountNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginAcc_Load(object sender, EventArgs e)
        {
            this.Hide();
            if (flag)
               Acc = accountNo.Text = Login.acount1;
            else
            {

                MessageBox.Show("Invalid");
                this.Close();
                Login log = new Login();
                log.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
