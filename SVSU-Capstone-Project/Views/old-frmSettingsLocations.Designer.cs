
namespace SVSU_Capstone_Project.Views
{
    partial class frmSettingsLocations
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblLoctions = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSetting_Locations_Title = new System.Windows.Forms.Label();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.lblNLevel = new System.Windows.Forms.Label();
            this.btnAddCabinet = new System.Windows.Forms.Button();
            this.btnDeleteCabinet = new System.Windows.Forms.Button();
            this.btnAddNLevel = new System.Windows.Forms.Button();
            this.btnDeleteNLevel = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lstCabinet = new System.Windows.Forms.ListBox();
            this.lstNLevel = new System.Windows.Forms.ListBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(488, 31);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 26);
            this.lblSearch.TabIndex = 66;
            this.lblSearch.Text = "Search";
            // 
            // lblLoctions
            // 
            this.lblLoctions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoctions.AutoSize = true;
            this.lblLoctions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoctions.Location = new System.Drawing.Point(39, 83);
            this.lblLoctions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoctions.Name = "lblLoctions";
            this.lblLoctions.Size = new System.Drawing.Size(101, 26);
            this.lblLoctions.TabIndex = 63;
            this.lblLoctions.Text = "Locations";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(578, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 31);
            this.txtSearch.TabIndex = 61;
            // 
            // lblSetting_Locations_Title
            // 
            this.lblSetting_Locations_Title.AutoSize = true;
            this.lblSetting_Locations_Title.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblSetting_Locations_Title.Location = new System.Drawing.Point(12, 15);
            this.lblSetting_Locations_Title.Name = "lblSetting_Locations_Title";
            this.lblSetting_Locations_Title.Size = new System.Drawing.Size(332, 46);
            this.lblSetting_Locations_Title.TabIndex = 75;
            this.lblSetting_Locations_Title.Text = "Setting: Locations";
            this.lblSetting_Locations_Title.Click += new System.EventHandler(this.label6_Click);
            // 
            // lstLocations
            // 
            this.lstLocations.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 26;
            this.lstLocations.Items.AddRange(new object[] {
            "HE 111",
            "HE 112",
            "HE 145",
            "HE 267",
            "HE 284"});
            this.lstLocations.Location = new System.Drawing.Point(44, 112);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(241, 342);
            this.lstLocations.TabIndex = 76;
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteLocation.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocation.Location = new System.Drawing.Point(164, 461);
            this.btnDeleteLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(121, 49);
            this.btnDeleteLocation.TabIndex = 81;
            this.btnDeleteLocation.Text = "Delete";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLocation.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Location = new System.Drawing.Point(43, 461);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(121, 49);
            this.btnAddLocation.TabIndex = 80;
            this.btnAddLocation.Text = "Add";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // lblCabinet
            // 
            this.lblCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.Location = new System.Drawing.Point(356, 83);
            this.lblCabinet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(85, 26);
            this.lblCabinet.TabIndex = 64;
            this.lblCabinet.Text = "Cabinet";
            // 
            // lblNLevel
            // 
            this.lblNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNLevel.AutoSize = true;
            this.lblNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLevel.Location = new System.Drawing.Point(573, 83);
            this.lblNLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNLevel.Name = "lblNLevel";
            this.lblNLevel.Size = new System.Drawing.Size(83, 26);
            this.lblNLevel.TabIndex = 65;
            this.lblNLevel.Text = "N Level";
            // 
            // btnAddCabinet
            // 
            this.btnAddCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCabinet.Location = new System.Drawing.Point(361, 304);
            this.btnAddCabinet.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCabinet.Name = "btnAddCabinet";
            this.btnAddCabinet.Size = new System.Drawing.Size(88, 41);
            this.btnAddCabinet.TabIndex = 68;
            this.btnAddCabinet.Text = "Add";
            this.btnAddCabinet.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCabinet
            // 
            this.btnDeleteCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCabinet.Location = new System.Drawing.Point(449, 304);
            this.btnDeleteCabinet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCabinet.Name = "btnDeleteCabinet";
            this.btnDeleteCabinet.Size = new System.Drawing.Size(88, 41);
            this.btnDeleteCabinet.TabIndex = 69;
            this.btnDeleteCabinet.Text = "Delete";
            this.btnDeleteCabinet.UseVisualStyleBackColor = true;
            // 
            // btnAddNLevel
            // 
            this.btnAddNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNLevel.Location = new System.Drawing.Point(578, 304);
            this.btnAddNLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNLevel.Name = "btnAddNLevel";
            this.btnAddNLevel.Size = new System.Drawing.Size(88, 41);
            this.btnAddNLevel.TabIndex = 70;
            this.btnAddNLevel.Text = "Add";
            this.btnAddNLevel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNLevel
            // 
            this.btnDeleteNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNLevel.Location = new System.Drawing.Point(666, 304);
            this.btnDeleteNLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteNLevel.Name = "btnDeleteNLevel";
            this.btnDeleteNLevel.Size = new System.Drawing.Size(88, 41);
            this.btnDeleteNLevel.TabIndex = 71;
            this.btnDeleteNLevel.Text = "Delete";
            this.btnDeleteNLevel.UseVisualStyleBackColor = true;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(838, 84);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(112, 26);
            this.lblCategories.TabIndex = 74;
            this.lblCategories.Text = "Categories";
            // 
            // lstCabinet
            // 
            this.lstCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstCabinet.FormattingEnabled = true;
            this.lstCabinet.ItemHeight = 26;
            this.lstCabinet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lstCabinet.Location = new System.Drawing.Point(361, 112);
            this.lstCabinet.Name = "lstCabinet";
            this.lstCabinet.Size = new System.Drawing.Size(176, 186);
            this.lstCabinet.TabIndex = 77;
            // 
            // lstNLevel
            // 
            this.lstNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstNLevel.FormattingEnabled = true;
            this.lstNLevel.ItemHeight = 26;
            this.lstNLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "NP"});
            this.lstNLevel.Location = new System.Drawing.Point(578, 112);
            this.lstNLevel.Name = "lstNLevel";
            this.lstNLevel.Size = new System.Drawing.Size(176, 186);
            this.lstNLevel.TabIndex = 78;
            // 
            // lstCategories
            // 
            this.lstCategories.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 26;
            this.lstCategories.Items.AddRange(new object[] {
            "Assets",
            "Disposable",
            "Low Fidelity Simulator",
            "High Fidelity Simulator",
            "PPE"});
            this.lstCategories.Location = new System.Drawing.Point(843, 112);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(392, 186);
            this.lstCategories.TabIndex = 79;
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategories.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategories.Location = new System.Drawing.Point(906, 300);
            this.btnAddCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(121, 49);
            this.btnAddCategories.TabIndex = 82;
            this.btnAddCategories.Text = "Add";
            this.btnAddCategories.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1027, 300);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 49);
            this.button5.TabIndex = 83;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmSettingsLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 558);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAddCategories);
            this.Controls.Add(this.btnDeleteLocation);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lstNLevel);
            this.Controls.Add(this.lstCabinet);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.lblSetting_Locations_Title);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.btnDeleteNLevel);
            this.Controls.Add(this.btnAddNLevel);
            this.Controls.Add(this.btnDeleteCabinet);
            this.Controls.Add(this.btnAddCabinet);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblNLevel);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblLoctions);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSettingsLocations";
            this.Text = "frmLocationSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblLoctions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSetting_Locations_Title;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label lblNLevel;
        private System.Windows.Forms.Button btnAddCabinet;
        private System.Windows.Forms.Button btnDeleteCabinet;
        private System.Windows.Forms.Button btnAddNLevel;
        private System.Windows.Forms.Button btnDeleteNLevel;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ListBox lstCabinet;
        private System.Windows.Forms.ListBox lstNLevel;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Button button5;
    }
}