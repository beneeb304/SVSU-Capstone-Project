
namespace SVSU_Capstone_Project.Views
{
    partial class frmGenerateReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invDbDataSet1 = new SVSU_Capstone_Project.InvDbDataSet();
            this.lblGenorateReports = new System.Windows.Forms.Label();
            this.logsTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.LogsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActivityLog = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SimulatorUse = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.simulatorUseTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.SimulatorUseTableAdapter();
            this.simulatorUseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ActivityLog.SuspendLayout();
            this.SimulatorUse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulatorUseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.invDbDataSet1;
            this.logsBindingSource.CurrentChanged += new System.EventHandler(this.logsBindingSource_CurrentChanged);
            // 
            // invDbDataSet1
            // 
            this.invDbDataSet1.DataSetName = "InvDbDataSet";
            this.invDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGenorateReports
            // 
            this.lblGenorateReports.AutoSize = true;
            this.lblGenorateReports.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenorateReports.Location = new System.Drawing.Point(16, 11);
            this.lblGenorateReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenorateReports.Name = "lblGenorateReports";
            this.lblGenorateReports.Size = new System.Drawing.Size(213, 29);
            this.lblGenorateReports.TabIndex = 4;
            this.lblGenorateReports.Text = "Generate Reports";
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActivityLog);
            this.tabControl1.Controls.Add(this.SimulatorUse);
            this.tabControl1.Location = new System.Drawing.Point(3, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1515, 819);
            this.tabControl1.TabIndex = 6;
            // 
            // ActivityLog
            // 
            this.ActivityLog.Controls.Add(this.reportViewer1);
            this.ActivityLog.Location = new System.Drawing.Point(4, 25);
            this.ActivityLog.Name = "ActivityLog";
            this.ActivityLog.Padding = new System.Windows.Forms.Padding(3);
            this.ActivityLog.Size = new System.Drawing.Size(1507, 790);
            this.ActivityLog.TabIndex = 0;
            this.ActivityLog.Text = "Activity Log";
            this.ActivityLog.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ActivityLog";
            reportDataSource1.Value = this.logsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SVSU_Capstone_Project.Reports.ActivityLog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1501, 784);
            this.reportViewer1.TabIndex = 0;
            // 
            // SimulatorUse
            // 
            this.SimulatorUse.Controls.Add(this.reportViewer2);
            this.SimulatorUse.Location = new System.Drawing.Point(4, 25);
            this.SimulatorUse.Name = "SimulatorUse";
            this.SimulatorUse.Padding = new System.Windows.Forms.Padding(3);
            this.SimulatorUse.Size = new System.Drawing.Size(1507, 790);
            this.SimulatorUse.TabIndex = 1;
            this.SimulatorUse.Text = "Simulator Use";
            this.SimulatorUse.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SVSU_Capstone_Project.Reports.SimulatorUse.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1501, 784);
            this.reportViewer2.TabIndex = 0;
            // 
            // simulatorUseTableAdapter
            // 
            this.simulatorUseTableAdapter.ClearBeforeFill = true;
            // 
            // simulatorUseBindingSource
            // 
            this.simulatorUseBindingSource.DataMember = "SimulatorUse";
            this.simulatorUseBindingSource.DataSource = this.invDbDataSet1;
            this.simulatorUseBindingSource.CurrentChanged += new System.EventHandler(this.simulatorUseBindingSource_CurrentChanged);
            // 
            // frmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 896);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGenorateReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGenerateReports";
            this.Text = "frmGenerateReports";
            this.Load += new System.EventHandler(this.frmGenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ActivityLog.ResumeLayout(false);
            this.SimulatorUse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simulatorUseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenorateReports;
        private InvDbDataSet invDbDataSet1;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private InvDbDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActivityLog;
        private System.Windows.Forms.TabPage SimulatorUse;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InvDbDataSetTableAdapters.SimulatorUseTableAdapter simulatorUseTableAdapter;
        private System.Windows.Forms.BindingSource simulatorUseBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}
