using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessArena
{
    public partial class admin_add_schedule_panel : Form
    {
        public admin_add_schedule_panel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        public void clear()
        {
            txt_schedule_id.Clear();
            txt_user_id.Clear();
            dateTimePicker_end.Refresh();
            dateTimePicker_start.Refresh();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            GetCustomerId();
            clear();
        }
        public void GetCustomerId()
        {

            string custid;
            string custdetails = "select Sch_id from Schedule order by Sch_id Desc";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
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
            txt_schedule_id.Text = custid.ToString();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_schedule_id.Text.Length == 0)
                {
                    MessageBox.Show("Schedule ID is Empty, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_schedule_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Schedule did not accept any letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_user_id.Text.Length == 0 || txt_user_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("User ID is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("Insert into Schedule values ('" + Convert.ToInt32(txt_user_id.Text) + "', '" + dateTimePicker_start.Value + "', '" + dateTimePicker_end.Value + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        GetCustomerId();
                        populate();
                        MessageBox.Show("Data Succesfully Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not succesfully Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please check values in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_schedule_id.Text.Length == 0)
                {
                    MessageBox.Show("Schedule ID is Empty, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_schedule_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Schedule did not did no accept any Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_user_id.Text.Length == 0 || txt_user_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("User ID is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("Update Schedule set  Client_iD = '" + Convert.ToInt32(txt_user_id.Text) + "', Start_d = '" + dateTimePicker_start.Value + "', End_d=  '" + dateTimePicker_end.Value + "' where Sch_id = '" + Convert.ToInt32(txt_schedule_id.Text) + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        GetCustomerId();
                        populate();
                        MessageBox.Show("Data Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data did not Updated Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Check the farmat that you enterd!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_schedule_id.Text.Length == 0 || txt_schedule_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Schedule ID is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("delete from Schedule where Sch_ID ='" + txt_schedule_id.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        GetCustomerId();
                        populate();
                        MessageBox.Show("Data Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data did not Delete Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check values in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void admin_add_schedule_panel_Load(object sender, EventArgs e)
        {
            GetCustomerId();
            populate();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_schedule_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_user_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker_start.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker_end.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
