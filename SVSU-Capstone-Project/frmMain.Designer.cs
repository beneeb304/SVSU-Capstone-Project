
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
            this.msiAddItems = new System.Windows.Forms.ToolStripMenuItem();
            this.msiConsumeItems = new System.Windows.Forms.ToolStripMenuItem();
            this.msiGenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblLoggedInTime = new System.Windows.Forms.Label();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.mstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiViewInventory,
            this.msiAddItems,
            this.msiConsumeItems,
            this.msiGenerateReports,
            this.msiSettings});
            this.mstMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mstMain.Location = new System.Drawing.Point(0, 187);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(115, 101);
            this.mstMain.TabIndex = 0;
            this.mstMain.Text = "menuStrip1";
            // 
            // msiViewInventory
            // 
            this.msiViewInventory.Name = "msiViewInventory";
            this.msiViewInventory.Size = new System.Drawing.Size(108, 19);
            this.msiViewInventory.Text = "View Inventory";
            this.msiViewInventory.Click += new System.EventHandler(this.PageController);
            // 
            // msiAddItems
            // 
            this.msiAddItems.Name = "msiAddItems";
            this.msiAddItems.Size = new System.Drawing.Size(108, 19);
            this.msiAddItems.Text = "Add Items";
            this.msiAddItems.Click += new System.EventHandler(this.PageController);
            // 
            // msiConsumeItems
            // 
            this.msiConsumeItems.Name = "msiConsumeItems";
            this.msiConsumeItems.Size = new System.Drawing.Size(108, 19);
            this.msiConsumeItems.Text = "Consume Items";
            this.msiConsumeItems.Click += new System.EventHandler(this.PageController);
            // 
            // msiGenerateReports
            // 
            this.msiGenerateReports.Name = "msiGenerateReports";
            this.msiGenerateReports.Size = new System.Drawing.Size(108, 19);
            this.msiGenerateReports.Text = "Generate Reports";
            this.msiGenerateReports.Click += new System.EventHandler(this.PageController);
            // 
            // msiSettings
            // 
            this.msiSettings.Name = "msiSettings";
            this.msiSettings.Size = new System.Drawing.Size(108, 19);
            this.msiSettings.Text = "Settings";
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
            this.lblDateTime.Location = new System.Drawing.Point(863, 116);
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
            this.pcbMain.Image = global::SVSU_Capstone_Project.Properties.Resources.svsu_top_bar;
            this.pcbMain.Location = new System.Drawing.Point(1, 0);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(856, 184);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMain.TabIndex = 1;
            this.pcbMain.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblLoggedInTime);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pcbMain);
            this.Controls.Add(this.mstMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem msiAddItems;
        private System.Windows.Forms.ToolStripMenuItem msiViewInventory;
        private System.Windows.Forms.ToolStripMenuItem msiConsumeItems;
        private System.Windows.Forms.ToolStripMenuItem msiGenerateReports;
        private System.Windows.Forms.ToolStripMenuItem msiSettings;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblLoggedInTime;
    }
}

