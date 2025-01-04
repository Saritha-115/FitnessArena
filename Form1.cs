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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btn_signin_Click_1(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Name == "Member_log_in")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if(Isopen == false)
            {
                Member_log_in obj = new Member_log_in();
                obj.Show();
            }
        }

        private void lbl_reg_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "member_registration")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                member_registration obj = new member_registration();
                obj.Show();
            }

            
        }

        private void lbl_admin_login_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "admin_log_in")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                admin_log_in obj = new admin_log_in();
                obj.Show();
            }

        }

        private void admin_register_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "admin_registration")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                admin_registration obj = new admin_registration();
                obj.Show();
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            splash splash = new splash();
            splash.Close(); 
        }
    }

}
