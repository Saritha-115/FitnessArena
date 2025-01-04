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
    public partial class member_schedule_info_panel : Form
    {
        public member_schedule_info_panel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            populate();
        }
        public void clear()
        {
            txt_user_id.Clear();
            txt_schedule_id.Clear();
        }
        public void populate()
        {
            con.Open();
            da = new SqlDataAdapter("select * from Schedule", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void member_schedule_info_panel_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_schedule_id.Text == "" && txt_user_id.Text == "")
            {
                MessageBox.Show("Enter details before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt = new DataTable();
                if (txt_schedule_id.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Schedule where Sch_id like '%" + txt_schedule_id.Text + "%'", con);
                    da.Fill(dt);
                }
                if (txt_user_id.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Schedule where Client_iD like '%" + txt_user_id.Text + "%'", con);
                    da.Fill(dt);
                }
                dataGridView1.DataSource = dt;
            }
        }
    }
}
