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
    public partial class Admin_dash : MetroFramework.Forms.MetroForm
    {
        public Admin_dash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt;
        public void showForm(Object form)
        {
            panel2.Show();
            panel2.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            panel2.Tag = frm;
            frm.Show();
        }
        private void Admin_dash_Load(object sender, EventArgs e)
        {
            showForm(new admin_user_info_panel1());
        }
        private void btn_user_info_Click(object sender, EventArgs e)
        {
            showForm(new admin_user_info_panel1());
            btn_user_info.BackColor = Color.FromArgb(144, 200, 69);
            btn_member_details.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_schedule.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_exercise.BackColor = Color.FromArgb(58, 226, 203);
            btn_report.BackColor = Color.FromArgb(58, 226, 203);
        }
        private void btn_member_details_Click(object sender, EventArgs e)
        {
            showForm(new admin_member_info_panel1());
            btn_member_details.BackColor = Color.FromArgb(144, 200, 69);
            btn_user_info.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_schedule.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_exercise.BackColor = Color.FromArgb(58, 226, 203);
            btn_report.BackColor = Color.FromArgb(58, 226, 203);
        }

        private void btn_add_schedule_Click(object sender, EventArgs e)
        {   
            showForm(new admin_add_schedule_panel());
            btn_add_schedule.BackColor = Color.FromArgb(144, 200, 69);
            btn_user_info.BackColor = Color.FromArgb(58, 226, 203);
            btn_member_details.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_exercise.BackColor = Color.FromArgb(58, 226, 203);
            btn_report.BackColor = Color.FromArgb(58, 226, 203);
        }

        private void btn_add_exersice_Click(object sender, EventArgs e)
        {
            showForm(new admin_add_exersice_panel());
            btn_add_exercise.BackColor = Color.FromArgb(144, 200, 69);
            btn_user_info.BackColor = Color.FromArgb(58, 226, 203);
            btn_member_details.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_schedule.BackColor = Color.FromArgb(58, 226, 203);
            btn_report.BackColor = Color.FromArgb(58, 226, 203);
        }

        public void read()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Admin_tbl where Client_id = '" + UserVerify.userId + "'", con);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);
            DataRow userRow = dt.Rows[0];
            UserVerify.username = userRow["First_name"].ToString();

            con.Close();
        }
        private void Admin_dash_Load_1(object sender, EventArgs e)
        {
            read();
            lbl_name.Text = UserVerify.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
            Admin_dash admin_Dash = new Admin_dash();
            admin_Dash.Close();
            splash splash = new splash();
            splash.Close();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showForm(new Dynamic_Report());
            btn_report.BackColor = Color.FromArgb(144, 200, 69);
            btn_user_info.BackColor = Color.FromArgb(58, 226, 203);
            btn_member_details.BackColor = Color.FromArgb(58, 226, 203);
            btn_add_schedule.BackColor = Color.FromArgb(58, 226, 203);
            btn_report.BackColor = Color.FromArgb(58, 226, 203);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
