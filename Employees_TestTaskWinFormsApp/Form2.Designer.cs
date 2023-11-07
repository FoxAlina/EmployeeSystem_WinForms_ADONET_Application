
namespace Employees_TestTaskWinFormsApp
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AverageSalaryInPositionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesDataSet = new Employees_TestTaskWinFormsApp.EmployeesDataSet();
            this.EmployeeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AverageSalaryInPositionInfoTableAdapter = new Employees_TestTaskWinFormsApp.EmployeesDataSetTableAdapters.AverageSalaryInPositionInfoTableAdapter();
            this.EmployeeInfoTableAdapter = new Employees_TestTaskWinFormsApp.EmployeesDataSetTableAdapters.EmployeeInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AverageSalaryInPositionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AverageSalaryInPositionInfoBindingSource
            // 
            this.AverageSalaryInPositionInfoBindingSource.DataMember = "AverageSalaryInPositionInfo";
            this.AverageSalaryInPositionInfoBindingSource.DataSource = this.EmployeesDataSet;
            // 
            // EmployeesDataSet
            // 
            this.EmployeesDataSet.DataSetName = "EmployeesDataSet";
            this.EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeInfoBindingSource
            // 
            this.EmployeeInfoBindingSource.DataMember = "EmployeeInfo";
            this.EmployeeInfoBindingSource.DataSource = this.EmployeesDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AverageSalaryInPositionInfoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmployeeInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Employees_TestTaskWinFormsApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AverageSalaryInPositionInfoTableAdapter
            // 
            this.AverageSalaryInPositionInfoTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeInfoTableAdapter
            // 
            this.EmployeeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Отчёт о средней зарплате по должности";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AverageSalaryInPositionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AverageSalaryInPositionInfoBindingSource;
        private EmployeesDataSet EmployeesDataSet;
        private EmployeesDataSetTableAdapters.AverageSalaryInPositionInfoTableAdapter AverageSalaryInPositionInfoTableAdapter;
        private System.Windows.Forms.BindingSource EmployeeInfoBindingSource;
        private EmployeesDataSetTableAdapters.EmployeeInfoTableAdapter EmployeeInfoTableAdapter;
    }
}