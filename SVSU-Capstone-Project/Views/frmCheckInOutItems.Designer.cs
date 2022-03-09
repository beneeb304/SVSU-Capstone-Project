
namespace SVSU_Capstone_Project.Views
{
    partial class frmCheckInOutItems
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
            this.tbpCheckIn = new System.Windows.Forms.TabPage();
            this.lblTesting = new System.Windows.Forms.Label();
            this.cmbChkInStudent = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbChkInCategory = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChkIn = new System.Windows.Forms.Button();
            this.cmbChkInCommodity = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbpCheckOut = new System.Windows.Forms.TabPage();
            this.cmbChkOutStudent = new System.Windows.Forms.ComboBox();
            this.txtChkOutNotes = new System.Windows.Forms.RichTextBox();
            this.txtAvailableChkOutQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbChkOutCategory = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnChkOutCancel = new System.Windows.Forms.Button();
            this.btnChkOut = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbChkOutCommodity = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbpAssets = new System.Windows.Forms.TabPage();
            this.cmbAssetCategory = new System.Windows.Forms.ComboBox();
            this.cmbAssetsStudents = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtAssetNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCheckedOut = new System.Windows.Forms.ListBox();
            this.lstCheckedIn = new System.Windows.Forms.ListBox();
            this.lblSvsuIdCI = new System.Windows.Forms.Label();
            this.tbcCheckInOut = new System.Windows.Forms.TabControl();
            this.tbpCheckIn.SuspendLayout();
            this.tbpCheckOut.SuspendLayout();
            this.tbpAssets.SuspendLayout();
            this.tbcCheckInOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpCheckIn
            // 
            this.tbpCheckIn.Controls.Add(this.lblTesting);
            this.tbpCheckIn.Controls.Add(this.cmbChkInStudent);
            this.tbpCheckIn.Controls.Add(this.label22);
            this.tbpCheckIn.Controls.Add(this.label23);
            this.tbpCheckIn.Controls.Add(this.cmbChkInCategory);
            this.tbpCheckIn.Controls.Add(this.label24);
            this.tbpCheckIn.Controls.Add(this.button1);
            this.tbpCheckIn.Controls.Add(this.btnChkIn);
            this.tbpCheckIn.Controls.Add(this.cmbChkInCommodity);
            this.tbpCheckIn.Controls.Add(this.label27);
            this.tbpCheckIn.Location = new System.Drawing.Point(4, 27);
            this.tbpCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCheckIn.Name = "tbpCheckIn";
            this.tbpCheckIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCheckIn.Size = new System.Drawing.Size(1233, 499);
            this.tbpCheckIn.TabIndex = 3;
            this.tbpCheckIn.Text = "Check In";
            this.tbpCheckIn.UseVisualStyleBackColor = true;
            // 
            // lblTesting
            // 
            this.lblTesting.AutoSize = true;
            this.lblTesting.Location = new System.Drawing.Point(843, 91);
            this.lblTesting.Name = "lblTesting";
            this.lblTesting.Size = new System.Drawing.Size(60, 19);
            this.lblTesting.TabIndex = 215;
            this.lblTesting.Text = "label18";
            // 
            // cmbChkInStudent
            // 
            this.cmbChkInStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkInStudent.FormattingEnabled = true;
            this.cmbChkInStudent.Location = new System.Drawing.Point(177, 135);
            this.cmbChkInStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChkInStudent.Name = "cmbChkInStudent";
            this.cmbChkInStudent.Size = new System.Drawing.Size(297, 31);
            this.cmbChkInStudent.TabIndex = 214;
            this.cmbChkInStudent.SelectedIndexChanged += new System.EventHandler(this.cmbChkInStudent_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(35, 142);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 24);
            this.label22.TabIndex = 211;
            this.label22.Text = "Student:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(16, 17);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(239, 29);
            this.label23.TabIndex = 210;
            this.label23.Text = "Check In Asset Item";
            // 
            // cmbChkInCategory
            // 
            this.cmbChkInCategory.Enabled = false;
            this.cmbChkInCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkInCategory.FormattingEnabled = true;
            this.cmbChkInCategory.Location = new System.Drawing.Point(177, 64);
            this.cmbChkInCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChkInCategory.Name = "cmbChkInCategory";
            this.cmbChkInCategory.Size = new System.Drawing.Size(297, 31);
            this.cmbChkInCategory.TabIndex = 200;
            this.cmbChkInCategory.SelectedIndexChanged += new System.EventHandler(this.cmbChkInCategory_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(35, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 24);
            this.label24.TabIndex = 209;
            this.label24.Text = "Category:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 53);
            this.button1.TabIndex = 204;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnChkIn
            // 
            this.btnChkIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkIn.Location = new System.Drawing.Point(37, 321);
            this.btnChkIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnChkIn.Name = "btnChkIn";
            this.btnChkIn.Size = new System.Drawing.Size(152, 53);
            this.btnChkIn.TabIndex = 205;
            this.btnChkIn.Text = "Check In";
            this.btnChkIn.UseVisualStyleBackColor = true;
            this.btnChkIn.Click += new System.EventHandler(this.btnChkIn_Click);
            // 
            // cmbChkInCommodity
            // 
            this.cmbChkInCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkInCommodity.FormattingEnabled = true;
            this.cmbChkInCommodity.Location = new System.Drawing.Point(177, 210);
            this.cmbChkInCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChkInCommodity.Name = "cmbChkInCommodity";
            this.cmbChkInCommodity.Size = new System.Drawing.Size(297, 31);
            this.cmbChkInCommodity.TabIndex = 201;
            this.cmbChkInCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbChkInCommodity_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(35, 218);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 24);
            this.label27.TabIndex = 206;
            this.label27.Text = "Commodity:";
            // 
            // tbpCheckOut
            // 
            this.tbpCheckOut.Controls.Add(this.cmbChkOutStudent);
            this.tbpCheckOut.Controls.Add(this.txtChkOutNotes);
            this.tbpCheckOut.Controls.Add(this.txtAvailableChkOutQuantity);
            this.tbpCheckOut.Controls.Add(this.label14);
            this.tbpCheckOut.Controls.Add(this.label15);
            this.tbpCheckOut.Controls.Add(this.label16);
            this.tbpCheckOut.Controls.Add(this.cmbChkOutCategory);
            this.tbpCheckOut.Controls.Add(this.label17);
            this.tbpCheckOut.Controls.Add(this.btnChkOutCancel);
            this.tbpCheckOut.Controls.Add(this.btnChkOut);
            this.tbpCheckOut.Controls.Add(this.label20);
            this.tbpCheckOut.Controls.Add(this.cmbChkOutCommodity);
            this.tbpCheckOut.Controls.Add(this.label21);
            this.tbpCheckOut.Location = new System.Drawing.Point(4, 27);
            this.tbpCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCheckOut.Name = "tbpCheckOut";
            this.tbpCheckOut.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCheckOut.Size = new System.Drawing.Size(1233, 499);
            this.tbpCheckOut.TabIndex = 2;
            this.tbpCheckOut.Text = "Check Out";
            this.tbpCheckOut.UseVisualStyleBackColor = true;
            // 
            // cmbChkOutStudent
            // 
            this.cmbChkOutStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChkOutStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkOutStudent.FormattingEnabled = true;
            this.cmbChkOutStudent.Location = new System.Drawing.Point(805, 81);
            this.cmbChkOutStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChkOutStudent.Name = "cmbChkOutStudent";
            this.cmbChkOutStudent.Size = new System.Drawing.Size(337, 31);
            this.cmbChkOutStudent.TabIndex = 199;
            // 
            // txtChkOutNotes
            // 
            this.txtChkOutNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChkOutNotes.Location = new System.Drawing.Point(805, 154);
            this.txtChkOutNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtChkOutNotes.Name = "txtChkOutNotes";
            this.txtChkOutNotes.Size = new System.Drawing.Size(337, 227);
            this.txtChkOutNotes.TabIndex = 197;
            this.txtChkOutNotes.Text = "";
            // 
            // txtAvailableChkOutQuantity
            // 
            this.txtAvailableChkOutQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableChkOutQuantity.Location = new System.Drawing.Point(295, 210);
            this.txtAvailableChkOutQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvailableChkOutQuantity.Name = "txtAvailableChkOutQuantity";
            this.txtAvailableChkOutQuantity.ReadOnly = true;
            this.txtAvailableChkOutQuantity.Size = new System.Drawing.Size(159, 30);
            this.txtAvailableChkOutQuantity.TabIndex = 184;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(691, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 198;
            this.label14.Text = "Notes:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(691, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 24);
            this.label15.TabIndex = 196;
            this.label15.Text = "Student:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 17);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 29);
            this.label16.TabIndex = 195;
            this.label16.Text = "Check Out Asset Item";
            // 
            // cmbChkOutCategory
            // 
            this.cmbChkOutCategory.Enabled = false;
            this.cmbChkOutCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkOutCategory.FormattingEnabled = true;
            this.cmbChkOutCategory.Location = new System.Drawing.Point(220, 74);
            this.cmbChkOutCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChkOutCategory.Name = "cmbChkOutCategory";
            this.cmbChkOutCategory.Size = new System.Drawing.Size(297, 31);
            this.cmbChkOutCategory.TabIndex = 178;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(77, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 24);
            this.label17.TabIndex = 194;
            this.label17.Text = "Category:";
            // 
            // btnChkOutCancel
            // 
            this.btnChkOutCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkOutCancel.Location = new System.Drawing.Point(991, 410);
            this.btnChkOutCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnChkOutCancel.Name = "btnChkOutCancel";
            this.btnChkOutCancel.Size = new System.Drawing.Size(152, 53);
            this.btnChkOutCancel.TabIndex = 186;
            this.btnChkOutCancel.Text = "Cancel";
            this.btnChkOutCancel.UseVisualStyleBackColor = true;
            this.btnChkOutCancel.Click += new System.EventHandler(this.btnChkOutCancel_Click);
            // 
            // btnChkOut
            // 
            this.btnChkOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkOut.Location = new System.Drawing.Point(805, 410);
            this.btnChkOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnChkOut.Name = "btnChkOut";
            this.btnChkOut.Size = new System.Drawing.Size(152, 53);
            this.btnChkOut.TabIndex = 187;
            this.btnChkOut.Text = "Check Out";
            this.btnChkOut.UseVisualStyleBackColor = true;
            this.btnChkOut.Click += new System.EventHandler(this.btnChkOut_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(77, 214);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(187, 24);
            this.label20.TabIndex = 192;
            this.label20.Text = "Available Quantity:";
            // 
            // cmbChkOutCommodity
            // 
            this.cmbChkOutCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChkOutCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkOutCommodity.FormattingEnabled = true;
            this.cmbChkOutCommodity.Location = new System.Drawing.Point(220, 126);
            this.cmbChkOutCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChkOutCommodity.Name = "cmbChkOutCommodity";
            this.cmbChkOutCommodity.Size = new System.Drawing.Size(297, 31);
            this.cmbChkOutCommodity.TabIndex = 180;
            this.cmbChkOutCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbChkOutCommodity_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(77, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 24);
            this.label21.TabIndex = 191;
            this.label21.Text = "Commodity:";
            // 
            // tbpAssets
            // 
            this.tbpAssets.Controls.Add(this.cmbAssetCategory);
            this.tbpAssets.Controls.Add(this.cmbAssetsStudents);
            this.tbpAssets.Controls.Add(this.btnCheckIn);
            this.tbpAssets.Controls.Add(this.btnCheckOut);
            this.tbpAssets.Controls.Add(this.txtAssetNotes);
            this.tbpAssets.Controls.Add(this.lblNotes);
            this.tbpAssets.Controls.Add(this.label2);
            this.tbpAssets.Controls.Add(this.label1);
            this.tbpAssets.Controls.Add(this.lstCheckedOut);
            this.tbpAssets.Controls.Add(this.lstCheckedIn);
            this.tbpAssets.Controls.Add(this.lblSvsuIdCI);
            this.tbpAssets.Location = new System.Drawing.Point(4, 27);
            this.tbpAssets.Margin = new System.Windows.Forms.Padding(4);
            this.tbpAssets.Name = "tbpAssets";
            this.tbpAssets.Padding = new System.Windows.Forms.Padding(4);
            this.tbpAssets.Size = new System.Drawing.Size(1233, 499);
            this.tbpAssets.TabIndex = 0;
            this.tbpAssets.Text = "Assets";
            this.tbpAssets.UseVisualStyleBackColor = true;
            // 
            // cmbAssetCategory
            // 
            this.cmbAssetCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetCategory.FormattingEnabled = true;
            this.cmbAssetCategory.Location = new System.Drawing.Point(796, 46);
            this.cmbAssetCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAssetCategory.Name = "cmbAssetCategory";
            this.cmbAssetCategory.Size = new System.Drawing.Size(337, 26);
            this.cmbAssetCategory.TabIndex = 137;
            this.cmbAssetCategory.Visible = false;
            // 
            // cmbAssetsStudents
            // 
            this.cmbAssetsStudents.Enabled = false;
            this.cmbAssetsStudents.FormattingEnabled = true;
            this.cmbAssetsStudents.Location = new System.Drawing.Point(796, 101);
            this.cmbAssetsStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAssetsStudents.Name = "cmbAssetsStudents";
            this.cmbAssetsStudents.Size = new System.Drawing.Size(337, 26);
            this.cmbAssetsStudents.TabIndex = 136;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(932, 430);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(132, 57);
            this.btnCheckIn.TabIndex = 134;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(1091, 430);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(132, 57);
            this.btnCheckOut.TabIndex = 135;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // txtAssetNotes
            // 
            this.txtAssetNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetNotes.Location = new System.Drawing.Point(796, 169);
            this.txtAssetNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssetNotes.Name = "txtAssetNotes";
            this.txtAssetNotes.Size = new System.Drawing.Size(337, 227);
            this.txtAssetNotes.TabIndex = 132;
            this.txtAssetNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(632, 172);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(72, 24);
            this.lblNotes.TabIndex = 133;
            this.lblNotes.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "Checked Out Assets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Checked In Assets";
            // 
            // lstCheckedOut
            // 
            this.lstCheckedOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCheckedOut.FormattingEnabled = true;
            this.lstCheckedOut.ItemHeight = 23;
            this.lstCheckedOut.Location = new System.Drawing.Point(344, 69);
            this.lstCheckedOut.Margin = new System.Windows.Forms.Padding(4);
            this.lstCheckedOut.Name = "lstCheckedOut";
            this.lstCheckedOut.Size = new System.Drawing.Size(256, 326);
            this.lstCheckedOut.TabIndex = 70;
            this.lstCheckedOut.Click += new System.EventHandler(this.ListBoxClicked);
            // 
            // lstCheckedIn
            // 
            this.lstCheckedIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCheckedIn.FormattingEnabled = true;
            this.lstCheckedIn.ItemHeight = 23;
            this.lstCheckedIn.Location = new System.Drawing.Point(48, 69);
            this.lstCheckedIn.Margin = new System.Windows.Forms.Padding(4);
            this.lstCheckedIn.Name = "lstCheckedIn";
            this.lstCheckedIn.Size = new System.Drawing.Size(256, 326);
            this.lstCheckedIn.TabIndex = 69;
            this.lstCheckedIn.Click += new System.EventHandler(this.ListBoxClicked);
            // 
            // lblSvsuIdCI
            // 
            this.lblSvsuIdCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSvsuIdCI.AutoSize = true;
            this.lblSvsuIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvsuIdCI.Location = new System.Drawing.Point(632, 102);
            this.lblSvsuIdCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSvsuIdCI.Name = "lblSvsuIdCI";
            this.lblSvsuIdCI.Size = new System.Drawing.Size(91, 24);
            this.lblSvsuIdCI.TabIndex = 62;
            this.lblSvsuIdCI.Text = "Student:";
            // 
            // tbcCheckInOut
            // 
            this.tbcCheckInOut.Controls.Add(this.tbpAssets);
            this.tbcCheckInOut.Controls.Add(this.tbpCheckOut);
            this.tbcCheckInOut.Controls.Add(this.tbpCheckIn);
            this.tbcCheckInOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCheckInOut.Location = new System.Drawing.Point(16, 14);
            this.tbcCheckInOut.Margin = new System.Windows.Forms.Padding(4);
            this.tbcCheckInOut.Name = "tbcCheckInOut";
            this.tbcCheckInOut.SelectedIndex = 0;
            this.tbcCheckInOut.Size = new System.Drawing.Size(1241, 530);
            this.tbcCheckInOut.TabIndex = 43;
            this.tbcCheckInOut.SelectedIndexChanged += new System.EventHandler(this.tbcCheckInOut_SelectedIndexChanged);
            // 
            // frmCheckInOutItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 558);
            this.Controls.Add(this.tbcCheckInOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheckInOutItems";
            this.Text = "Check-In/Out Items";
            this.Load += new System.EventHandler(this.frmCheckInOutItems_Load);
            this.tbpCheckIn.ResumeLayout(false);
            this.tbpCheckIn.PerformLayout();
            this.tbpCheckOut.ResumeLayout(false);
            this.tbpCheckOut.PerformLayout();
            this.tbpAssets.ResumeLayout(false);
            this.tbpAssets.PerformLayout();
            this.tbcCheckInOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpCheckIn;
        private System.Windows.Forms.Label lblTesting;
        internal System.Windows.Forms.ComboBox cmbChkInStudent;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        internal System.Windows.Forms.ComboBox cmbChkInCategory;
        internal System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChkIn;
        internal System.Windows.Forms.ComboBox cmbChkInCommodity;
        internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tbpCheckOut;
        internal System.Windows.Forms.ComboBox cmbChkOutStudent;
        internal System.Windows.Forms.RichTextBox txtChkOutNotes;
        private System.Windows.Forms.TextBox txtAvailableChkOutQuantity;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.ComboBox cmbChkOutCategory;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnChkOutCancel;
        private System.Windows.Forms.Button btnChkOut;
        private System.Windows.Forms.Label label20;
        internal System.Windows.Forms.ComboBox cmbChkOutCommodity;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tbpAssets;
        private System.Windows.Forms.ComboBox cmbAssetCategory;
        private System.Windows.Forms.ComboBox cmbAssetsStudents;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        internal System.Windows.Forms.RichTextBox txtAssetNotes;
        internal System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCheckedOut;
        private System.Windows.Forms.ListBox lstCheckedIn;
        private System.Windows.Forms.Label lblSvsuIdCI;
        private System.Windows.Forms.TabControl tbcCheckInOut;
    }
}
