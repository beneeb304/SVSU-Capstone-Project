
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpAssets = new System.Windows.Forms.TabPage();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtAssetNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCheckedOut = new System.Windows.Forms.ListBox();
            this.lstCheckedIn = new System.Windows.Forms.ListBox();
            this.txtSvsuIdCI = new System.Windows.Forms.MaskedTextBox();
            this.lblSvsuIdCI = new System.Windows.Forms.Label();
            this.tbpConsumables = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHandOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAddQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.cmbAddCommodity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAddCabinet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAddNLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAddRoom = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpAssets.SuspendLayout();
            this.tbpConsumables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAssets);
            this.tabControl1.Controls.Add(this.tbpConsumables);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 429);
            this.tabControl1.TabIndex = 43;
            // 
            // tbpAssets
            // 
            this.tbpAssets.Controls.Add(this.btnCheckIn);
            this.tbpAssets.Controls.Add(this.btnCheckOut);
            this.tbpAssets.Controls.Add(this.txtAssetNotes);
            this.tbpAssets.Controls.Add(this.lblNotes);
            this.tbpAssets.Controls.Add(this.label2);
            this.tbpAssets.Controls.Add(this.label1);
            this.tbpAssets.Controls.Add(this.lstCheckedOut);
            this.tbpAssets.Controls.Add(this.lstCheckedIn);
            this.tbpAssets.Controls.Add(this.txtSvsuIdCI);
            this.tbpAssets.Controls.Add(this.lblSvsuIdCI);
            this.tbpAssets.Location = new System.Drawing.Point(4, 25);
            this.tbpAssets.Name = "tbpAssets";
            this.tbpAssets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAssets.Size = new System.Drawing.Size(923, 400);
            this.tbpAssets.TabIndex = 0;
            this.tbpAssets.Text = "Assets";
            this.tbpAssets.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(699, 348);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(99, 46);
            this.btnCheckIn.TabIndex = 134;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(818, 348);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(99, 46);
            this.btnCheckOut.TabIndex = 135;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // txtAssetNotes
            // 
            this.txtAssetNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetNotes.Location = new System.Drawing.Point(597, 137);
            this.txtAssetNotes.Name = "txtAssetNotes";
            this.txtAssetNotes.Size = new System.Drawing.Size(254, 185);
            this.txtAssetNotes.TabIndex = 132;
            this.txtAssetNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(474, 140);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 19);
            this.lblNotes.TabIndex = 133;
            this.lblNotes.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Checked Out Assets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Checked In Assets";
            // 
            // lstCheckedOut
            // 
            this.lstCheckedOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCheckedOut.FormattingEnabled = true;
            this.lstCheckedOut.ItemHeight = 18;
            this.lstCheckedOut.Location = new System.Drawing.Point(258, 56);
            this.lstCheckedOut.Name = "lstCheckedOut";
            this.lstCheckedOut.Size = new System.Drawing.Size(193, 310);
            this.lstCheckedOut.TabIndex = 70;
            this.lstCheckedOut.Click += new System.EventHandler(this.ListBoxClicked);
            // 
            // lstCheckedIn
            // 
            this.lstCheckedIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCheckedIn.FormattingEnabled = true;
            this.lstCheckedIn.ItemHeight = 18;
            this.lstCheckedIn.Location = new System.Drawing.Point(36, 56);
            this.lstCheckedIn.Name = "lstCheckedIn";
            this.lstCheckedIn.Size = new System.Drawing.Size(193, 310);
            this.lstCheckedIn.TabIndex = 69;
            this.lstCheckedIn.Click += new System.EventHandler(this.ListBoxClicked);
            // 
            // txtSvsuIdCI
            // 
            this.txtSvsuIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSvsuIdCI.Location = new System.Drawing.Point(597, 79);
            this.txtSvsuIdCI.Mask = "000000";
            this.txtSvsuIdCI.Name = "txtSvsuIdCI";
            this.txtSvsuIdCI.Size = new System.Drawing.Size(100, 26);
            this.txtSvsuIdCI.TabIndex = 1;
            this.txtSvsuIdCI.ValidatingType = typeof(int);
            // 
            // lblSvsuIdCI
            // 
            this.lblSvsuIdCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSvsuIdCI.AutoSize = true;
            this.lblSvsuIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvsuIdCI.Location = new System.Drawing.Point(474, 82);
            this.lblSvsuIdCI.Name = "lblSvsuIdCI";
            this.lblSvsuIdCI.Size = new System.Drawing.Size(89, 19);
            this.lblSvsuIdCI.TabIndex = 62;
            this.lblSvsuIdCI.Text = "Student ID";
            // 
            // tbpConsumables
            // 
            this.tbpConsumables.Controls.Add(this.richTextBox1);
            this.tbpConsumables.Controls.Add(this.label12);
            this.tbpConsumables.Controls.Add(this.maskedTextBox1);
            this.tbpConsumables.Controls.Add(this.label13);
            this.tbpConsumables.Controls.Add(this.label10);
            this.tbpConsumables.Controls.Add(this.cmbAddCategory);
            this.tbpConsumables.Controls.Add(this.label9);
            this.tbpConsumables.Controls.Add(this.btnCancel);
            this.tbpConsumables.Controls.Add(this.btnHandOut);
            this.tbpConsumables.Controls.Add(this.label7);
            this.tbpConsumables.Controls.Add(this.label6);
            this.tbpConsumables.Controls.Add(this.nudAddQty);
            this.tbpConsumables.Controls.Add(this.label5);
            this.tbpConsumables.Controls.Add(this.txtCurrentQty);
            this.tbpConsumables.Controls.Add(this.cmbAddCommodity);
            this.tbpConsumables.Controls.Add(this.label4);
            this.tbpConsumables.Controls.Add(this.cmbAddCabinet);
            this.tbpConsumables.Controls.Add(this.label3);
            this.tbpConsumables.Controls.Add(this.cmbAddNLevel);
            this.tbpConsumables.Controls.Add(this.label8);
            this.tbpConsumables.Controls.Add(this.cmbAddRoom);
            this.tbpConsumables.Controls.Add(this.label11);
            this.tbpConsumables.Location = new System.Drawing.Point(4, 25);
            this.tbpConsumables.Name = "tbpConsumables";
            this.tbpConsumables.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsumables.Size = new System.Drawing.Size(923, 400);
            this.tbpConsumables.TabIndex = 1;
            this.tbpConsumables.Text = "Consumables";
            this.tbpConsumables.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 22);
            this.label10.TabIndex = 172;
            this.label10.Text = "Hand Out Consumable Item";
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(150, 60);
            this.cmbAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCategory.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 171;
            this.label9.Text = "Category:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(683, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 43);
            this.btnCancel.TabIndex = 163;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnHandOut
            // 
            this.btnHandOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandOut.Location = new System.Drawing.Point(803, 351);
            this.btnHandOut.Name = "btnHandOut";
            this.btnHandOut.Size = new System.Drawing.Size(114, 43);
            this.btnHandOut.TabIndex = 164;
            this.btnHandOut.Text = "Hand Out";
            this.btnHandOut.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(441, 18);
            this.label7.TabIndex = 156;
            this.label7.Text = "Hand the Commodity out from this Room, Cabinet, and N Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 170;
            this.label6.Text = "Hand Out Quantity:";
            // 
            // nudAddQty
            // 
            this.nudAddQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddQty.Location = new System.Drawing.Point(525, 241);
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
            this.nudAddQty.Size = new System.Drawing.Size(120, 26);
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
            this.label5.Location = new System.Drawing.Point(333, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 169;
            this.label5.Text = "Current Quantity:";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQty.Location = new System.Drawing.Point(525, 192);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(120, 26);
            this.txtCurrentQty.TabIndex = 161;
            // 
            // cmbAddCommodity
            // 
            this.cmbAddCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCommodity.FormattingEnabled = true;
            this.cmbAddCommodity.Location = new System.Drawing.Point(150, 102);
            this.cmbAddCommodity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCommodity.Name = "cmbAddCommodity";
            this.cmbAddCommodity.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCommodity.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 168;
            this.label4.Text = "Commodity:";
            // 
            // cmbAddCabinet
            // 
            this.cmbAddCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCabinet.FormattingEnabled = true;
            this.cmbAddCabinet.Location = new System.Drawing.Point(150, 240);
            this.cmbAddCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCabinet.Name = "cmbAddCabinet";
            this.cmbAddCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCabinet.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 167;
            this.label3.Text = "Cabinet:";
            // 
            // cmbAddNLevel
            // 
            this.cmbAddNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddNLevel.FormattingEnabled = true;
            this.cmbAddNLevel.Location = new System.Drawing.Point(150, 288);
            this.cmbAddNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddNLevel.Name = "cmbAddNLevel";
            this.cmbAddNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbAddNLevel.TabIndex = 160;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 166;
            this.label8.Text = "N Level:";
            // 
            // cmbAddRoom
            // 
            this.cmbAddRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddRoom.FormattingEnabled = true;
            this.cmbAddRoom.Location = new System.Drawing.Point(150, 192);
            this.cmbAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddRoom.Name = "cmbAddRoom";
            this.cmbAddRoom.Size = new System.Drawing.Size(159, 26);
            this.cmbAddRoom.TabIndex = 158;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 165;
            this.label11.Text = "Room:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(663, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 185);
            this.richTextBox1.TabIndex = 175;
            this.richTextBox1.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(540, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 176;
            this.label12.Text = "Notes:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(663, 23);
            this.maskedTextBox1.Mask = "000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 173;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(540, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 174;
            this.label13.Text = "Student ID";
            // 
            // frmCheckInOutItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCheckInOutItems";
            this.Text = "Check-In/Out Items";
            this.tabControl1.ResumeLayout(false);
            this.tbpAssets.ResumeLayout(false);
            this.tbpAssets.PerformLayout();
            this.tbpConsumables.ResumeLayout(false);
            this.tbpConsumables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpAssets;
        private System.Windows.Forms.TabPage tbpConsumables;
        private System.Windows.Forms.Label lblSvsuIdCI;
        private System.Windows.Forms.MaskedTextBox txtSvsuIdCI;
        private System.Windows.Forms.ListBox lstCheckedOut;
        private System.Windows.Forms.ListBox lstCheckedIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox txtAssetNotes;
        internal System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cmbAddCategory;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHandOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAddQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentQty;
        internal System.Windows.Forms.ComboBox cmbAddCommodity;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbAddCabinet;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbAddNLevel;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cmbAddRoom;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label13;
    }
}
