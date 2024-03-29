﻿
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invDbDataSet1 = new SVSU_Capstone_Project.InvDbDataSet();
            this.simulatorUseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LowStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dynamicItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGenorateReports = new System.Windows.Forms.Label();
            this.tbcReports = new System.Windows.Forms.TabControl();
            this.tabActivityLog = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabSimulatorUse = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabLowStock = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabDynamicItems = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.logsTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.LogsTableAdapter();
            this.simulatorUseTableAdapter1 = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.SimulatorUseTableAdapter();
            this.lowStockTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.LowStockTableAdapter();
            this.cabinetsTableAdapter1 = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.CabinetsTableAdapter();
            this.dynamicItemsTableAdapter = new SVSU_Capstone_Project.InvDbDataSetTableAdapters.DynamicItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulatorUseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicItemsBindingSource)).BeginInit();
            this.tbcReports.SuspendLayout();
            this.tabActivityLog.SuspendLayout();
            this.tabSimulatorUse.SuspendLayout();
            this.tabLowStock.SuspendLayout();
            this.tabDynamicItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.invDbDataSet1;
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
            // LowStockBindingSource
            // 
            this.LowStockBindingSource.DataMember = "LowStock";
            this.LowStockBindingSource.DataSource = this.invDbDataSet1;
            // 
            // dynamicItemsBindingSource
            // 
            this.dynamicItemsBindingSource.DataMember = "DynamicItemsTable";
            this.dynamicItemsBindingSource.DataSource = this.invDbDataSet1;
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
            // tbcReports
            // 
            this.tbcReports.Controls.Add(this.tabActivityLog);
            this.tbcReports.Controls.Add(this.tabSimulatorUse);
            this.tbcReports.Controls.Add(this.tabLowStock);
            this.tbcReports.Controls.Add(this.tabDynamicItems);
            this.tbcReports.Location = new System.Drawing.Point(3, 59);
            this.tbcReports.Name = "tbcReports";
            this.tbcReports.SelectedIndex = 0;
            this.tbcReports.Size = new System.Drawing.Size(1515, 819);
            this.tbcReports.TabIndex = 6;
            this.tbcReports.SelectedIndexChanged += new System.EventHandler(this.tbcReports_SelectedIndexChanged);
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
            reportDataSource1.Name = "ActivityLog";
            reportDataSource1.Value = this.logsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SVSU_Capstone_Project.Reports.ActivityLog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(1501, 504);
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
            this.reportViewer2.ShowZoomControl = false;
            this.reportViewer2.Size = new System.Drawing.Size(1504, 483);
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
            this.reportViewer3.ShowZoomControl = false;
            this.reportViewer3.Size = new System.Drawing.Size(1501, 784);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabDynamicItems
            // 
            this.tabDynamicItems.Controls.Add(this.reportViewer4);
            this.tabDynamicItems.Location = new System.Drawing.Point(4, 25);
            this.tabDynamicItems.Name = "tabDynamicItems";
            this.tabDynamicItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabDynamicItems.Size = new System.Drawing.Size(1507, 790);
            this.tabDynamicItems.TabIndex = 3;
            this.tabDynamicItems.Text = "Dynamic Items";
            this.tabDynamicItems.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DynamicItems";
            reportDataSource4.Value = this.dynamicItemsBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "SVSU_Capstone_Project.Reports.DynamicItems.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.ShowZoomControl = false;
            this.reportViewer4.Size = new System.Drawing.Size(1501, 645);
            this.reportViewer4.TabIndex = 0;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // simulatorUseTableAdapter1
            // 
            this.simulatorUseTableAdapter1.ClearBeforeFill = true;
            // 
            // lowStockTableAdapter
            // 
            this.lowStockTableAdapter.ClearBeforeFill = true;
            // 
            // cabinetsTableAdapter1
            // 
            this.cabinetsTableAdapter1.ClearBeforeFill = true;
            // 
            // dynamicItemsTableAdapter
            // 
            this.dynamicItemsTableAdapter.ClearBeforeFill = true;
            // 
            // frmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 896);
            this.Controls.Add(this.tbcReports);
            this.Controls.Add(this.lblGenorateReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGenerateReports";
            this.Text = "frmGenerateReports";
            this.Load += new System.EventHandler(this.frmGenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulatorUseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicItemsBindingSource)).EndInit();
            this.tbcReports.ResumeLayout(false);
            this.tabActivityLog.ResumeLayout(false);
            this.tabSimulatorUse.ResumeLayout(false);
            this.tabLowStock.ResumeLayout(false);
            this.tabDynamicItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenorateReports;
        private InvDbDataSet invDbDataSet1;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private InvDbDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.TabControl tbcReports;
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
        private System.Windows.Forms.TabPage tabDynamicItems;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource dynamicItemsBindingSource;
        private InvDbDataSetTableAdapters.DynamicItemsTableAdapter dynamicItemsTableAdapter;
    }
}
