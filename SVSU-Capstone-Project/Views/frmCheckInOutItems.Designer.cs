
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
            this.tbcCheckInOut = new System.Windows.Forms.TabControl();
            this.tbpAssets = new System.Windows.Forms.TabPage();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtAssetNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCheckedOut = new System.Windows.Forms.ListBox();
            this.lstCheckedIn = new System.Windows.Forms.ListBox();
            this.lblSvsuIdCI = new System.Windows.Forms.Label();
            this.tbpConsumables = new System.Windows.Forms.TabPage();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.txtConsumableNotes = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHandOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAddQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.cmbCommodity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCabinet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAssetsStudents = new System.Windows.Forms.ComboBox();
            this.cmbAssetCategory = new System.Windows.Forms.ComboBox();
            this.tbcCheckInOut.SuspendLayout();
            this.tbpAssets.SuspendLayout();
            this.tbpConsumables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCheckInOut
            // 
            this.tbcCheckInOut.Controls.Add(this.tbpAssets);
            this.tbcCheckInOut.Controls.Add(this.tbpConsumables);
            this.tbcCheckInOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCheckInOut.Location = new System.Drawing.Point(16, 15);
            this.tbcCheckInOut.Margin = new System.Windows.Forms.Padding(4);
            this.tbcCheckInOut.Name = "tbcCheckInOut";
            this.tbcCheckInOut.SelectedIndex = 0;
            this.tbcCheckInOut.Size = new System.Drawing.Size(1241, 528);
            this.tbcCheckInOut.TabIndex = 43;
            this.tbcCheckInOut.SelectedIndexChanged += new System.EventHandler(this.tbcCheckInOut_SelectedIndexChanged);
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
            this.tbpAssets.Size = new System.Drawing.Size(1233, 497);
            this.tbpAssets.TabIndex = 0;
            this.tbpAssets.Text = "Assets";
            this.tbpAssets.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(932, 428);
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
            this.btnCheckOut.Location = new System.Drawing.Point(1091, 428);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(132, 57);
            this.btnCheckOut.TabIndex = 135;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
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
            this.lstCheckedOut.Size = new System.Drawing.Size(256, 372);
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
            this.lstCheckedIn.Size = new System.Drawing.Size(256, 372);
            this.lstCheckedIn.TabIndex = 69;
            this.lstCheckedIn.Click += new System.EventHandler(this.ListBoxClicked);
            this.lstCheckedIn.SelectedIndexChanged += new System.EventHandler(this.lstCheckedIn_SelectedIndexChanged);
            // 
            // lblSvsuIdCI
            // 
            this.lblSvsuIdCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSvsuIdCI.AutoSize = true;
            this.lblSvsuIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvsuIdCI.Location = new System.Drawing.Point(632, 101);
            this.lblSvsuIdCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSvsuIdCI.Name = "lblSvsuIdCI";
            this.lblSvsuIdCI.Size = new System.Drawing.Size(91, 24);
            this.lblSvsuIdCI.TabIndex = 62;
            this.lblSvsuIdCI.Text = "Student:";
            // 
            // tbpConsumables
            // 
            this.tbpConsumables.Controls.Add(this.cmbStudents);
            this.tbpConsumables.Controls.Add(this.txtConsumableNotes);
            this.tbpConsumables.Controls.Add(this.label12);
            this.tbpConsumables.Controls.Add(this.label13);
            this.tbpConsumables.Controls.Add(this.label10);
            this.tbpConsumables.Controls.Add(this.cmbCategory);
            this.tbpConsumables.Controls.Add(this.label9);
            this.tbpConsumables.Controls.Add(this.btnCancel);
            this.tbpConsumables.Controls.Add(this.btnHandOut);
            this.tbpConsumables.Controls.Add(this.label7);
            this.tbpConsumables.Controls.Add(this.label6);
            this.tbpConsumables.Controls.Add(this.nudAddQty);
            this.tbpConsumables.Controls.Add(this.label5);
            this.tbpConsumables.Controls.Add(this.txtCurrentQty);
            this.tbpConsumables.Controls.Add(this.cmbCommodity);
            this.tbpConsumables.Controls.Add(this.label4);
            this.tbpConsumables.Controls.Add(this.cmbCabinet);
            this.tbpConsumables.Controls.Add(this.label3);
            this.tbpConsumables.Controls.Add(this.cmbNLevel);
            this.tbpConsumables.Controls.Add(this.label8);
            this.tbpConsumables.Controls.Add(this.cmbRoom);
            this.tbpConsumables.Controls.Add(this.label11);
            this.tbpConsumables.Location = new System.Drawing.Point(4, 27);
            this.tbpConsumables.Margin = new System.Windows.Forms.Padding(4);
            this.tbpConsumables.Name = "tbpConsumables";
            this.tbpConsumables.Padding = new System.Windows.Forms.Padding(4);
            this.tbpConsumables.Size = new System.Drawing.Size(1233, 497);
            this.tbpConsumables.TabIndex = 1;
            this.tbpConsumables.Text = "Consumables";
            this.tbpConsumables.UseVisualStyleBackColor = true;
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(884, 32);
            this.cmbStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(337, 31);
            this.cmbStudents.TabIndex = 177;
            // 
            // txtConsumableNotes
            // 
            this.txtConsumableNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumableNotes.Location = new System.Drawing.Point(884, 100);
            this.txtConsumableNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsumableNotes.Name = "txtConsumableNotes";
            this.txtConsumableNotes.Size = new System.Drawing.Size(337, 227);
            this.txtConsumableNotes.TabIndex = 175;
            this.txtConsumableNotes.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(720, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 176;
            this.label12.Text = "Notes:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(720, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 24);
            this.label13.TabIndex = 174;
            this.label13.Text = "Student:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 29);
            this.label10.TabIndex = 172;
            this.label10.Text = "Hand Out Consumable Item";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(200, 74);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(211, 31);
            this.cmbCategory.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 171;
            this.label9.Text = "Category:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(911, 432);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 53);
            this.btnCancel.TabIndex = 163;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHandOut
            // 
            this.btnHandOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandOut.Location = new System.Drawing.Point(1071, 432);
            this.btnHandOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnHandOut.Name = "btnHandOut";
            this.btnHandOut.Size = new System.Drawing.Size(152, 53);
            this.btnHandOut.TabIndex = 164;
            this.btnHandOut.Text = "Hand Out";
            this.btnHandOut.UseVisualStyleBackColor = true;
            this.btnHandOut.Click += new System.EventHandler(this.btnHandOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(560, 23);
            this.label7.TabIndex = 156;
            this.label7.Text = "Hand the Commodity out from this Room, Cabinet, and N Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 170;
            this.label6.Text = "Hand Out Quantity:";
            // 
            // nudAddQty
            // 
            this.nudAddQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddQty.Location = new System.Drawing.Point(700, 297);
            this.nudAddQty.Margin = new System.Windows.Forms.Padding(4);
            this.nudAddQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAddQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddQty.Name = "nudAddQty";
            this.nudAddQty.Size = new System.Drawing.Size(160, 30);
            this.nudAddQty.TabIndex = 162;
            this.nudAddQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 169;
            this.label5.Text = "Current Quantity:";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQty.Location = new System.Drawing.Point(700, 236);
            this.txtCurrentQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(159, 30);
            this.txtCurrentQty.TabIndex = 161;
            // 
            // cmbCommodity
            // 
            this.cmbCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCommodity.FormattingEnabled = true;
            this.cmbCommodity.Location = new System.Drawing.Point(200, 126);
            this.cmbCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCommodity.Name = "cmbCommodity";
            this.cmbCommodity.Size = new System.Drawing.Size(211, 31);
            this.cmbCommodity.TabIndex = 157;
            this.cmbCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbCommodity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 168;
            this.label4.Text = "Commodity:";
            // 
            // cmbCabinet
            // 
            this.cmbCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCabinet.FormattingEnabled = true;
            this.cmbCabinet.Location = new System.Drawing.Point(200, 295);
            this.cmbCabinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCabinet.Name = "cmbCabinet";
            this.cmbCabinet.Size = new System.Drawing.Size(211, 31);
            this.cmbCabinet.TabIndex = 159;
            this.cmbCabinet.SelectedIndexChanged += new System.EventHandler(this.cmbCabinet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 167;
            this.label3.Text = "Cabinet:";
            // 
            // cmbNLevel
            // 
            this.cmbNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNLevel.FormattingEnabled = true;
            this.cmbNLevel.Location = new System.Drawing.Point(200, 354);
            this.cmbNLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNLevel.Name = "cmbNLevel";
            this.cmbNLevel.Size = new System.Drawing.Size(71, 31);
            this.cmbNLevel.TabIndex = 160;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 166;
            this.label8.Text = "N Level:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(200, 236);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(211, 31);
            this.cmbRoom.TabIndex = 158;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 165;
            this.label11.Text = "Room:";
            // 
            // cmbAssetsStudents
            // 
            this.cmbAssetsStudents.Enabled = false;
            this.cmbAssetsStudents.FormattingEnabled = true;
            this.cmbAssetsStudents.Location = new System.Drawing.Point(796, 99);
            this.cmbAssetsStudents.Name = "cmbAssetsStudents";
            this.cmbAssetsStudents.Size = new System.Drawing.Size(337, 26);
            this.cmbAssetsStudents.TabIndex = 136;
            // 
            // cmbAssetCategory
            // 
            this.cmbAssetCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssetCategory.FormattingEnabled = true;
            this.cmbAssetCategory.Location = new System.Drawing.Point(796, 46);
            this.cmbAssetCategory.Name = "cmbAssetCategory";
            this.cmbAssetCategory.Size = new System.Drawing.Size(337, 26);
            this.cmbAssetCategory.TabIndex = 137;
            this.cmbAssetCategory.Visible = false;
            // 
            // frmCheckInOutItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 558);
            this.Controls.Add(this.tbcCheckInOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheckInOutItems";
            this.Text = "Check-In/Out Items";
            this.Load += new System.EventHandler(this.frmCheckInOutItems_Load);
            this.tbcCheckInOut.ResumeLayout(false);
            this.tbpAssets.ResumeLayout(false);
            this.tbpAssets.PerformLayout();
            this.tbpConsumables.ResumeLayout(false);
            this.tbpConsumables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCheckInOut;
        private System.Windows.Forms.TabPage tbpAssets;
        private System.Windows.Forms.TabPage tbpConsumables;
        private System.Windows.Forms.Label lblSvsuIdCI;
        private System.Windows.Forms.ListBox lstCheckedOut;
        private System.Windows.Forms.ListBox lstCheckedIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox txtAssetNotes;
        internal System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cmbCategory;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHandOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAddQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentQty;
        internal System.Windows.Forms.ComboBox cmbCommodity;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbCabinet;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbNLevel;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cmbRoom;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.RichTextBox txtConsumableNotes;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbAssetsStudents;
        private System.Windows.Forms.ComboBox cmbAssetCategory;
    }
}
