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
    public partial class admin_user_info_panel1 : Form
    {
        public admin_user_info_panel1()
        {
            InitializeComponent();
        }
        public static String to;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        private void lbl_error_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_age.Clear();
            txt_address.Clear();
            txt_tp.Clear();
            txt_email.Clear();
        }
        public void populate()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            da = new SqlDataAdapter("select * from Registration", con);
            dt = new DataTable();
            da.Fill(dt);
            //dgv_update.DataSource = dt;
            con.Close();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    lbl_error.Text = "Member ID Cannot be Empty";
                    txt_id.Clear();
                    txt_id.Focus();
                }

                else if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    lbl_error.Text = "First Name Cannot be Empty";
                    txt_fname.Clear();
                    txt_fname.Focus();
                }
                else if (txt_fname.Text.Any(Char.IsDigit))
                {
                    lbl_error.Text = "First Name Cannot Have Numbers";
                    txt_fname.Clear();
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    lbl_error.Text = "Last Name Cannot be Empty";
                    txt_lname.Clear();
                    txt_lname.Focus();
                }
                else if (txt_lname.Text.Any(Char.IsDigit))
                {
                    lbl_error.Text = "Last Name Cannot Have Numbers";
                    txt_lname.Clear();
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
                else if (string.IsNullOrEmpty(txt_address.Text))
                {
                    lbl_error.Text = "Address Cannot be Empty";
                    txt_address.Clear();
                    txt_address.Focus();
                }
                else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    lbl_error.Text = "TP must have 10 numbers";
                    txt_tp.Clear();
                    txt_tp.Focus();
                }
                else if (txt_email.Text.Length == 0)
                {
                    lbl_error.Text = "Please Enter Email Address";
                    txt_email.Clear();
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_error.Text = "Enter a valid email. Ex:name@gmail.com";
                    txt_email.Clear();
                    txt_email.Focus();
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("update Admin_tbl set First_name= '" + txt_fname.Text + "',Last_name='" + txt_lname.Text + "',Age = '" + Convert.ToInt32(txt_age.Text) + "',Client_add='" + txt_address.Text + "',Telephone='" + Convert.ToInt32(txt_tp.Text) + "',Email='" + txt_email.Text + "' where Client_id = '" + Convert.ToInt32(txt_id.Text) + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    cmd.Dispose();
                    populate();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Please Enter Correct Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void read()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Admin_tbl where Client_id = '" + UserVerify.userId + "'", con);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);
            DataRow userRow = dt.Rows[0];
            txt_id.Text = userRow["Client_id"].ToString();
            txt_fname.Text = userRow["First_name"].ToString();
            txt_lname.Text = userRow["Last_name"].ToString();
            txt_age.Text = userRow["Age"].ToString();
            txt_tp.Text = userRow["Telephone"].ToString();
            txt_email.Text = userRow["Email"].ToString();
            txt_address.Text = userRow["Client_add"].ToString();
            dateTimePicker_dob.Value = (DateTime)userRow["Date_joined"];

            con.Close();
        }
        private void admin_user_info_panel1_Load(object sender, EventArgs e)
        {
            read();
            txt_age.Enabled = false;
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
