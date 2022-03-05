
namespace SVSU_Capstone_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.msiViewInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.msiGenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPrintBarcodes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCheckInOutItems = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSimulatorUse = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblLoggedInTime = new System.Windows.Forms.Label();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiViewInventory,
            this.msiManageInventory,
            this.msiGenerateReports,
            this.msiPrintBarcodes,
            this.msiCheckInOutItems,
            this.msiSimulatorUse,
            this.msiSettings});
            this.mstMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mstMain.Size = new System.Drawing.Size(179, 242);
            this.mstMain.TabIndex = 0;
            this.mstMain.Text = "menuStrip1";
            // 
            // msiViewInventory
            // 
            this.msiViewInventory.Name = "msiViewInventory";
            this.msiViewInventory.Padding = new System.Windows.Forms.Padding(4);
            this.msiViewInventory.Size = new System.Drawing.Size(174, 31);
            this.msiViewInventory.Text = "View Inventory";
            this.msiViewInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiViewInventory.Click += new System.EventHandler(this.PageController);
            // 
            // msiManageInventory
            // 
            this.msiManageInventory.Name = "msiManageInventory";
            this.msiManageInventory.Padding = new System.Windows.Forms.Padding(4);
            this.msiManageInventory.Size = new System.Drawing.Size(174, 31);
            this.msiManageInventory.Text = "Manage Inventory";
            this.msiManageInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiManageInventory.Click += new System.EventHandler(this.PageController);
            // 
            // msiGenerateReports
            // 
            this.msiGenerateReports.Name = "msiGenerateReports";
            this.msiGenerateReports.Padding = new System.Windows.Forms.Padding(4);
            this.msiGenerateReports.Size = new System.Drawing.Size(174, 31);
            this.msiGenerateReports.Text = "Generate Reports";
            this.msiGenerateReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiGenerateReports.Click += new System.EventHandler(this.PageController);
            // 
            // msiPrintBarcodes
            // 
            this.msiPrintBarcodes.Name = "msiPrintBarcodes";
            this.msiPrintBarcodes.Padding = new System.Windows.Forms.Padding(4);
            this.msiPrintBarcodes.Size = new System.Drawing.Size(174, 31);
            this.msiPrintBarcodes.Text = "Print Barcodes";
            this.msiPrintBarcodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiPrintBarcodes.Click += new System.EventHandler(this.PageController);
            // 
            // msiCheckInOutItems
            // 
            this.msiCheckInOutItems.Name = "msiCheckInOutItems";
            this.msiCheckInOutItems.Padding = new System.Windows.Forms.Padding(4);
            this.msiCheckInOutItems.Size = new System.Drawing.Size(174, 31);
            this.msiCheckInOutItems.Text = "Check-In/Out Items";
            this.msiCheckInOutItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiCheckInOutItems.Click += new System.EventHandler(this.PageController);
            // 
            // msiSimulatorUse
            // 
            this.msiSimulatorUse.Name = "msiSimulatorUse";
            this.msiSimulatorUse.Padding = new System.Windows.Forms.Padding(4);
            this.msiSimulatorUse.Size = new System.Drawing.Size(174, 31);
            this.msiSimulatorUse.Text = "Simulator Use";
            this.msiSimulatorUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiSimulatorUse.Click += new System.EventHandler(this.PageController);
            // 
            // msiSettings
            // 
            this.msiSettings.Name = "msiSettings";
            this.msiSettings.Padding = new System.Windows.Forms.Padding(4);
            this.msiSettings.Size = new System.Drawing.Size(174, 31);
            this.msiSettings.Text = "Settings";
            this.msiSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiSettings.Click += new System.EventHandler(this.PageController);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(863, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 24);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "lblUser";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(862, 107);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(73, 24);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "lblTime";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblLoggedInTime
            // 
            this.lblLoggedInTime.AutoSize = true;
            this.lblLoggedInTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLoggedInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInTime.Location = new System.Drawing.Point(863, 33);
            this.lblLoggedInTime.Name = "lblLoggedInTime";
            this.lblLoggedInTime.Size = new System.Drawing.Size(50, 18);
            this.lblLoggedInTime.TabIndex = 5;
            this.lblLoggedInTime.Text = "label1";
            // 
            // pcbMain
            // 
            this.pcbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbMain.Image = global::SVSU_Capstone_Project.Properties.Resources.svsu_top_bar;
            this.pcbMain.Location = new System.Drawing.Point(0, 0);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(1156, 187);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMain.TabIndex = 1;
            this.pcbMain.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mstMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 494);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1068, 145);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 32);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 681);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLoggedInTime);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pcbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mstMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1172, 718);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saginaw Valley Nursing Inventory System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem msiViewInventory;
        private System.Windows.Forms.ToolStripMenuItem msiManageInventory;
        private System.Windows.Forms.ToolStripMenuItem msiGenerateReports;
        private System.Windows.Forms.ToolStripMenuItem msiSettings;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblLoggedInTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem msiPrintBarcodes;
        private System.Windows.Forms.ToolStripMenuItem msiCheckInOutItems;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem msiSimulatorUse;
    }
}

