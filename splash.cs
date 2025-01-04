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
    public partial class splash : MetroFramework.Forms.MetroForm
    {
        public splash()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(metroProgressBar1.Value<100)
            {
                metroProgressBar1.Value += 1;
                lbl_value.Text = metroProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Main obj = new Main();
                obj.Show();
                this.Hide();
            }

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
