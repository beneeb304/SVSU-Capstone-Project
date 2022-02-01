
namespace SVSU_Capstone_Project.Views
{
    partial class frmSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpUsers = new System.Windows.Forms.TabPage();
            this.tbpLocations = new System.Windows.Forms.TabPage();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lblLoction = new System.Windows.Forms.Label();
            this.tbpCabinets = new System.Windows.Forms.TabPage();
            this.tbpCategories = new System.Windows.Forms.TabPage();
            this.tbpVendors = new System.Windows.Forms.TabPage();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.lblNLevel = new System.Windows.Forms.Label();
            this.btnAddNLevel = new System.Windows.Forms.Button();
            this.btnDeleteNLevel = new System.Windows.Forms.Button();
            this.lstNLevel = new System.Windows.Forms.ListBox();
            this.tbpNLevel = new System.Windows.Forms.TabPage();
            this.txtAddNLevel = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lstCabinet = new System.Windows.Forms.ListBox();
            this.btnDeleteCabinet = new System.Windows.Forms.Button();
            this.btnAddCabinet = new System.Windows.Forms.Button();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.cmbCabinet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddVendor = new System.Windows.Forms.TextBox();
            this.lstVendor = new System.Windows.Forms.ListBox();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddCabinet = new System.Windows.Forms.TextBox();
            this.txtAddLocation = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModifyUser = new System.Windows.Forms.TextBox();
            this.chkModifyAdmin = new System.Windows.Forms.CheckBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.chkAddAdmin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifyCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpUsers.SuspendLayout();
            this.tbpLocations.SuspendLayout();
            this.tbpCabinets.SuspendLayout();
            this.tbpCategories.SuspendLayout();
            this.tbpVendors.SuspendLayout();
            this.tbpNLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpUsers);
            this.tabControl1.Controls.Add(this.tbpLocations);
            this.tabControl1.Controls.Add(this.tbpCabinets);
            this.tabControl1.Controls.Add(this.tbpCategories);
            this.tabControl1.Controls.Add(this.tbpVendors);
            this.tabControl1.Controls.Add(this.tbpNLevel);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 440);
            this.tabControl1.TabIndex = 2;
            // 
            // tbpUsers
            // 
            this.tbpUsers.Controls.Add(this.btnModifyCancel);
            this.tbpUsers.Controls.Add(this.label5);
            this.tbpUsers.Controls.Add(this.chkAddAdmin);
            this.tbpUsers.Controls.Add(this.btnModify);
            this.tbpUsers.Controls.Add(this.chkModifyAdmin);
            this.tbpUsers.Controls.Add(this.txtModifyUser);
            this.tbpUsers.Controls.Add(this.label4);
            this.tbpUsers.Controls.Add(this.txtUser);
            this.tbpUsers.Controls.Add(this.btnDeleteUser);
            this.tbpUsers.Controls.Add(this.btnAddUser);
            this.tbpUsers.Controls.Add(this.lstUser);
            this.tbpUsers.Controls.Add(this.label3);
            this.tbpUsers.Location = new System.Drawing.Point(4, 22);
            this.tbpUsers.Name = "tbpUsers";
            this.tbpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsers.Size = new System.Drawing.Size(921, 414);
            this.tbpUsers.TabIndex = 0;
            this.tbpUsers.Text = "Users";
            this.tbpUsers.UseVisualStyleBackColor = true;
            // 
            // tbpLocations
            // 
            this.tbpLocations.Controls.Add(this.txtAddLocation);
            this.tbpLocations.Controls.Add(this.btnDeleteLocation);
            this.tbpLocations.Controls.Add(this.btnAddLocation);
            this.tbpLocations.Controls.Add(this.lstLocation);
            this.tbpLocations.Controls.Add(this.lblLoction);
            this.tbpLocations.Location = new System.Drawing.Point(4, 22);
            this.tbpLocations.Name = "tbpLocations";
            this.tbpLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLocations.Size = new System.Drawing.Size(921, 414);
            this.tbpLocations.TabIndex = 1;
            this.tbpLocations.Text = "Locations";
            this.tbpLocations.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteLocation.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocation.Location = new System.Drawing.Point(276, 345);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(91, 40);
            this.btnDeleteLocation.TabIndex = 100;
            this.btnDeleteLocation.Text = "Delete";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLocation.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Location = new System.Drawing.Point(185, 345);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(91, 40);
            this.btnAddLocation.TabIndex = 99;
            this.btnAddLocation.Text = "Add";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 22;
            this.lstLocation.Items.AddRange(new object[] {
            "HE 111",
            "HE 112",
            "HE 145",
            "HE 267",
            "HE 284"});
            this.lstLocation.Location = new System.Drawing.Point(186, 61);
            this.lstLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(182, 268);
            this.lstLocation.TabIndex = 95;
            // 
            // lblLoction
            // 
            this.lblLoction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoction.AutoSize = true;
            this.lblLoction.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoction.Location = new System.Drawing.Point(182, 37);
            this.lblLoction.Name = "lblLoction";
            this.lblLoction.Size = new System.Drawing.Size(77, 22);
            this.lblLoction.TabIndex = 85;
            this.lblLoction.Text = "Location";
            // 
            // tbpCabinets
            // 
            this.tbpCabinets.Controls.Add(this.txtAddCabinet);
            this.tbpCabinets.Controls.Add(this.label1);
            this.tbpCabinets.Controls.Add(this.cmbCabinet);
            this.tbpCabinets.Controls.Add(this.lstCabinet);
            this.tbpCabinets.Controls.Add(this.btnDeleteCabinet);
            this.tbpCabinets.Controls.Add(this.btnAddCabinet);
            this.tbpCabinets.Controls.Add(this.lblCabinet);
            this.tbpCabinets.Location = new System.Drawing.Point(4, 22);
            this.tbpCabinets.Name = "tbpCabinets";
            this.tbpCabinets.Size = new System.Drawing.Size(921, 414);
            this.tbpCabinets.TabIndex = 2;
            this.tbpCabinets.Text = "Cabinets";
            this.tbpCabinets.UseVisualStyleBackColor = true;
            // 
            // tbpCategories
            // 
            this.tbpCategories.Controls.Add(this.btnDeleteCategory);
            this.tbpCategories.Controls.Add(this.btnAddCategory);
            this.tbpCategories.Controls.Add(this.lstCategory);
            this.tbpCategories.Controls.Add(this.lblCategory);
            this.tbpCategories.Controls.Add(this.txtAddCategory);
            this.tbpCategories.Location = new System.Drawing.Point(4, 22);
            this.tbpCategories.Name = "tbpCategories";
            this.tbpCategories.Size = new System.Drawing.Size(921, 414);
            this.tbpCategories.TabIndex = 3;
            this.tbpCategories.Text = "Categories";
            this.tbpCategories.UseVisualStyleBackColor = true;
            // 
            // tbpVendors
            // 
            this.tbpVendors.Controls.Add(this.txtAddVendor);
            this.tbpVendors.Controls.Add(this.lstVendor);
            this.tbpVendors.Controls.Add(this.btnDeleteVendor);
            this.tbpVendors.Controls.Add(this.btnAddVendor);
            this.tbpVendors.Controls.Add(this.label2);
            this.tbpVendors.Location = new System.Drawing.Point(4, 22);
            this.tbpVendors.Name = "tbpVendors";
            this.tbpVendors.Size = new System.Drawing.Size(921, 414);
            this.tbpVendors.TabIndex = 4;
            this.tbpVendors.Text = "Vendors";
            this.tbpVendors.UseVisualStyleBackColor = true;
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.Location = new System.Drawing.Point(25, 178);
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(100, 20);
            this.txtAddCategory.TabIndex = 1;
            // 
            // lblNLevel
            // 
            this.lblNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNLevel.AutoSize = true;
            this.lblNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLevel.Location = new System.Drawing.Point(392, 101);
            this.lblNLevel.Name = "lblNLevel";
            this.lblNLevel.Size = new System.Drawing.Size(65, 22);
            this.lblNLevel.TabIndex = 98;
            this.lblNLevel.Text = "N Level";
            // 
            // btnAddNLevel
            // 
            this.btnAddNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNLevel.Location = new System.Drawing.Point(396, 281);
            this.btnAddNLevel.Name = "btnAddNLevel";
            this.btnAddNLevel.Size = new System.Drawing.Size(66, 33);
            this.btnAddNLevel.TabIndex = 99;
            this.btnAddNLevel.Text = "Add";
            this.btnAddNLevel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNLevel
            // 
            this.btnDeleteNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNLevel.Location = new System.Drawing.Point(462, 281);
            this.btnDeleteNLevel.Name = "btnDeleteNLevel";
            this.btnDeleteNLevel.Size = new System.Drawing.Size(66, 33);
            this.btnDeleteNLevel.TabIndex = 100;
            this.btnDeleteNLevel.Text = "Delete";
            this.btnDeleteNLevel.UseVisualStyleBackColor = true;
            // 
            // lstNLevel
            // 
            this.lstNLevel.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstNLevel.FormattingEnabled = true;
            this.lstNLevel.ItemHeight = 22;
            this.lstNLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "NP"});
            this.lstNLevel.Location = new System.Drawing.Point(396, 125);
            this.lstNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.lstNLevel.Name = "lstNLevel";
            this.lstNLevel.Size = new System.Drawing.Size(133, 136);
            this.lstNLevel.TabIndex = 101;
            // 
            // tbpNLevel
            // 
            this.tbpNLevel.Controls.Add(this.txtAddNLevel);
            this.tbpNLevel.Controls.Add(this.lstNLevel);
            this.tbpNLevel.Controls.Add(this.btnDeleteNLevel);
            this.tbpNLevel.Controls.Add(this.btnAddNLevel);
            this.tbpNLevel.Controls.Add(this.lblNLevel);
            this.tbpNLevel.Location = new System.Drawing.Point(4, 22);
            this.tbpNLevel.Name = "tbpNLevel";
            this.tbpNLevel.Size = new System.Drawing.Size(921, 414);
            this.tbpNLevel.TabIndex = 5;
            this.tbpNLevel.Text = "N-Level";
            this.tbpNLevel.UseVisualStyleBackColor = true;
            // 
            // txtAddNLevel
            // 
            this.txtAddNLevel.Location = new System.Drawing.Point(290, 281);
            this.txtAddNLevel.Name = "txtAddNLevel";
            this.txtAddNLevel.Size = new System.Drawing.Size(100, 20);
            this.txtAddNLevel.TabIndex = 102;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(229, 178);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(91, 40);
            this.btnDeleteCategory.TabIndex = 106;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(139, 178);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(91, 40);
            this.btnAddCategory.TabIndex = 105;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // lstCategory
            // 
            this.lstCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 22;
            this.lstCategory.Items.AddRange(new object[] {
            "Assets",
            "Disposable",
            "Low Fidelity Simulator",
            "High Fidelity Simulator",
            "PPE"});
            this.lstCategory.Location = new System.Drawing.Point(25, 37);
            this.lstCategory.Margin = new System.Windows.Forms.Padding(2);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(295, 136);
            this.lstCategory.TabIndex = 104;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(21, 14);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 22);
            this.lblCategory.TabIndex = 103;
            this.lblCategory.Text = "Category";
            // 
            // lstCabinet
            // 
            this.lstCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstCabinet.FormattingEnabled = true;
            this.lstCabinet.ItemHeight = 22;
            this.lstCabinet.Location = new System.Drawing.Point(328, 104);
            this.lstCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.lstCabinet.Name = "lstCabinet";
            this.lstCabinet.Size = new System.Drawing.Size(133, 136);
            this.lstCabinet.TabIndex = 100;
            // 
            // btnDeleteCabinet
            // 
            this.btnDeleteCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCabinet.Location = new System.Drawing.Point(394, 260);
            this.btnDeleteCabinet.Name = "btnDeleteCabinet";
            this.btnDeleteCabinet.Size = new System.Drawing.Size(66, 33);
            this.btnDeleteCabinet.TabIndex = 99;
            this.btnDeleteCabinet.Text = "Delete";
            this.btnDeleteCabinet.UseVisualStyleBackColor = true;
            // 
            // btnAddCabinet
            // 
            this.btnAddCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCabinet.Location = new System.Drawing.Point(328, 260);
            this.btnAddCabinet.Name = "btnAddCabinet";
            this.btnAddCabinet.Size = new System.Drawing.Size(66, 33);
            this.btnAddCabinet.TabIndex = 98;
            this.btnAddCabinet.Text = "Add";
            this.btnAddCabinet.UseVisualStyleBackColor = true;
            // 
            // lblCabinet
            // 
            this.lblCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.Location = new System.Drawing.Point(324, 80);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(67, 22);
            this.lblCabinet.TabIndex = 97;
            this.lblCabinet.Text = "Cabinet";
            // 
            // cmbCabinet
            // 
            this.cmbCabinet.FormattingEnabled = true;
            this.cmbCabinet.Location = new System.Drawing.Point(79, 62);
            this.cmbCabinet.Name = "cmbCabinet";
            this.cmbCabinet.Size = new System.Drawing.Size(121, 21);
            this.cmbCabinet.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Location:";
            // 
            // txtAddVendor
            // 
            this.txtAddVendor.Location = new System.Drawing.Point(168, 281);
            this.txtAddVendor.Name = "txtAddVendor";
            this.txtAddVendor.Size = new System.Drawing.Size(100, 20);
            this.txtAddVendor.TabIndex = 107;
            // 
            // lstVendor
            // 
            this.lstVendor.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstVendor.FormattingEnabled = true;
            this.lstVendor.ItemHeight = 22;
            this.lstVendor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "NP"});
            this.lstVendor.Location = new System.Drawing.Point(274, 125);
            this.lstVendor.Margin = new System.Windows.Forms.Padding(2);
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Size = new System.Drawing.Size(133, 136);
            this.lstVendor.TabIndex = 106;
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteVendor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVendor.Location = new System.Drawing.Point(340, 281);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(66, 33);
            this.btnDeleteVendor.TabIndex = 105;
            this.btnDeleteVendor.Text = "Delete";
            this.btnDeleteVendor.UseVisualStyleBackColor = true;
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVendor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVendor.Location = new System.Drawing.Point(274, 281);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(66, 33);
            this.btnAddVendor.TabIndex = 104;
            this.btnAddVendor.Text = "Add";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 103;
            this.label2.Text = "Vendor";
            // 
            // txtAddCabinet
            // 
            this.txtAddCabinet.Location = new System.Drawing.Point(222, 260);
            this.txtAddCabinet.Name = "txtAddCabinet";
            this.txtAddCabinet.Size = new System.Drawing.Size(100, 20);
            this.txtAddCabinet.TabIndex = 103;
            // 
            // txtAddLocation
            // 
            this.txtAddLocation.Location = new System.Drawing.Point(79, 345);
            this.txtAddLocation.Name = "txtAddLocation";
            this.txtAddLocation.Size = new System.Drawing.Size(100, 20);
            this.txtAddLocation.TabIndex = 101;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(60, 329);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 106;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(257, 329);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(91, 40);
            this.btnDeleteUser.TabIndex = 105;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(166, 329);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(91, 40);
            this.btnAddUser.TabIndex = 104;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lstUser
            // 
            this.lstUser.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 22;
            this.lstUser.Location = new System.Drawing.Point(167, 45);
            this.lstUser.Margin = new System.Windows.Forms.Padding(2);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(182, 268);
            this.lstUser.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 102;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Modify User Details:";
            // 
            // txtModifyUser
            // 
            this.txtModifyUser.Location = new System.Drawing.Point(585, 94);
            this.txtModifyUser.Name = "txtModifyUser";
            this.txtModifyUser.Size = new System.Drawing.Size(100, 20);
            this.txtModifyUser.TabIndex = 108;
            // 
            // chkModifyAdmin
            // 
            this.chkModifyAdmin.AutoSize = true;
            this.chkModifyAdmin.Location = new System.Drawing.Point(691, 96);
            this.chkModifyAdmin.Name = "chkModifyAdmin";
            this.chkModifyAdmin.Size = new System.Drawing.Size(61, 17);
            this.chkModifyAdmin.TabIndex = 109;
            this.chkModifyAdmin.Text = "Admin?";
            this.chkModifyAdmin.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModify.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(585, 120);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 40);
            this.btnModify.TabIndex = 110;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // chkAddAdmin
            // 
            this.chkAddAdmin.AutoSize = true;
            this.chkAddAdmin.Location = new System.Drawing.Point(60, 352);
            this.chkAddAdmin.Name = "chkAddAdmin";
            this.chkAddAdmin.Size = new System.Drawing.Size(61, 17);
            this.chkAddAdmin.TabIndex = 111;
            this.chkAddAdmin.Text = "Admin?";
            this.chkAddAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "(When a user is selected, these fields will populate)";
            // 
            // btnModifyCancel
            // 
            this.btnModifyCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyCancel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCancel.Location = new System.Drawing.Point(682, 119);
            this.btnModifyCancel.Name = "btnModifyCancel";
            this.btnModifyCancel.Size = new System.Drawing.Size(91, 40);
            this.btnModifyCancel.TabIndex = 113;
            this.btnModifyCancel.Text = "Cancel";
            this.btnModifyCancel.UseVisualStyleBackColor = true;
            this.btnModifyCancel.Click += new System.EventHandler(this.btnModifyCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.tabControl1.ResumeLayout(false);
            this.tbpUsers.ResumeLayout(false);
            this.tbpUsers.PerformLayout();
            this.tbpLocations.ResumeLayout(false);
            this.tbpLocations.PerformLayout();
            this.tbpCabinets.ResumeLayout(false);
            this.tbpCabinets.PerformLayout();
            this.tbpCategories.ResumeLayout(false);
            this.tbpCategories.PerformLayout();
            this.tbpVendors.ResumeLayout(false);
            this.tbpVendors.PerformLayout();
            this.tbpNLevel.ResumeLayout(false);
            this.tbpNLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpUsers;
        private System.Windows.Forms.TabPage tbpLocations;
        private System.Windows.Forms.TabPage tbpCabinets;
        private System.Windows.Forms.TabPage tbpCategories;
        private System.Windows.Forms.TabPage tbpVendors;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.Label lblLoction;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.TabPage tbpNLevel;
        private System.Windows.Forms.TextBox txtAddNLevel;
        private System.Windows.Forms.ListBox lstNLevel;
        private System.Windows.Forms.Button btnDeleteNLevel;
        private System.Windows.Forms.Button btnAddNLevel;
        private System.Windows.Forms.Label lblNLevel;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox lstCabinet;
        private System.Windows.Forms.Button btnDeleteCabinet;
        private System.Windows.Forms.Button btnAddCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCabinet;
        private System.Windows.Forms.TextBox txtAddVendor;
        private System.Windows.Forms.ListBox lstVendor;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddCabinet;
        private System.Windows.Forms.TextBox txtAddLocation;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModifyUser;
        private System.Windows.Forms.CheckBox chkModifyAdmin;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.CheckBox chkAddAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModifyCancel;
    }
}