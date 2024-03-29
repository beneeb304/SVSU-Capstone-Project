﻿
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
            this.btnMassDelete = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserUpload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserSVSUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkUserAdmin = new System.Windows.Forms.CheckBox();
            this.btnUserModify = new System.Windows.Forms.Button();
            this.txtUserFName = new System.Windows.Forms.TextBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpRooms = new System.Windows.Forms.TabPage();
            this.btnRoomCancel = new System.Windows.Forms.Button();
            this.btnRoomSave = new System.Windows.Forms.Button();
            this.btnRoomModify = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.lstRoom = new System.Windows.Forms.ListBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.tbpCabinets = new System.Windows.Forms.TabPage();
            this.btnCabinetCancel = new System.Windows.Forms.Button();
            this.btnCabinetSave = new System.Windows.Forms.Button();
            this.btnCabinetModify = new System.Windows.Forms.Button();
            this.btnCabinetAdd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCabinetDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCabinetName = new System.Windows.Forms.TextBox();
            this.btnCabinetDelete = new System.Windows.Forms.Button();
            this.lstCabinet = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.tbpCategories = new System.Windows.Forms.TabPage();
            this.btnCategoryCancel = new System.Windows.Forms.Button();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnCategoryModify = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbpVendors = new System.Windows.Forms.TabPage();
            this.btnVendorCancel = new System.Windows.Forms.Button();
            this.btnVendorSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendorHomepage = new System.Windows.Forms.TextBox();
            this.btnVendorModify = new System.Windows.Forms.Button();
            this.btnVendorAdd = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtVendorDescription = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.btnVendorDelete = new System.Windows.Forms.Button();
            this.lstVendor = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbcSettings.SuspendLayout();
            this.tbpUsers.SuspendLayout();
            this.tbpRooms.SuspendLayout();
            this.tbpCabinets.SuspendLayout();
            this.tbpCategories.SuspendLayout();
            this.tbpVendors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tbpUsers);
            this.tbcSettings.Controls.Add(this.tbpRooms);
            this.tbcSettings.Controls.Add(this.tbpCabinets);
            this.tbcSettings.Controls.Add(this.tbpCategories);
            this.tbcSettings.Controls.Add(this.tbpVendors);
            this.tbcSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSettings.Location = new System.Drawing.Point(16, 15);
            this.tbcSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(1239, 542);
            this.tbcSettings.TabIndex = 2;
            this.tbcSettings.SelectedIndexChanged += new System.EventHandler(this.tbcSettings_SelectedIndexChanged);
            // 
            // tbpUsers
            // 
            this.tbpUsers.Controls.Add(this.btnMassDelete);
            this.tbpUsers.Controls.Add(this.btnUserCancel);
            this.tbpUsers.Controls.Add(this.btnUserSave);
            this.tbpUsers.Controls.Add(this.btnUserUpload);
            this.tbpUsers.Controls.Add(this.label9);
            this.tbpUsers.Controls.Add(this.txtUserPhone);
            this.tbpUsers.Controls.Add(this.label10);
            this.tbpUsers.Controls.Add(this.txtUserEmail);
            this.tbpUsers.Controls.Add(this.label8);
            this.tbpUsers.Controls.Add(this.txtUserSVSUID);
            this.tbpUsers.Controls.Add(this.label7);
            this.tbpUsers.Controls.Add(this.txtUserLName);
            this.tbpUsers.Controls.Add(this.label6);
            this.tbpUsers.Controls.Add(this.chkUserAdmin);
            this.tbpUsers.Controls.Add(this.btnUserModify);
            this.tbpUsers.Controls.Add(this.txtUserFName);
            this.tbpUsers.Controls.Add(this.btnUserDelete);
            this.tbpUsers.Controls.Add(this.btnUserAdd);
            this.tbpUsers.Controls.Add(this.lstUser);
            this.tbpUsers.Controls.Add(this.label3);
            this.tbpUsers.Location = new System.Drawing.Point(4, 27);
            this.tbpUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tbpUsers.Name = "tbpUsers";
            this.tbpUsers.Padding = new System.Windows.Forms.Padding(4);
            this.tbpUsers.Size = new System.Drawing.Size(1231, 511);
            this.tbpUsers.TabIndex = 0;
            this.tbpUsers.Text = "Users";
            this.tbpUsers.UseVisualStyleBackColor = true;
            // 
            // btnMassDelete
            // 
            this.btnMassDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMassDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMassDelete.Location = new System.Drawing.Point(751, 263);
            this.btnMassDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMassDelete.Name = "btnMassDelete";
            this.btnMassDelete.Size = new System.Drawing.Size(280, 49);
            this.btnMassDelete.TabIndex = 123;
            this.btnMassDelete.Text = "Mass Delete Students";
            this.btnMassDelete.UseVisualStyleBackColor = true;
            this.btnMassDelete.Click += new System.EventHandler(this.btnMassDelete_Click);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancel.Location = new System.Drawing.Point(1039, 92);
            this.btnUserCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(181, 49);
            this.btnUserCancel.TabIndex = 14;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Visible = false;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSave.Location = new System.Drawing.Point(1039, 36);
            this.btnUserSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(181, 49);
            this.btnUserSave.TabIndex = 13;
            this.btnUserSave.Text = "Save User";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Visible = false;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserUpload
            // 
            this.btnUserUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserUpload.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserUpload.Location = new System.Drawing.Point(751, 36);
            this.btnUserUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserUpload.Name = "btnUserUpload";
            this.btnUserUpload.Size = new System.Drawing.Size(280, 49);
            this.btnUserUpload.TabIndex = 8;
            this.btnUserUpload.Text = "Mass Upload Students";
            this.btnUserUpload.UseVisualStyleBackColor = true;
            this.btnUserUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 122;
            this.label9.Text = "Phone:";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Enabled = false;
            this.txtUserPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhone.Location = new System.Drawing.Point(444, 279);
            this.txtUserPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPhone.MaxLength = 10;
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.ShortcutsEnabled = false;
            this.txtUserPhone.Size = new System.Drawing.Size(297, 26);
            this.txtUserPhone.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(440, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 120;
            this.label10.Text = "Email:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Enabled = false;
            this.txtUserEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(444, 225);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserEmail.MaxLength = 25;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.ShortcutsEnabled = false;
            this.txtUserEmail.Size = new System.Drawing.Size(297, 26);
            this.txtUserEmail.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 118;
            this.label8.Text = "SVSU ID:";
            // 
            // txtUserSVSUID
            // 
            this.txtUserSVSUID.Enabled = false;
            this.txtUserSVSUID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSVSUID.Location = new System.Drawing.Point(444, 59);
            this.txtUserSVSUID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserSVSUID.Name = "txtUserSVSUID";
            this.txtUserSVSUID.ShortcutsEnabled = false;
            this.txtUserSVSUID.Size = new System.Drawing.Size(297, 26);
            this.txtUserSVSUID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 116;
            this.label7.Text = "Last Name:";
            // 
            // txtUserLName
            // 
            this.txtUserLName.Enabled = false;
            this.txtUserLName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLName.Location = new System.Drawing.Point(444, 169);
            this.txtUserLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserLName.MaxLength = 40;
            this.txtUserLName.Name = "txtUserLName";
            this.txtUserLName.ShortcutsEnabled = false;
            this.txtUserLName.Size = new System.Drawing.Size(297, 26);
            this.txtUserLName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 114;
            this.label6.Text = "First Name:";
            // 
            // chkUserAdmin
            // 
            this.chkUserAdmin.AutoSize = true;
            this.chkUserAdmin.Enabled = false;
            this.chkUserAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserAdmin.Location = new System.Drawing.Point(444, 314);
            this.chkUserAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.chkUserAdmin.Name = "chkUserAdmin";
            this.chkUserAdmin.Size = new System.Drawing.Size(90, 23);
            this.chkUserAdmin.TabIndex = 7;
            this.chkUserAdmin.Text = "Admin?";
            this.chkUserAdmin.UseVisualStyleBackColor = true;
            this.chkUserAdmin.CheckedChanged += new System.EventHandler(this.chkUserAdmin_CheckedChanged);
            this.chkUserAdmin.Click += new System.EventHandler(this.chkUserAdmin_Click);
            // 
            // btnUserModify
            // 
            this.btnUserModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserModify.Location = new System.Drawing.Point(751, 149);
            this.btnUserModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserModify.Name = "btnUserModify";
            this.btnUserModify.Size = new System.Drawing.Size(280, 49);
            this.btnUserModify.TabIndex = 10;
            this.btnUserModify.Text = "Modify User";
            this.btnUserModify.UseVisualStyleBackColor = true;
            this.btnUserModify.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // txtUserFName
            // 
            this.txtUserFName.Enabled = false;
            this.txtUserFName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFName.Location = new System.Drawing.Point(444, 113);
            this.txtUserFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserFName.MaxLength = 25;
            this.txtUserFName.Name = "txtUserFName";
            this.txtUserFName.ShortcutsEnabled = false;
            this.txtUserFName.Size = new System.Drawing.Size(297, 26);
            this.txtUserFName.TabIndex = 3;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(751, 206);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(280, 49);
            this.btnUserDelete.TabIndex = 12;
            this.btnUserDelete.Text = "Delete User";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.Location = new System.Drawing.Point(751, 92);
            this.btnUserAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(280, 49);
            this.btnUserAdd.TabIndex = 9;
            this.btnUserAdd.Text = "Add User";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lstUser
            // 
            this.lstUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 18;
            this.lstUser.Location = new System.Drawing.Point(13, 36);
            this.lstUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(419, 400);
            this.lstUser.TabIndex = 1;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 102;
            this.label3.Text = "User";
            // 
            // tbpRooms
            // 
            this.tbpRooms.Controls.Add(this.btnRoomCancel);
            this.tbpRooms.Controls.Add(this.btnRoomSave);
            this.tbpRooms.Controls.Add(this.btnRoomModify);
            this.tbpRooms.Controls.Add(this.btnRoomAdd);
            this.tbpRooms.Controls.Add(this.label12);
            this.tbpRooms.Controls.Add(this.txtRoomDescription);
            this.tbpRooms.Controls.Add(this.label4);
            this.tbpRooms.Controls.Add(this.txtRoomName);
            this.tbpRooms.Controls.Add(this.btnRoomDelete);
            this.tbpRooms.Controls.Add(this.lstRoom);
            this.tbpRooms.Controls.Add(this.lblRoom);
            this.tbpRooms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpRooms.Location = new System.Drawing.Point(4, 27);
            this.tbpRooms.Margin = new System.Windows.Forms.Padding(4);
            this.tbpRooms.Name = "tbpRooms";
            this.tbpRooms.Padding = new System.Windows.Forms.Padding(4);
            this.tbpRooms.Size = new System.Drawing.Size(1231, 511);
            this.tbpRooms.TabIndex = 1;
            this.tbpRooms.Text = "Rooms";
            this.tbpRooms.UseVisualStyleBackColor = true;
            // 
            // btnRoomCancel
            // 
            this.btnRoomCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoomCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomCancel.Location = new System.Drawing.Point(940, 92);
            this.btnRoomCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomCancel.Name = "btnRoomCancel";
            this.btnRoomCancel.Size = new System.Drawing.Size(280, 49);
            this.btnRoomCancel.TabIndex = 8;
            this.btnRoomCancel.Text = "Cancel";
            this.btnRoomCancel.UseVisualStyleBackColor = true;
            this.btnRoomCancel.Visible = false;
            this.btnRoomCancel.Click += new System.EventHandler(this.btnRoomCancel_Click);
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoomSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSave.Location = new System.Drawing.Point(940, 36);
            this.btnRoomSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Size = new System.Drawing.Size(280, 49);
            this.btnRoomSave.TabIndex = 7;
            this.btnRoomSave.Text = "Save Room";
            this.btnRoomSave.UseVisualStyleBackColor = true;
            this.btnRoomSave.Visible = false;
            this.btnRoomSave.Click += new System.EventHandler(this.btnRoomSave_Click);
            // 
            // btnRoomModify
            // 
            this.btnRoomModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoomModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomModify.Location = new System.Drawing.Point(652, 92);
            this.btnRoomModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomModify.Name = "btnRoomModify";
            this.btnRoomModify.Size = new System.Drawing.Size(280, 49);
            this.btnRoomModify.TabIndex = 5;
            this.btnRoomModify.Text = "Modify Room";
            this.btnRoomModify.UseVisualStyleBackColor = true;
            this.btnRoomModify.Click += new System.EventHandler(this.btnModifyRoom_Click);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoomAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomAdd.Location = new System.Drawing.Point(652, 36);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(280, 49);
            this.btnRoomAdd.TabIndex = 4;
            this.btnRoomAdd.Text = "Add Room";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(301, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 19);
            this.label12.TabIndex = 104;
            this.label12.Text = "Room Description:";
            // 
            // txtRoomDescription
            // 
            this.txtRoomDescription.Enabled = false;
            this.txtRoomDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomDescription.Location = new System.Drawing.Point(300, 118);
            this.txtRoomDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomDescription.MaxLength = 255;
            this.txtRoomDescription.Multiline = true;
            this.txtRoomDescription.Name = "txtRoomDescription";
            this.txtRoomDescription.ShortcutsEnabled = false;
            this.txtRoomDescription.Size = new System.Drawing.Size(343, 238);
            this.txtRoomDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 102;
            this.label4.Text = "Room Name:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Enabled = false;
            this.txtRoomName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(300, 59);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.MaxLength = 25;
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ShortcutsEnabled = false;
            this.txtRoomName.Size = new System.Drawing.Size(343, 26);
            this.txtRoomName.TabIndex = 2;
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoomDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDelete.Location = new System.Drawing.Point(652, 149);
            this.btnRoomDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(280, 49);
            this.btnRoomDelete.TabIndex = 6;
            this.btnRoomDelete.Text = "Delete Room";
            this.btnRoomDelete.UseVisualStyleBackColor = true;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // lstRoom
            // 
            this.lstRoom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.ItemHeight = 18;
            this.lstRoom.Location = new System.Drawing.Point(13, 36);
            this.lstRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(279, 400);
            this.lstRoom.TabIndex = 1;
            this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(8, 4);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(81, 29);
            this.lblRoom.TabIndex = 85;
            this.lblRoom.Text = "Room";
            // 
            // tbpCabinets
            // 
            this.tbpCabinets.Controls.Add(this.btnCabinetCancel);
            this.tbpCabinets.Controls.Add(this.btnCabinetSave);
            this.tbpCabinets.Controls.Add(this.btnCabinetModify);
            this.tbpCabinets.Controls.Add(this.btnCabinetAdd);
            this.tbpCabinets.Controls.Add(this.label15);
            this.tbpCabinets.Controls.Add(this.txtCabinetDescription);
            this.tbpCabinets.Controls.Add(this.label16);
            this.tbpCabinets.Controls.Add(this.txtCabinetName);
            this.tbpCabinets.Controls.Add(this.btnCabinetDelete);
            this.tbpCabinets.Controls.Add(this.lstCabinet);
            this.tbpCabinets.Controls.Add(this.label17);
            this.tbpCabinets.Controls.Add(this.label1);
            this.tbpCabinets.Controls.Add(this.cmbRoom);
            this.tbpCabinets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCabinets.Location = new System.Drawing.Point(4, 27);
            this.tbpCabinets.Margin = new System.Windows.Forms.Padding(4);
            this.tbpCabinets.Name = "tbpCabinets";
            this.tbpCabinets.Size = new System.Drawing.Size(1231, 511);
            this.tbpCabinets.TabIndex = 2;
            this.tbpCabinets.Text = "Cabinets";
            this.tbpCabinets.UseVisualStyleBackColor = true;
            // 
            // btnCabinetCancel
            // 
            this.btnCabinetCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCabinetCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetCancel.Location = new System.Drawing.Point(940, 92);
            this.btnCabinetCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCabinetCancel.Name = "btnCabinetCancel";
            this.btnCabinetCancel.Size = new System.Drawing.Size(280, 49);
            this.btnCabinetCancel.TabIndex = 9;
            this.btnCabinetCancel.Text = "Cancel";
            this.btnCabinetCancel.UseVisualStyleBackColor = true;
            this.btnCabinetCancel.Visible = false;
            this.btnCabinetCancel.Click += new System.EventHandler(this.btnCabinetCancel_Click);
            // 
            // btnCabinetSave
            // 
            this.btnCabinetSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCabinetSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetSave.Location = new System.Drawing.Point(940, 36);
            this.btnCabinetSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCabinetSave.Name = "btnCabinetSave";
            this.btnCabinetSave.Size = new System.Drawing.Size(280, 49);
            this.btnCabinetSave.TabIndex = 8;
            this.btnCabinetSave.Text = "Save Cabinet";
            this.btnCabinetSave.UseVisualStyleBackColor = true;
            this.btnCabinetSave.Visible = false;
            this.btnCabinetSave.Click += new System.EventHandler(this.btnCabinetSave_Click);
            // 
            // btnCabinetModify
            // 
            this.btnCabinetModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCabinetModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetModify.Location = new System.Drawing.Point(652, 92);
            this.btnCabinetModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnCabinetModify.Name = "btnCabinetModify";
            this.btnCabinetModify.Size = new System.Drawing.Size(280, 49);
            this.btnCabinetModify.TabIndex = 6;
            this.btnCabinetModify.Text = "Modify Cabinet";
            this.btnCabinetModify.UseVisualStyleBackColor = true;
            this.btnCabinetModify.Click += new System.EventHandler(this.btnModifyCabinet_Click);
            // 
            // btnCabinetAdd
            // 
            this.btnCabinetAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCabinetAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetAdd.Location = new System.Drawing.Point(652, 36);
            this.btnCabinetAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCabinetAdd.Name = "btnCabinetAdd";
            this.btnCabinetAdd.Size = new System.Drawing.Size(280, 49);
            this.btnCabinetAdd.TabIndex = 5;
            this.btnCabinetAdd.Text = "Add Cabinet";
            this.btnCabinetAdd.UseVisualStyleBackColor = true;
            this.btnCabinetAdd.Click += new System.EventHandler(this.btnAddCabinet_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(301, 124);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 19);
            this.label15.TabIndex = 123;
            this.label15.Text = "Cabinet Description:";
            // 
            // txtCabinetDescription
            // 
            this.txtCabinetDescription.Enabled = false;
            this.txtCabinetDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinetDescription.Location = new System.Drawing.Point(300, 148);
            this.txtCabinetDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCabinetDescription.MaxLength = 255;
            this.txtCabinetDescription.Multiline = true;
            this.txtCabinetDescription.Name = "txtCabinetDescription";
            this.txtCabinetDescription.ShortcutsEnabled = false;
            this.txtCabinetDescription.Size = new System.Drawing.Size(341, 242);
            this.txtCabinetDescription.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(300, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 19);
            this.label16.TabIndex = 121;
            this.label16.Text = "Cabinet Name:";
            // 
            // txtCabinetName
            // 
            this.txtCabinetName.Enabled = false;
            this.txtCabinetName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinetName.Location = new System.Drawing.Point(300, 90);
            this.txtCabinetName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCabinetName.MaxLength = 25;
            this.txtCabinetName.Name = "txtCabinetName";
            this.txtCabinetName.ShortcutsEnabled = false;
            this.txtCabinetName.Size = new System.Drawing.Size(343, 26);
            this.txtCabinetName.TabIndex = 3;
            // 
            // btnCabinetDelete
            // 
            this.btnCabinetDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCabinetDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetDelete.Location = new System.Drawing.Point(652, 149);
            this.btnCabinetDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCabinetDelete.Name = "btnCabinetDelete";
            this.btnCabinetDelete.Size = new System.Drawing.Size(280, 49);
            this.btnCabinetDelete.TabIndex = 7;
            this.btnCabinetDelete.Text = "Delete Cabinet";
            this.btnCabinetDelete.UseVisualStyleBackColor = true;
            this.btnCabinetDelete.Click += new System.EventHandler(this.btnDeleteCabinet_Click);
            // 
            // lstCabinet
            // 
            this.lstCabinet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCabinet.FormattingEnabled = true;
            this.lstCabinet.ItemHeight = 18;
            this.lstCabinet.Location = new System.Drawing.Point(13, 33);
            this.lstCabinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCabinet.Name = "lstCabinet";
            this.lstCabinet.Size = new System.Drawing.Size(279, 400);
            this.lstCabinet.TabIndex = 1;
            this.lstCabinet.SelectedIndexChanged += new System.EventHandler(this.lstCabinet_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 29);
            this.label17.TabIndex = 117;
            this.label17.Text = "Cabinet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "Room:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(300, 33);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(343, 26);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // tbpCategories
            // 
            this.tbpCategories.Controls.Add(this.btnCategoryCancel);
            this.tbpCategories.Controls.Add(this.btnCategorySave);
            this.tbpCategories.Controls.Add(this.btnCategoryModify);
            this.tbpCategories.Controls.Add(this.btnCategoryAdd);
            this.tbpCategories.Controls.Add(this.label19);
            this.tbpCategories.Controls.Add(this.txtCategoryDescription);
            this.tbpCategories.Controls.Add(this.label20);
            this.tbpCategories.Controls.Add(this.txtCategoryName);
            this.tbpCategories.Controls.Add(this.btnCategoryDelete);
            this.tbpCategories.Controls.Add(this.lstCategory);
            this.tbpCategories.Controls.Add(this.label21);
            this.tbpCategories.Location = new System.Drawing.Point(4, 27);
            this.tbpCategories.Margin = new System.Windows.Forms.Padding(4);
            this.tbpCategories.Name = "tbpCategories";
            this.tbpCategories.Size = new System.Drawing.Size(1231, 511);
            this.tbpCategories.TabIndex = 3;
            this.tbpCategories.Text = "Categories";
            this.tbpCategories.UseVisualStyleBackColor = true;
            // 
            // btnCategoryCancel
            // 
            this.btnCategoryCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryCancel.Location = new System.Drawing.Point(940, 92);
            this.btnCategoryCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryCancel.Name = "btnCategoryCancel";
            this.btnCategoryCancel.Size = new System.Drawing.Size(280, 49);
            this.btnCategoryCancel.TabIndex = 8;
            this.btnCategoryCancel.Text = "Cancel";
            this.btnCategoryCancel.UseVisualStyleBackColor = true;
            this.btnCategoryCancel.Visible = false;
            this.btnCategoryCancel.Click += new System.EventHandler(this.btnCategoryCancel_Click);
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategorySave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorySave.Location = new System.Drawing.Point(940, 36);
            this.btnCategorySave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(280, 49);
            this.btnCategorySave.TabIndex = 7;
            this.btnCategorySave.Text = "Save Category";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Visible = false;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnCategoryModify
            // 
            this.btnCategoryModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryModify.Location = new System.Drawing.Point(652, 92);
            this.btnCategoryModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryModify.Name = "btnCategoryModify";
            this.btnCategoryModify.Size = new System.Drawing.Size(280, 49);
            this.btnCategoryModify.TabIndex = 5;
            this.btnCategoryModify.Text = "Modify Category";
            this.btnCategoryModify.UseVisualStyleBackColor = true;
            this.btnCategoryModify.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryAdd.Location = new System.Drawing.Point(652, 36);
            this.btnCategoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(280, 49);
            this.btnCategoryAdd.TabIndex = 4;
            this.btnCategoryAdd.Text = "Add Category";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(300, 94);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(182, 19);
            this.label19.TabIndex = 123;
            this.label19.Text = "Category Description:";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Enabled = false;
            this.txtCategoryDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(300, 117);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryDescription.MaxLength = 255;
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.ShortcutsEnabled = false;
            this.txtCategoryDescription.Size = new System.Drawing.Size(343, 239);
            this.txtCategoryDescription.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(300, 36);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 19);
            this.label20.TabIndex = 121;
            this.label20.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Enabled = false;
            this.txtCategoryName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(300, 59);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.MaxLength = 25;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ShortcutsEnabled = false;
            this.txtCategoryName.Size = new System.Drawing.Size(343, 26);
            this.txtCategoryName.TabIndex = 2;
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryDelete.Location = new System.Drawing.Point(652, 149);
            this.btnCategoryDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(280, 49);
            this.btnCategoryDelete.TabIndex = 6;
            this.btnCategoryDelete.Text = "Delete Category";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lstCategory
            // 
            this.lstCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 18;
            this.lstCategory.Location = new System.Drawing.Point(13, 36);
            this.lstCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(279, 400);
            this.lstCategory.TabIndex = 1;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 4);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 29);
            this.label21.TabIndex = 117;
            this.label21.Text = "Category";
            // 
            // tbpVendors
            // 
            this.tbpVendors.Controls.Add(this.btnVendorCancel);
            this.tbpVendors.Controls.Add(this.btnVendorSave);
            this.tbpVendors.Controls.Add(this.label2);
            this.tbpVendors.Controls.Add(this.txtVendorHomepage);
            this.tbpVendors.Controls.Add(this.btnVendorModify);
            this.tbpVendors.Controls.Add(this.btnVendorAdd);
            this.tbpVendors.Controls.Add(this.label22);
            this.tbpVendors.Controls.Add(this.txtVendorDescription);
            this.tbpVendors.Controls.Add(this.label23);
            this.tbpVendors.Controls.Add(this.txtVendorName);
            this.tbpVendors.Controls.Add(this.btnVendorDelete);
            this.tbpVendors.Controls.Add(this.lstVendor);
            this.tbpVendors.Controls.Add(this.label24);
            this.tbpVendors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpVendors.Location = new System.Drawing.Point(4, 27);
            this.tbpVendors.Margin = new System.Windows.Forms.Padding(4);
            this.tbpVendors.Name = "tbpVendors";
            this.tbpVendors.Size = new System.Drawing.Size(1231, 511);
            this.tbpVendors.TabIndex = 4;
            this.tbpVendors.Text = "Vendors";
            this.tbpVendors.UseVisualStyleBackColor = true;
            // 
            // btnVendorCancel
            // 
            this.btnVendorCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendorCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorCancel.Location = new System.Drawing.Point(940, 92);
            this.btnVendorCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorCancel.Name = "btnVendorCancel";
            this.btnVendorCancel.Size = new System.Drawing.Size(280, 49);
            this.btnVendorCancel.TabIndex = 9;
            this.btnVendorCancel.Text = "Cancel";
            this.btnVendorCancel.UseVisualStyleBackColor = true;
            this.btnVendorCancel.Visible = false;
            this.btnVendorCancel.Click += new System.EventHandler(this.btnVendorCancel_Click);
            // 
            // btnVendorSave
            // 
            this.btnVendorSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendorSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorSave.Location = new System.Drawing.Point(940, 36);
            this.btnVendorSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorSave.Name = "btnVendorSave";
            this.btnVendorSave.Size = new System.Drawing.Size(280, 49);
            this.btnVendorSave.TabIndex = 8;
            this.btnVendorSave.Text = "Save Vendor";
            this.btnVendorSave.UseVisualStyleBackColor = true;
            this.btnVendorSave.Visible = false;
            this.btnVendorSave.Click += new System.EventHandler(this.btnVendorSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 136;
            this.label2.Text = "Homepage:";
            // 
            // txtVendorHomepage
            // 
            this.txtVendorHomepage.Enabled = false;
            this.txtVendorHomepage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorHomepage.Location = new System.Drawing.Point(300, 117);
            this.txtVendorHomepage.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendorHomepage.MaxLength = 150;
            this.txtVendorHomepage.Name = "txtVendorHomepage";
            this.txtVendorHomepage.ShortcutsEnabled = false;
            this.txtVendorHomepage.Size = new System.Drawing.Size(343, 26);
            this.txtVendorHomepage.TabIndex = 3;
            // 
            // btnVendorModify
            // 
            this.btnVendorModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendorModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorModify.Location = new System.Drawing.Point(652, 92);
            this.btnVendorModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorModify.Name = "btnVendorModify";
            this.btnVendorModify.Size = new System.Drawing.Size(280, 49);
            this.btnVendorModify.TabIndex = 6;
            this.btnVendorModify.Text = "Modify Vendor";
            this.btnVendorModify.UseVisualStyleBackColor = true;
            this.btnVendorModify.Click += new System.EventHandler(this.btnModifyVendor_Click);
            // 
            // btnVendorAdd
            // 
            this.btnVendorAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendorAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorAdd.Location = new System.Drawing.Point(652, 36);
            this.btnVendorAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorAdd.Name = "btnVendorAdd";
            this.btnVendorAdd.Size = new System.Drawing.Size(280, 49);
            this.btnVendorAdd.TabIndex = 5;
            this.btnVendorAdd.Text = "Add Vendor";
            this.btnVendorAdd.UseVisualStyleBackColor = true;
            this.btnVendorAdd.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(300, 153);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 19);
            this.label22.TabIndex = 134;
            this.label22.Text = "Vendor Description:";
            // 
            // txtVendorDescription
            // 
            this.txtVendorDescription.Enabled = false;
            this.txtVendorDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorDescription.Location = new System.Drawing.Point(300, 176);
            this.txtVendorDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendorDescription.MaxLength = 255;
            this.txtVendorDescription.Multiline = true;
            this.txtVendorDescription.Name = "txtVendorDescription";
            this.txtVendorDescription.ShortcutsEnabled = false;
            this.txtVendorDescription.Size = new System.Drawing.Size(343, 234);
            this.txtVendorDescription.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(300, 36);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 19);
            this.label23.TabIndex = 132;
            this.label23.Text = "Vendor Name:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Enabled = false;
            this.txtVendorName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.Location = new System.Drawing.Point(300, 59);
            this.txtVendorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendorName.MaxLength = 40;
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(344, 26);
            this.txtVendorName.TabIndex = 2;
            // 
            // btnVendorDelete
            // 
            this.btnVendorDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendorDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorDelete.Location = new System.Drawing.Point(652, 149);
            this.btnVendorDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendorDelete.Name = "btnVendorDelete";
            this.btnVendorDelete.Size = new System.Drawing.Size(280, 49);
            this.btnVendorDelete.TabIndex = 7;
            this.btnVendorDelete.Text = "Delete Vendor";
            this.btnVendorDelete.UseVisualStyleBackColor = true;
            this.btnVendorDelete.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // lstVendor
            // 
            this.lstVendor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVendor.FormattingEnabled = true;
            this.lstVendor.ItemHeight = 18;
            this.lstVendor.Location = new System.Drawing.Point(13, 36);
            this.lstVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Size = new System.Drawing.Size(279, 400);
            this.lstVendor.TabIndex = 1;
            this.lstVendor.SelectedIndexChanged += new System.EventHandler(this.lstVendor_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 4);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 29);
            this.label24.TabIndex = 128;
            this.label24.Text = "Vendor";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 567);
            this.Controls.Add(this.tbcSettings);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tbpUsers;
        private System.Windows.Forms.TabPage tbpRooms;
        private System.Windows.Forms.TabPage tbpCabinets;
        private System.Windows.Forms.TabPage tbpCategories;
        private System.Windows.Forms.TabPage tbpVendors;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.ListBox lstRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtUserFName;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUserModify;
        private System.Windows.Forms.CheckBox chkUserAdmin;
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
        private System.Windows.Forms.Button btnRoomModify;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnCabinetModify;
        private System.Windows.Forms.Button btnCabinetAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCabinetDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCabinetName;
        private System.Windows.Forms.Button btnCabinetDelete;
        private System.Windows.Forms.ListBox lstCabinet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCategoryModify;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnVendorModify;
        private System.Windows.Forms.Button btnVendorAdd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtVendorDescription;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Button btnVendorDelete;
        private System.Windows.Forms.ListBox lstVendor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendorHomepage;
        private System.Windows.Forms.Button btnUserUpload;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Button btnRoomCancel;
        private System.Windows.Forms.Button btnRoomSave;
        private System.Windows.Forms.Button btnCabinetCancel;
        private System.Windows.Forms.Button btnCabinetSave;
        private System.Windows.Forms.Button btnCategoryCancel;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button btnVendorCancel;
        private System.Windows.Forms.Button btnVendorSave;
        private System.Windows.Forms.Button btnMassDelete;
    }
}
