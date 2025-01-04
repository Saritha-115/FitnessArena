using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FitnessArena
{
    public partial class Forgot_pw : MetroFramework.Forms.MetroForm
    {
        public Forgot_pw()
        {
            InitializeComponent();
        }
        String randomCode;
        public static String to;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length == 0)
            {
                MessageBox.Show("ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Email cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_error.Text = "Enter a valid email. Ex:name@gmail.com";
            }
            else if (txtVerify.Text.Length == 0)
            {
                MessageBox.Show("OTP cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (randomCode == (txtVerify.Text).ToString())
            {

                to = txtEmail.Text;
                if (txt_pw.Text != txt_cpw.Text)
                {
                    MessageBox.Show("Confirm password does not match with the new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("Update Admin_tbl set  Client_password= '" + txt_pw.Text + "',Confirm_pass='" + txt_cpw.Text + "' where Client_id = '" + Convert.ToInt32(txt_id.Text) + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {

                        MessageBox.Show("Password Updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password cannot Update!! Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "fitnessarenasup@gmail.com";
            pass = "sjqjgypaimirnchz";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pw.Enabled = true;
                txt_cpw.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txt_pw.PasswordChar = '\0';
                txt_cpw.PasswordChar = '\0';
            }
            else
            {
                txt_pw.PasswordChar = '*';
                txt_cpw.PasswordChar = '*'; 
            }
        }

        private void Forgot_pw_Load(object sender, EventArgs e)
        {
            txt_cpw.Enabled = false;
            txt_pw.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txt_cpw.Enabled = false;
            txt_pw.Enabled = false;
        }
    }
}
