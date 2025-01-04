using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessArena
{
    public partial class admin_add_exersice_panel : Form
    {
        public admin_add_exersice_panel()
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
            txt_exercise_id.Clear();
            txt_reps.Clear();
            txt_sets.Clear();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            populate();
            clear();
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
                else if (txt_exercise_id.Text.Length == 0 || txt_exercise_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("User ID is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_reps.Text.Length == 0 || txt_reps.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Reps data is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_sets.Text.Length == 0 || txt_sets.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Sets data is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("Insert into Schedule_Exercise values ('" + Convert.ToInt32(txt_schedule_id.Text) + "','" + Convert.ToInt32(txt_exercise_id.Text) + "', '" + Convert.ToInt32(txt_sets.Text) + "', '" + Convert.ToInt32(txt_reps.Text) + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
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
                    MessageBox.Show("Schedule did not accept any letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_exercise_id.Text.Length == 0 || txt_exercise_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("User ID is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_reps.Text.Length == 0 || txt_reps.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Reps data is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_sets.Text.Length == 0 || txt_sets.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Sets data is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("Update Schedule_Exercise set Sets_e= '" + Convert.ToInt32(txt_sets.Text) + "', Reps =  '" + Convert.ToInt32(txt_reps.Text) + "' where Sch_id = '" + Convert.ToInt32(txt_schedule_id.Text) + "' and Exercises_ID = '" + Convert.ToInt32(txt_exercise_id.Text) + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
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
                MessageBox.Show("Please check values in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
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
                else if (txt_exercise_id.Text.Length == 0 || txt_exercise_id.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("User ID is Empty or cannot contain any letters, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("delete from Schedule_Exercise where  Sch_id = '" +Convert.ToInt32(txt_schedule_id.Text) + "' and Exercises_ID = '" + Convert.ToInt32(txt_exercise_id.Text) + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        populate();
                        MessageBox.Show("Data Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data did not Deleted Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            da = new SqlDataAdapter("select * from Schedule_Exercise", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void admin_add_exersice_panel_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_schedule_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_exercise_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sets.Text = dataGridView1.Rows[e.RowIndex ].Cells[2].Value.ToString();
            txt_reps.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
