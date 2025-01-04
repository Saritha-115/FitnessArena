namespace FitnessArena
{
    partial class Member_dash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_dash));
            this.Home = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_user_info = new System.Windows.Forms.Button();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Home.Controls.Add(this.pictureBox2);
            this.Home.Location = new System.Drawing.Point(-2, 29);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1258, 52);
            this.Home.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1037, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 34);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(249, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 691);
            this.panel2.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_name.Location = new System.Drawing.Point(842, 60);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(110, 20);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "user name here";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(819, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_schedule);
            this.panel1.Controls.Add(this.btn_user_info);
            this.panel1.Location = new System.Drawing.Point(-3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 694);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(52, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "logout";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(226)))), ((int)(((byte)(203)))));
            this.btn_schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_schedule.FlatAppearance.BorderSize = 0;
            this.btn_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule.Image = global::FitnessArena.Properties.Resources.dumbell;
            this.btn_schedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_schedule.Location = new System.Drawing.Point(26, 101);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_schedule.Size = new System.Drawing.Size(211, 52);
            this.btn_schedule.TabIndex = 6;
            this.btn_schedule.Text = " Schedule Information";
            this.btn_schedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_schedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_schedule.UseVisualStyleBackColor = false;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_user_info
            // 
            this.btn_user_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(226)))), ((int)(((byte)(203)))));
            this.btn_user_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_user_info.FlatAppearance.BorderSize = 0;
            this.btn_user_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_info.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_info.Image = global::FitnessArena.Properties.Resources.user1;
            this.btn_user_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_info.Location = new System.Drawing.Point(26, 44);
            this.btn_user_info.Name = "btn_user_info";
            this.btn_user_info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_user_info.Size = new System.Drawing.Size(211, 52);
            this.btn_user_info.TabIndex = 5;
            this.btn_user_info.Text = " User Information";
            this.btn_user_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_user_info.UseVisualStyleBackColor = false;
            this.btn_user_info.Click += new System.EventHandler(this.btn_user_info_Click);
            // 
            // Member_dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Home);
            this.MaximizeBox = false;
            this.Name = "Member_dash";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Member_dash_Load);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_user_info;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}