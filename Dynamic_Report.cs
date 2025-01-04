using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessArena
{
    public partial class Dynamic_Report : Form
    {
        public Dynamic_Report()
        {
            InitializeComponent();
        }

        private void Dynamic_Report_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                txt_id.Text = "5000";
                // TODO: This line of code loads data into the 'dynamicDataSet.Registration' table. You can move, or remove it, as needed.
                this.registrationTableAdapter.Fill(this.dynamicDataSet.Registration, Convert.ToInt32(txt_id.Text), Convert.ToString(dtp_jdate.Value));
                this.reportViewer1.RefreshReport();
            }
            else if (txt_id.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Cannot enter letters to ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // TODO: This line of code loads data into the 'dynamicDataSet.Registration' table. You can move, or remove it, as needed.
                this.registrationTableAdapter.Fill(this.dynamicDataSet.Registration, Convert.ToInt32(txt_id.Text), Convert.ToString(dtp_jdate.Value));
                this.reportViewer1.RefreshReport();
            }

            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            dtp_jdate.Refresh();
        }
    }
}
