
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
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tbpUsers = new System.Windows.Forms.TabPage();
            this.btnUserPassword = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserSVSUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.chkUserAdmin = new System.Windows.Forms.CheckBox();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.txtUserFName = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpRooms = new System.Windows.Forms.TabPage();
            this.btnModifyRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnClearRoom = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.lstRoom = new System.Windows.Forms.ListBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.tbpCabinets = new System.Windows.Forms.TabPage();
            this.btnModifyCabinet = new System.Windows.Forms.Button();
            this.btnAddCabinet = new System.Windows.Forms.Button();
            this.btnClearCabinet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCabinetDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCabinetName = new System.Windows.Forms.TextBox();
            this.btnDeleteCabinet = new System.Windows.Forms.Button();
            this.lstCabinet = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.tbpCategories = new System.Windows.Forms.TabPage();
            this.btnModifyCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnClearCategory = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbpVendors = new System.Windows.Forms.TabPage();
            this.btnModifyVendor = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnClearVendor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtVendorDescription = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.lstVendor = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbpNLevel = new System.Windows.Forms.TabPage();
            this.btnModifyNLevel = new System.Windows.Forms.Button();
            this.btnAddNLevel = new System.Windows.Forms.Button();
            this.btnClearNLevel = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNLevelDescription = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNLevelName = new System.Windows.Forms.TextBox();
            this.btnDeleteNLevel = new System.Windows.Forms.Button();
            this.lstNLevel = new System.Windows.Forms.ListBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbcSettings.SuspendLayout();
            this.tbpUsers.SuspendLayout();
            this.tbpRooms.SuspendLayout();
            this.tbpCabinets.SuspendLayout();
            this.tbpCategories.SuspendLayout();
            this.tbpVendors.SuspendLayout();
            this.tbpNLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tbpUsers);
            this.tbcSettings.Controls.Add(this.tbpRooms);
            this.tbcSettings.Controls.Add(this.tbpCabinets);
            this.tbcSettings.Controls.Add(this.tbpCategories);
            this.tbcSettings.Controls.Add(this.tbpVendors);
            this.tbcSettings.Controls.Add(this.tbpNLevel);
            this.tbcSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSettings.Location = new System.Drawing.Point(12, 12);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(929, 440);
            this.tbcSettings.TabIndex = 2;
            this.tbcSettings.SelectedIndexChanged += new System.EventHandler(this.tbcSettings_SelectedIndexChanged);
            // 
            // tbpUsers
            // 
            this.tbpUsers.Controls.Add(this.btnUserPassword);
            this.tbpUsers.Controls.Add(this.label9);
            this.tbpUsers.Controls.Add(this.txtUserPhone);
            this.tbpUsers.Controls.Add(this.label10);
            this.tbpUsers.Controls.Add(this.txtUserEmail);
            this.tbpUsers.Controls.Add(this.label8);
            this.tbpUsers.Controls.Add(this.txtUserSVSUID);
            this.tbpUsers.Controls.Add(this.label7);
            this.tbpUsers.Controls.Add(this.txtUserLName);
            this.tbpUsers.Controls.Add(this.label6);
            this.tbpUsers.Controls.Add(this.btnClearUser);
            this.tbpUsers.Controls.Add(this.chkUserAdmin);
            this.tbpUsers.Controls.Add(this.btnModifyUser);
            this.tbpUsers.Controls.Add(this.txtUserFName);
            this.tbpUsers.Controls.Add(this.btnDeleteUser);
            this.tbpUsers.Controls.Add(this.btnAddUser);
            this.tbpUsers.Controls.Add(this.lstUser);
            this.tbpUsers.Controls.Add(this.label3);
            this.tbpUsers.Location = new System.Drawing.Point(4, 25);
            this.tbpUsers.Name = "tbpUsers";
            this.tbpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsers.Size = new System.Drawing.Size(921, 411);
            this.tbpUsers.TabIndex = 0;
            this.tbpUsers.Text = "Users";
            this.tbpUsers.UseVisualStyleBackColor = true;
            // 
            // btnUserPassword
            // 
            this.btnUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPassword.Location = new System.Drawing.Point(626, 311);
            this.btnUserPassword.Name = "btnUserPassword";
            this.btnUserPassword.Size = new System.Drawing.Size(188, 40);
            this.btnUserPassword.TabIndex = 125;
            this.btnUserPassword.Text = "Change Password";
            this.btnUserPassword.UseVisualStyleBackColor = true;
            this.btnUserPassword.Click += new System.EventHandler(this.btnUserPassword_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 122;
            this.label9.Text = "Phone:";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhone.Location = new System.Drawing.Point(554, 196);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(100, 22);
            this.txtUserPhone.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 120;
            this.label10.Text = "Email:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(554, 167);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(100, 22);
            this.txtUserEmail.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 118;
            this.label8.Text = "SVSU ID:";
            // 
            // txtUserSVSUID
            // 
            this.txtUserSVSUID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSVSUID.Location = new System.Drawing.Point(554, 80);
            this.txtUserSVSUID.Name = "txtUserSVSUID";
            this.txtUserSVSUID.Size = new System.Drawing.Size(100, 22);
            this.txtUserSVSUID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "Last Name:";
            // 
            // txtUserLName
            // 
            this.txtUserLName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLName.Location = new System.Drawing.Point(554, 138);
            this.txtUserLName.Name = "txtUserLName";
            this.txtUserLName.Size = new System.Drawing.Size(100, 22);
            this.txtUserLName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 114;
            this.label6.Text = "First Name:";
            // 
            // btnClearUser
            // 
            this.btnClearUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUser.Location = new System.Drawing.Point(432, 311);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(188, 40);
            this.btnClearUser.TabIndex = 10;
            this.btnClearUser.Text = "Clear";
            this.btnClearUser.UseVisualStyleBackColor = true;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // chkUserAdmin
            // 
            this.chkUserAdmin.AutoSize = true;
            this.chkUserAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserAdmin.Location = new System.Drawing.Point(554, 224);
            this.chkUserAdmin.Name = "chkUserAdmin";
            this.chkUserAdmin.Size = new System.Drawing.Size(76, 20);
            this.chkUserAdmin.TabIndex = 7;
            this.chkUserAdmin.Text = "Admin?";
            this.chkUserAdmin.UseVisualStyleBackColor = true;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyUser.Location = new System.Drawing.Point(626, 265);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(188, 40);
            this.btnModifyUser.TabIndex = 9;
            this.btnModifyUser.Text = "Modify";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // txtUserFName
            // 
            this.txtUserFName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFName.Location = new System.Drawing.Point(554, 109);
            this.txtUserFName.Name = "txtUserFName";
            this.txtUserFName.Size = new System.Drawing.Size(100, 22);
            this.txtUserFName.TabIndex = 2;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(186, 324);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.Text = "Delete Selected User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(432, 265);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(188, 40);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lstUser
            // 
            this.lstUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 16;
            this.lstUser.Location = new System.Drawing.Point(186, 61);
            this.lstUser.Margin = new System.Windows.Forms.Padding(2);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(210, 244);
            this.lstUser.TabIndex = 11;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 102;
            this.label3.Text = "Users";
            // 
            // tbpRooms
            // 
            this.tbpRooms.Controls.Add(this.btnModifyRoom);
            this.tbpRooms.Controls.Add(this.btnAddRoom);
            this.tbpRooms.Controls.Add(this.btnClearRoom);
            this.tbpRooms.Controls.Add(this.label12);
            this.tbpRooms.Controls.Add(this.txtRoomDescription);
            this.tbpRooms.Controls.Add(this.label4);
            this.tbpRooms.Controls.Add(this.txtRoomName);
            this.tbpRooms.Controls.Add(this.btnDeleteRoom);
            this.tbpRooms.Controls.Add(this.lstRoom);
            this.tbpRooms.Controls.Add(this.lblRoom);
            this.tbpRooms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpRooms.Location = new System.Drawing.Point(4, 25);
            this.tbpRooms.Name = "tbpRooms";
            this.tbpRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRooms.Size = new System.Drawing.Size(921, 411);
            this.tbpRooms.TabIndex = 1;
            this.tbpRooms.Text = "Rooms";
            this.tbpRooms.UseVisualStyleBackColor = true;
            // 
            // btnModifyRoom
            // 
            this.btnModifyRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyRoom.Location = new System.Drawing.Point(563, 278);
            this.btnModifyRoom.Name = "btnModifyRoom";
            this.btnModifyRoom.Size = new System.Drawing.Size(91, 40);
            this.btnModifyRoom.TabIndex = 4;
            this.btnModifyRoom.Text = "Modify";
            this.btnModifyRoom.UseVisualStyleBackColor = true;
            this.btnModifyRoom.Click += new System.EventHandler(this.btnModifyRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(466, 278);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(91, 40);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnClearRoom
            // 
            this.btnClearRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRoom.Location = new System.Drawing.Point(466, 324);
            this.btnClearRoom.Name = "btnClearRoom";
            this.btnClearRoom.Size = new System.Drawing.Size(188, 40);
            this.btnClearRoom.TabIndex = 5;
            this.btnClearRoom.Text = "Clear";
            this.btnClearRoom.UseVisualStyleBackColor = true;
            this.btnClearRoom.Click += new System.EventHandler(this.btnClearRoom_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(462, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 104;
            this.label12.Text = "Room Description:";
            // 
            // txtRoomDescription
            // 
            this.txtRoomDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomDescription.Location = new System.Drawing.Point(466, 149);
            this.txtRoomDescription.Multiline = true;
            this.txtRoomDescription.Name = "txtRoomDescription";
            this.txtRoomDescription.Size = new System.Drawing.Size(257, 124);
            this.txtRoomDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "Room Name:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(466, 99);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 22);
            this.txtRoomName.TabIndex = 1;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.Location = new System.Drawing.Point(186, 324);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteRoom.TabIndex = 7;
            this.btnDeleteRoom.Text = "Delete Selected Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // lstRoom
            // 
            this.lstRoom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.ItemHeight = 16;
            this.lstRoom.Location = new System.Drawing.Point(186, 61);
            this.lstRoom.Margin = new System.Windows.Forms.Padding(2);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(210, 244);
            this.lstRoom.TabIndex = 6;
            this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(182, 35);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(64, 22);
            this.lblRoom.TabIndex = 85;
            this.lblRoom.Text = "Room";
            // 
            // tbpCabinets
            // 
            this.tbpCabinets.Controls.Add(this.btnModifyCabinet);
            this.tbpCabinets.Controls.Add(this.btnAddCabinet);
            this.tbpCabinets.Controls.Add(this.btnClearCabinet);
            this.tbpCabinets.Controls.Add(this.label14);
            this.tbpCabinets.Controls.Add(this.label15);
            this.tbpCabinets.Controls.Add(this.txtCabinetDescription);
            this.tbpCabinets.Controls.Add(this.label16);
            this.tbpCabinets.Controls.Add(this.txtCabinetName);
            this.tbpCabinets.Controls.Add(this.btnDeleteCabinet);
            this.tbpCabinets.Controls.Add(this.lstCabinet);
            this.tbpCabinets.Controls.Add(this.label17);
            this.tbpCabinets.Controls.Add(this.label1);
            this.tbpCabinets.Controls.Add(this.cmbRoom);
            this.tbpCabinets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCabinets.Location = new System.Drawing.Point(4, 25);
            this.tbpCabinets.Name = "tbpCabinets";
            this.tbpCabinets.Size = new System.Drawing.Size(921, 411);
            this.tbpCabinets.TabIndex = 2;
            this.tbpCabinets.Text = "Cabinets";
            this.tbpCabinets.UseVisualStyleBackColor = true;
            // 
            // btnModifyCabinet
            // 
            this.btnModifyCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCabinet.Location = new System.Drawing.Point(563, 278);
            this.btnModifyCabinet.Name = "btnModifyCabinet";
            this.btnModifyCabinet.Size = new System.Drawing.Size(91, 40);
            this.btnModifyCabinet.TabIndex = 6;
            this.btnModifyCabinet.Text = "Modify";
            this.btnModifyCabinet.UseVisualStyleBackColor = true;
            // 
            // btnAddCabinet
            // 
            this.btnAddCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCabinet.Location = new System.Drawing.Point(466, 278);
            this.btnAddCabinet.Name = "btnAddCabinet";
            this.btnAddCabinet.Size = new System.Drawing.Size(91, 40);
            this.btnAddCabinet.TabIndex = 5;
            this.btnAddCabinet.Text = "Add";
            this.btnAddCabinet.UseVisualStyleBackColor = true;
            // 
            // btnClearCabinet
            // 
            this.btnClearCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCabinet.Location = new System.Drawing.Point(466, 324);
            this.btnClearCabinet.Name = "btnClearCabinet";
            this.btnClearCabinet.Size = new System.Drawing.Size(188, 40);
            this.btnClearCabinet.TabIndex = 8;
            this.btnClearCabinet.Text = "Clear";
            this.btnClearCabinet.UseVisualStyleBackColor = true;
            this.btnClearCabinet.Click += new System.EventHandler(this.btnClearCabinet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(404, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(366, 16);
            this.label14.TabIndex = 124;
            this.label14.Text = "(NOTE: When a cabinet is selected, these fields will populate)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(462, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 16);
            this.label15.TabIndex = 123;
            this.label15.Text = "Cabinet Description:";
            // 
            // txtCabinetDescription
            // 
            this.txtCabinetDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinetDescription.Location = new System.Drawing.Point(466, 149);
            this.txtCabinetDescription.Multiline = true;
            this.txtCabinetDescription.Name = "txtCabinetDescription";
            this.txtCabinetDescription.Size = new System.Drawing.Size(257, 124);
            this.txtCabinetDescription.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(462, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 16);
            this.label16.TabIndex = 121;
            this.label16.Text = "Cabinet Name:";
            // 
            // txtCabinetName
            // 
            this.txtCabinetName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinetName.Location = new System.Drawing.Point(466, 99);
            this.txtCabinetName.Name = "txtCabinetName";
            this.txtCabinetName.Size = new System.Drawing.Size(100, 22);
            this.txtCabinetName.TabIndex = 3;
            // 
            // btnDeleteCabinet
            // 
            this.btnDeleteCabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCabinet.Location = new System.Drawing.Point(186, 324);
            this.btnDeleteCabinet.Name = "btnDeleteCabinet";
            this.btnDeleteCabinet.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteCabinet.TabIndex = 7;
            this.btnDeleteCabinet.Text = "Delete Selected Cabinet";
            this.btnDeleteCabinet.UseVisualStyleBackColor = true;
            // 
            // lstCabinet
            // 
            this.lstCabinet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCabinet.FormattingEnabled = true;
            this.lstCabinet.ItemHeight = 16;
            this.lstCabinet.Location = new System.Drawing.Point(186, 61);
            this.lstCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.lstCabinet.Name = "lstCabinet";
            this.lstCabinet.Size = new System.Drawing.Size(210, 244);
            this.lstCabinet.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(182, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 22);
            this.label17.TabIndex = 117;
            this.label17.Text = "Cabinet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Room:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(14, 61);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(121, 24);
            this.cmbRoom.TabIndex = 1;
            // 
            // tbpCategories
            // 
            this.tbpCategories.Controls.Add(this.btnModifyCategory);
            this.tbpCategories.Controls.Add(this.btnAddCategory);
            this.tbpCategories.Controls.Add(this.btnClearCategory);
            this.tbpCategories.Controls.Add(this.label18);
            this.tbpCategories.Controls.Add(this.label19);
            this.tbpCategories.Controls.Add(this.txtCategoryDescription);
            this.tbpCategories.Controls.Add(this.label20);
            this.tbpCategories.Controls.Add(this.txtCategoryName);
            this.tbpCategories.Controls.Add(this.btnDeleteCategory);
            this.tbpCategories.Controls.Add(this.lstCategory);
            this.tbpCategories.Controls.Add(this.label21);
            this.tbpCategories.Location = new System.Drawing.Point(4, 25);
            this.tbpCategories.Name = "tbpCategories";
            this.tbpCategories.Size = new System.Drawing.Size(921, 411);
            this.tbpCategories.TabIndex = 3;
            this.tbpCategories.Text = "Categories";
            this.tbpCategories.UseVisualStyleBackColor = true;
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCategory.Location = new System.Drawing.Point(563, 278);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(91, 40);
            this.btnModifyCategory.TabIndex = 5;
            this.btnModifyCategory.Text = "Modify";
            this.btnModifyCategory.UseVisualStyleBackColor = true;
            this.btnModifyCategory.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(466, 278);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(91, 40);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCategory.Location = new System.Drawing.Point(466, 324);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(188, 40);
            this.btnClearCategory.TabIndex = 7;
            this.btnClearCategory.Text = "Clear";
            this.btnClearCategory.UseVisualStyleBackColor = true;
            this.btnClearCategory.Click += new System.EventHandler(this.btnClearCategory_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(404, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(374, 16);
            this.label18.TabIndex = 124;
            this.label18.Text = "(NOTE: When a category is selected, these fields will populate)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(463, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 16);
            this.label19.TabIndex = 123;
            this.label19.Text = "Category Description:";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(466, 149);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(257, 124);
            this.txtCategoryDescription.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(462, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 16);
            this.label20.TabIndex = 121;
            this.label20.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(466, 99);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 22);
            this.txtCategoryName.TabIndex = 2;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(186, 324);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteCategory.TabIndex = 6;
            this.btnDeleteCategory.Text = "Delete Selected Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lstCategory
            // 
            this.lstCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 16;
            this.lstCategory.Location = new System.Drawing.Point(186, 61);
            this.lstCategory.Margin = new System.Windows.Forms.Padding(2);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(210, 244);
            this.lstCategory.TabIndex = 1;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(182, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 22);
            this.label21.TabIndex = 117;
            this.label21.Text = "Category";
            // 
            // tbpVendors
            // 
            this.tbpVendors.Controls.Add(this.btnModifyVendor);
            this.tbpVendors.Controls.Add(this.btnAddVendor);
            this.tbpVendors.Controls.Add(this.btnClearVendor);
            this.tbpVendors.Controls.Add(this.label2);
            this.tbpVendors.Controls.Add(this.label22);
            this.tbpVendors.Controls.Add(this.txtVendorDescription);
            this.tbpVendors.Controls.Add(this.label23);
            this.tbpVendors.Controls.Add(this.txtVendorName);
            this.tbpVendors.Controls.Add(this.btnDeleteVendor);
            this.tbpVendors.Controls.Add(this.lstVendor);
            this.tbpVendors.Controls.Add(this.label24);
            this.tbpVendors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpVendors.Location = new System.Drawing.Point(4, 25);
            this.tbpVendors.Name = "tbpVendors";
            this.tbpVendors.Size = new System.Drawing.Size(921, 411);
            this.tbpVendors.TabIndex = 4;
            this.tbpVendors.Text = "Vendors";
            this.tbpVendors.UseVisualStyleBackColor = true;
            // 
            // btnModifyVendor
            // 
            this.btnModifyVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyVendor.Location = new System.Drawing.Point(563, 278);
            this.btnModifyVendor.Name = "btnModifyVendor";
            this.btnModifyVendor.Size = new System.Drawing.Size(91, 40);
            this.btnModifyVendor.TabIndex = 5;
            this.btnModifyVendor.Text = "Modify";
            this.btnModifyVendor.UseVisualStyleBackColor = true;
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVendor.Location = new System.Drawing.Point(466, 278);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(91, 40);
            this.btnAddVendor.TabIndex = 4;
            this.btnAddVendor.Text = "Add";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            // 
            // btnClearVendor
            // 
            this.btnClearVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVendor.Location = new System.Drawing.Point(466, 324);
            this.btnClearVendor.Name = "btnClearVendor";
            this.btnClearVendor.Size = new System.Drawing.Size(188, 40);
            this.btnClearVendor.TabIndex = 7;
            this.btnClearVendor.Text = "Clear";
            this.btnClearVendor.UseVisualStyleBackColor = true;
            this.btnClearVendor.Click += new System.EventHandler(this.btnClearVendor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 16);
            this.label2.TabIndex = 135;
            this.label2.Text = "(NOTE: When a vendor is selected, these fields will populate)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(463, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 16);
            this.label22.TabIndex = 134;
            this.label22.Text = "Vendor Description:";
            // 
            // txtVendorDescription
            // 
            this.txtVendorDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorDescription.Location = new System.Drawing.Point(466, 149);
            this.txtVendorDescription.Multiline = true;
            this.txtVendorDescription.Name = "txtVendorDescription";
            this.txtVendorDescription.Size = new System.Drawing.Size(257, 124);
            this.txtVendorDescription.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(462, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 16);
            this.label23.TabIndex = 132;
            this.label23.Text = "Vendor Name:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.Location = new System.Drawing.Point(466, 99);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(100, 22);
            this.txtVendorName.TabIndex = 2;
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVendor.Location = new System.Drawing.Point(186, 324);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteVendor.TabIndex = 6;
            this.btnDeleteVendor.Text = "Delete Selected Vendor";
            this.btnDeleteVendor.UseVisualStyleBackColor = true;
            // 
            // lstVendor
            // 
            this.lstVendor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVendor.FormattingEnabled = true;
            this.lstVendor.ItemHeight = 16;
            this.lstVendor.Location = new System.Drawing.Point(186, 61);
            this.lstVendor.Margin = new System.Windows.Forms.Padding(2);
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Size = new System.Drawing.Size(210, 244);
            this.lstVendor.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(182, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 22);
            this.label24.TabIndex = 128;
            this.label24.Text = "Vendor";
            // 
            // tbpNLevel
            // 
            this.tbpNLevel.Controls.Add(this.btnModifyNLevel);
            this.tbpNLevel.Controls.Add(this.btnAddNLevel);
            this.tbpNLevel.Controls.Add(this.btnClearNLevel);
            this.tbpNLevel.Controls.Add(this.label25);
            this.tbpNLevel.Controls.Add(this.label26);
            this.tbpNLevel.Controls.Add(this.txtNLevelDescription);
            this.tbpNLevel.Controls.Add(this.label27);
            this.tbpNLevel.Controls.Add(this.txtNLevelName);
            this.tbpNLevel.Controls.Add(this.btnDeleteNLevel);
            this.tbpNLevel.Controls.Add(this.lstNLevel);
            this.tbpNLevel.Controls.Add(this.label28);
            this.tbpNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNLevel.Location = new System.Drawing.Point(4, 25);
            this.tbpNLevel.Name = "tbpNLevel";
            this.tbpNLevel.Size = new System.Drawing.Size(921, 411);
            this.tbpNLevel.TabIndex = 5;
            this.tbpNLevel.Text = "N-Level";
            this.tbpNLevel.UseVisualStyleBackColor = true;
            // 
            // btnModifyNLevel
            // 
            this.btnModifyNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyNLevel.Location = new System.Drawing.Point(563, 278);
            this.btnModifyNLevel.Name = "btnModifyNLevel";
            this.btnModifyNLevel.Size = new System.Drawing.Size(91, 40);
            this.btnModifyNLevel.TabIndex = 5;
            this.btnModifyNLevel.Text = "Modify";
            this.btnModifyNLevel.UseVisualStyleBackColor = true;
            // 
            // btnAddNLevel
            // 
            this.btnAddNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNLevel.Location = new System.Drawing.Point(466, 278);
            this.btnAddNLevel.Name = "btnAddNLevel";
            this.btnAddNLevel.Size = new System.Drawing.Size(91, 40);
            this.btnAddNLevel.TabIndex = 4;
            this.btnAddNLevel.Text = "Add";
            this.btnAddNLevel.UseVisualStyleBackColor = true;
            // 
            // btnClearNLevel
            // 
            this.btnClearNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNLevel.Location = new System.Drawing.Point(466, 324);
            this.btnClearNLevel.Name = "btnClearNLevel";
            this.btnClearNLevel.Size = new System.Drawing.Size(188, 40);
            this.btnClearNLevel.TabIndex = 7;
            this.btnClearNLevel.Text = "Clear";
            this.btnClearNLevel.UseVisualStyleBackColor = true;
            this.btnClearNLevel.Click += new System.EventHandler(this.btnClearNLevel_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(404, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(373, 16);
            this.label25.TabIndex = 146;
            this.label25.Text = "(NOTE: When an N-Level is selected, these fields will populate)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(463, 127);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(135, 16);
            this.label26.TabIndex = 145;
            this.label26.Text = "N-Level Description:";
            // 
            // txtNLevelDescription
            // 
            this.txtNLevelDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLevelDescription.Location = new System.Drawing.Point(466, 149);
            this.txtNLevelDescription.Multiline = true;
            this.txtNLevelDescription.Name = "txtNLevelDescription";
            this.txtNLevelDescription.Size = new System.Drawing.Size(257, 124);
            this.txtNLevelDescription.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(463, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 16);
            this.label27.TabIndex = 143;
            this.label27.Text = "N-Level Name:";
            // 
            // txtNLevelName
            // 
            this.txtNLevelName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLevelName.Location = new System.Drawing.Point(466, 99);
            this.txtNLevelName.Name = "txtNLevelName";
            this.txtNLevelName.Size = new System.Drawing.Size(100, 22);
            this.txtNLevelName.TabIndex = 2;
            // 
            // btnDeleteNLevel
            // 
            this.btnDeleteNLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNLevel.Location = new System.Drawing.Point(186, 324);
            this.btnDeleteNLevel.Name = "btnDeleteNLevel";
            this.btnDeleteNLevel.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteNLevel.TabIndex = 6;
            this.btnDeleteNLevel.Text = "Delete Selected N-Level";
            this.btnDeleteNLevel.UseVisualStyleBackColor = true;
            // 
            // lstNLevel
            // 
            this.lstNLevel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNLevel.FormattingEnabled = true;
            this.lstNLevel.ItemHeight = 16;
            this.lstNLevel.Location = new System.Drawing.Point(186, 61);
            this.lstNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.lstNLevel.Name = "lstNLevel";
            this.lstNLevel.Size = new System.Drawing.Size(210, 244);
            this.lstNLevel.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(182, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 22);
            this.label28.TabIndex = 139;
            this.label28.Text = "N-Level";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 461);
            this.Controls.Add(this.tbcSettings);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.tbcSettings.ResumeLayout(false);
            this.tbpUsers.ResumeLayout(false);
            this.tbpUsers.PerformLayout();
            this.tbpRooms.ResumeLayout(false);
            this.tbpRooms.PerformLayout();
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

        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tbpUsers;
        private System.Windows.Forms.TabPage tbpRooms;
        private System.Windows.Forms.TabPage tbpCabinets;
        private System.Windows.Forms.TabPage tbpCategories;
        private System.Windows.Forms.TabPage tbpVendors;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.ListBox lstRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TabPage tbpNLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtUserFName;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.CheckBox chkUserAdmin;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserSVSUID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRoomDescription;
        private System.Windows.Forms.Button btnClearRoom;
        private System.Windows.Forms.Button btnModifyRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnModifyCabinet;
        private System.Windows.Forms.Button btnAddCabinet;
        private System.Windows.Forms.Button btnClearCabinet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCabinetDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCabinetName;
        private System.Windows.Forms.Button btnDeleteCabinet;
        private System.Windows.Forms.ListBox lstCabinet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnModifyCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnClearCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnModifyVendor;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnClearVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtVendorDescription;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.ListBox lstVendor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnModifyNLevel;
        private System.Windows.Forms.Button btnAddNLevel;
        private System.Windows.Forms.Button btnClearNLevel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtNLevelDescription;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNLevelName;
        private System.Windows.Forms.Button btnDeleteNLevel;
        private System.Windows.Forms.ListBox lstNLevel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnUserPassword;
    }
}
