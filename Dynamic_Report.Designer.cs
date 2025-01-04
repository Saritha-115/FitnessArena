namespace FitnessArena
{
    partial class Dynamic_Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_member = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_jdate = new System.Windows.Forms.DateTimePicker();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dynamicDataSet = new FitnessArena.DynamicDataSet();
            this.registrationTableAdapter = new FitnessArena.DynamicDataSetTableAdapters.RegistrationTableAdapter();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.registrationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FitnessArena.DynamicWizard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 93);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(889, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(94, 59);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(76, 20);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_member
            // 
            this.lbl_member.AutoSize = true;
            this.lbl_member.Location = new System.Drawing.Point(27, 63);
            this.lbl_member.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_member.Name = "lbl_member";
            this.lbl_member.Size = new System.Drawing.Size(59, 13);
            this.lbl_member.TabIndex = 3;
            this.lbl_member.Text = "Member ID";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(199, 62);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(86, 13);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Member Address";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(552, 60);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 19);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_jdate
            // 
            this.dtp_jdate.Location = new System.Drawing.Point(317, 60);
            this.dtp_jdate.Name = "dtp_jdate";
            this.dtp_jdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_jdate.TabIndex = 6;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.dynamicDataSet;
            // 
            // dynamicDataSet
            // 
            this.dynamicDataSet.DataSetName = "DynamicDataSet";
            this.dynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(627, 59);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 19);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Dynamic_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dtp_jdate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_member);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dynamic_Report";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Dynamic_Report";
            this.Load += new System.EventHandler(this.Dynamic_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_member;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private DynamicDataSet dynamicDataSet;
        private DynamicDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.DateTimePicker dtp_jdate;
        private System.Windows.Forms.Button btn_clear;
    }
}