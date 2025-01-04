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

namespace FitnessArena
{
    public partial class Member_log_in : MetroFramework.Forms.MetroForm
    {
        public Member_log_in()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void lbl_fgt_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Forgot_pw")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Forgot_pw obj = new Forgot_pw();
                obj.Show();
            }

            
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                string login = "select * from Registration where Client_id='" + txt_id.Text + "'and Client_password='" + txt_pw.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    UserVerify.userId = Convert.ToInt32(txt_id.Text);
                    Member_dash Dashboard = new Member_dash();
                    Dashboard.Show();
                    Main main = new Main();
                    main.Close();
                    splash splash = new splash();
                    splash.Close();
                    this.Hide();
                }
                else if (txt_id.Text == "" || txt_pw.Text == "")
                {
                    lbl_error.Text = "Cannot login with empty fields";
                    txt_id.Focus();
                }
                else
                {

                    lbl_error.Text = "invalid username or password, Please Try Again";
                    txt_id.Text = "";
                    txt_pw.Text = "";
                    txt_id.Focus();
                }
                con.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Check Your input formats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("You Exceeded the input limits , Out of Memory ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pw.PasswordChar = '\0';
            }
            else
            {
                txt_pw.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
