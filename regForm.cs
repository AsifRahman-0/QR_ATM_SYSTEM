using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net;
using System.Configuration;
using System.Net.Mime;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;


namespace ATM
{
    public partial class regForm : Form
    {
        String randomCode;
        SqlConnection conn = new SqlConnection();
        MailMessage mail = new MailMessage();

        bool flag = false;

        public regForm()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegAccNoText_TextChanged(object sender, EventArgs e)
        {



        }


        private void sendOtp_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";




            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT AccountNumber FROM[DBO].[Table]";
            cmd.Connection = conn;





            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {

                flag = true;
                

            }
            rd.Close();


            if (flag == true)
            {

                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "SELECT Email FROM [DBO].[Table] WHERE AccountNumber= '" + RegAccNoText.Text + "'";




                String messageBody;
                Random random = new Random();
                randomCode = (random.Next(9999)).ToString();

                string fromaddress = "vilen.9996@gmail.com";

                string password = "pcjgtsrbxwhbnleu";

                
                mail.Subject = "ADI Bank Private Limited";
                mail.From = new MailAddress(fromaddress);
                messageBody = "You OTP for generating Virtual ATM Card is " + randomCode;
                mail.Body = messageBody;


                

                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UseR\Documents\BANKDb.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.Open();
                // SqlCommand cmd = new SqlCommand();
                //  string queryString = "SELECT EMAIL FROM[DBO].[Table] WHERE AccountNumber = '" + RegAccNoText + "'";
                cmd1.Connection = conn;
                // cmd1.CommandText = queryString;
                SqlDataReader dr = cmd1.ExecuteReader();

                //int selectedValue = Convert.ToInt32(dr.selectedValue.ToString());
                //cmd.Parameters.AddWithValue("@mail", selectedValue);

                if (dr.Read())
                {


                    var to = new MailAddress(dr["Email"].ToString());
                    mail.To.Add(to);
                }
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                NetworkCredential nec = new NetworkCredential(fromaddress, password);
                smtp.Credentials = nec;


                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("OTP Sent");
                    oTp.Visible = true;
                    verifyBtn.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("Not valid Acount Number");
            }





        }

        private void regForm_Load(object sender, EventArgs e)
        {
            PassCode.Visible = false;


            oTp.Visible = false;
            verifyBtn.Visible = false;
            pincodeLabel.Visible = false;
            Done.Visible = false;



        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {


            if (randomCode == (oTp.Text).ToString())
            {
                //toaddress = oTp.Text;

                
                PassCode.Visible = true;
                pincodeLabel.Visible = true;
                Done.Visible = true;


           
                
            //set height and width of qr code
            var options = new QrCodeEncodingOptions { Height = 250, Width = 250, Margin = 1 };
            



            //create instance of QRCODE
            BarcodeWriter barcodeW = new BarcodeWriter();

            //set format
            barcodeW.Format = BarcodeFormat.QR_CODE;


            
            

            barcodeW.Options = options;



            var text = RegAccNoText.Text;
            barcodeW.Write(text).Save(@"F:\Project\ATM\QRFiles\" +text+ ".png");

            //var resultOfQrcode = barcodeW.Write(text);







            MessageBox.Show("OTP Verified and Qr Generated");

                


            }

            else if(randomCode == null)
            {
                MessageBox.Show("Please enter the OTP");

            }

            else
            {
                MessageBox.Show("Wrong OTP");
            }

            

           
        }

        private void PassCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {

            //attachment
            
            
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "SELECT Email FROM [DBO].[Table] WHERE AccountNumber= '" + RegAccNoText.Text + "'";
            cmd2.Connection = conn;


            

            String messageBody;

            string fromaddress = "vilen.9996@gmail.com";

            string password = "pcjgtsrbxwhbnleu";


            mail.Subject = "ADI Bank Private Limited";
            mail.From = new MailAddress(fromaddress);
            messageBody = "You Virtual QR ATM is here 👇";
            mail.Body = messageBody;



            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"F:\Project\ATM\QRFiles\" + RegAccNoText.Text + ".png");
            mail.Attachments.Add(attachment);

            SqlDataReader dr3 = cmd2.ExecuteReader();



            if (dr3.Read())
            {


                var to = new MailAddress(dr3["Email"].ToString());
                mail.To.Add(to);
            }
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            NetworkCredential nec = new NetworkCredential(fromaddress, password);
            smtp.Credentials = nec;


            try
            {
                smtp.Send(mail);
                MessageBox.Show("");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dr3.Close();

            cmd2.Connection = conn;
            // cmd1.CommandText = queryString;
            SqlDataReader dr = cmd2.ExecuteReader();












            //Setting PIN
            conn.Close();
            conn.ConnectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASHIF\OneDrive\Documents\atmServer.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " update [dbo].[table] set PassWord= '" + PassCode.Text + "' where AccountNumber='" + RegAccNoText.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Successfully PIN Set");
            


            //
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog(); 





        }
    }
}

