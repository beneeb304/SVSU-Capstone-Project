
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblGenorateReports = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabActivityLog = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabSimulatorUse = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabLowStock = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invDbDataSet1 = new SVSU_Capstone_Project.InvDbDataSet();
            this.simulatorUseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.LogsTableAdapter();
            this.simulatorUseTableAdapter1 = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.SimulatorUseTableAdapter();
            this.LowStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lowStockTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.LowStockTableAdapter();
            this.cabinetsTableAdapter1 = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.CabinetsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabActivityLog.SuspendLayout();
            this.tabSimulatorUse.SuspendLayout();
            this.tabLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulatorUseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenorateReports
            // 
            this.lblGenorateReports.AutoSize = true;
            this.lblGenorateReports.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenorateReports.Location = new System.Drawing.Point(16, 11);
            this.lblGenorateReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenorateReports.Name = "lblGenorateReports";
            this.lblGenorateReports.Size = new System.Drawing.Size(103, 29);
            this.lblGenorateReports.TabIndex = 4;
            this.lblGenorateReports.Text = "Reports";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabActivityLog);
            this.tabControl1.Controls.Add(this.tabSimulatorUse);
            this.tabControl1.Controls.Add(this.tabLowStock);
            this.tabControl1.Location = new System.Drawing.Point(3, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1515, 819);
            this.tabControl1.TabIndex = 6;
            // 
            // tabActivityLog
            // 
            this.tabActivityLog.Controls.Add(this.reportViewer1);
            this.tabActivityLog.Location = new System.Drawing.Point(4, 25);
            this.tabActivityLog.Name = "tabActivityLog";
            this.tabActivityLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivityLog.Size = new System.Drawing.Size(1507, 790);
            this.tabActivityLog.TabIndex = 0;
            this.tabActivityLog.Text = "Activity Log";
            this.tabActivityLog.UseVisualStyleBackColor = true;
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
            // tabSimulatorUse
            // 
            this.tabSimulatorUse.Controls.Add(this.reportViewer2);
            this.tabSimulatorUse.Location = new System.Drawing.Point(4, 25);
            this.tabSimulatorUse.Name = "tabSimulatorUse";
            this.tabSimulatorUse.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulatorUse.Size = new System.Drawing.Size(1507, 790);
            this.tabSimulatorUse.TabIndex = 1;
            this.tabSimulatorUse.Text = "Simulator Use";
            this.tabSimulatorUse.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "SimulatorUse";
            reportDataSource2.Value = this.simulatorUseBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SVSU_Capstone_Project.Reports.SimulatorUses.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1504, 784);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabLowStock
            // 
            this.tabLowStock.Controls.Add(this.reportViewer3);
            this.tabLowStock.Location = new System.Drawing.Point(4, 25);
            this.tabLowStock.Name = "tabLowStock";
            this.tabLowStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabLowStock.Size = new System.Drawing.Size(1507, 790);
            this.tabLowStock.TabIndex = 2;
            this.tabLowStock.Text = "Low Stock";
            this.tabLowStock.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "LowStock";
            reportDataSource3.Value = this.LowStockBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "SVSU_Capstone_Project.Reports.LowStock.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1501, 784);
            this.reportViewer3.TabIndex = 0;
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
            // simulatorUseBindingSource
            // 
            this.simulatorUseBindingSource.DataMember = "SimulatorUse";
            this.simulatorUseBindingSource.DataSource = this.invDbDataSet1;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // simulatorUseTableAdapter1
            // 
            this.simulatorUseTableAdapter1.ClearBeforeFill = true;
            // 
            // LowStockBindingSource
            // 
            this.LowStockBindingSource.DataMember = "LowStock";
            this.LowStockBindingSource.DataSource = this.invDbDataSet1;
            // 
            // lowStockTableAdapter
            // 
            this.lowStockTableAdapter.ClearBeforeFill = true;
            // 
            // cabinetsTableAdapter1
            // 
            this.cabinetsTableAdapter1.ClearBeforeFill = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabActivityLog.ResumeLayout(false);
            this.tabSimulatorUse.ResumeLayout(false);
            this.tabLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulatorUseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowStockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenorateReports;
        private InvDbDataSet invDbDataSet1;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private InvDbDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabActivityLog;
        private System.Windows.Forms.TabPage tabSimulatorUse;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private InvDbDataSetTableAdapters.SimulatorUseTableAdapter simulatorUseTableAdapter1;
        private System.Windows.Forms.BindingSource simulatorUseBindingSource;
        private System.Windows.Forms.TabPage tabLowStock;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource LowStockBindingSource;
        private InvDbDataSetTableAdapters.LowStockTableAdapter lowStockTableAdapter;
        private InvDbDataSetTableAdapters.CabinetsTableAdapter cabinetsTableAdapter1;
    }
}
