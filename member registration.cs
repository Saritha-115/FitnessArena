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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;


namespace FitnessArena
{
    public partial class member_registration : MetroFramework.Forms.MetroForm
    {
        public member_registration()
        {
            InitializeComponent();
        }
        public static String to;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public void clear()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_age.Clear();
            txt_address.Clear();
            txt_tp.Clear();
            txt_email.Clear();
            txt_pw.Clear();
            txt_cpw.Clear();
            dateTimePicker_join.Refresh();
            dateTimePicker_dob.Refresh();
        }
        public void GetCustomerId()
        {

            string custid;
            string custdetails = "select Client_id from Registration order by Client_id Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(custdetails, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                custid = id.ToString("0");

            }
            else if (Convert.IsDBNull(dr))
            {
                custid = ("1");

            }
            else
            {
                custid = ("1");

            }
            con.Close();
            txt_id.Text = custid.ToString();


        }
        private void btn_reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    lbl_error.Text = "Client ID cannot be blank";
                    txt_id.Focus();
                }
                else if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    lbl_error.Text = "First Name cannot be blank";
                    txt_fname.Focus();
                }
                else if (txt_fname.Text.Any(char.IsDigit))
                {
                    lbl_error.Text = "First Name cannot have numbers";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    lbl_error.Text = "Last Name cannot be blank";
                    txt_lname.Focus();
                }
                else if (txt_lname.Text.Any(char.IsDigit))
                {
                    lbl_error.Text = "Last Name cannot have numbers";
                    txt_lname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_age.Text) || txt_age.Text.Any(Char.IsLetter))
                {
                    lbl_error.Text = "Age Cannot be Empty Or Please Enter Numeric values";
                    txt_age.Clear();
                    txt_age.Focus();
                }
                else if (Convert.ToInt32(txt_age.Text) <= 10 && Convert.ToInt32(txt_age.Text) >= 70)
                {
                    lbl_error.Text = "Age Must Be Between 10 and 70";
                    txt_age.Enabled = false;
                    txt_age.Clear();
                    txt_age.Focus();
                }
                else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    lbl_error.Text = "Enter valid Telephone number";
                    txt_tp.Focus();
                }
                else if (txt_email.Text.Length == 0)
                {
                    lbl_error.Text = "Please Enter Email Address";
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_error.Text = "Enter a valid email. Ex:name@gmail.com";
                    txt_email.Focus();
                }
                else if (txt_pw.Text.Length == 0)
                {
                    lbl_error.Text = "Please Enter your Password";
                    txt_pw.Focus();
                }
                else if (txt_cpw.Text.Length == 0)
                {
                    lbl_error.Text = "Please Enter your Confirm Password";
                    txt_cpw.Focus();
                }
                else if (txt_pw.Text != txt_cpw.Text)
                {
                    lbl_error.Text = "Confirm Password must be same as the Password";
                    txt_cpw.Focus();
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //Open the Pipeline
                    cmd = new SqlCommand("Insert into Registration Values ('" + txt_fname.Text + "','" + txt_lname.Text + "','" + dateTimePicker_dob.Value + "','" + txt_age.Text + "','" + txt_address.Text + "','" + txt_tp.Text + "','" + txt_email.Text + "','" + dateTimePicker_dob.Value + "','" + txt_pw.Text + "','" + txt_cpw.Text + "')", con);
                    int i = cmd.ExecuteNonQuery(); //execute the pipielne
                    if (i == 1)
                    {
                        String from, pass, messageBody;
                        MailMessage message = new MailMessage();
                        to = (txt_email.Text).ToString();
                        from = "fitnessarenasup@gmail.com";
                        pass = "sjqjgypaimirnchz";
                        messageBody = "Dear " + txt_fname.Text + ",\n\nThank you for joining our team.\nWe are thrilled to have you on board and look forward to creating a strong and mutually rewarding experience together.\n\n\t\t\tNOTHING IS IMPOSSIBLE\n\n\n24/7 support contact us \nfitnessarenasup@gmail.com";
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Welcome to Fitness Arena";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        try
                        {
                            smtp.Send(message);
                            MessageBox.Show("Data save successfully Check your Mail", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        } //close the pipeline
                        clear();
                        GetCustomerId();
                    }
                    else
                    {
                        MessageBox.Show("Data cannot save Please enter again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please check your input format", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("You Exceed the input limit,Out of Memory", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_dob_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dateTimePicker_dob.Value.Year).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GetCustomerId();
            txt_id.Enabled = false;
            txt_age.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void member_registration_Load(object sender, EventArgs e)
        {

        }
    }
}
