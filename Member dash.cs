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
    public partial class Member_dash : MetroFramework.Forms.MetroForm
    {
        public Member_dash()
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
        
        private void btn_user_info_Click(object sender, EventArgs e)
        {
            showForm(new member_user_info_panel());
            btn_user_info.BackColor = Color.FromArgb(144, 200, 69);
            btn_schedule.BackColor = Color.FromArgb(58, 226, 203);
           
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            showForm(new member_schedule_info_panel());
            btn_schedule.BackColor = Color.FromArgb(144, 200, 69);
            btn_user_info.BackColor = Color.FromArgb(58, 226, 203);
        }
        public void read()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Registration where Client_id = '" + UserVerify.userId + "'", con);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

                dt.Load(dr);
                DataRow userRow = dt.Rows[0];
                UserVerify.username = userRow["First_name"].ToString();
           
            con.Close();
        }
        private void Member_dash_Load(object sender, EventArgs e)
        {
            read();
            lbl_name.Text = UserVerify.username; 
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
            Member_dash admin_Dash = new Member_dash();
            admin_Dash.Close();
            splash splash = new splash();
            splash.Close();
            this.Close();
        }
    }
}
