
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
            this.tbpCheckIn = new System.Windows.Forms.TabPage();
            this.tbpCheckOut = new System.Windows.Forms.TabPage();
            this.lblDate_Time_Title = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudent_ID = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.tbpHandOut = new System.Windows.Forms.TabPage();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.lblCheckOutTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbpCheckIn.SuspendLayout();
            this.tbpCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCheckIn);
            this.tabControl1.Controls.Add(this.tbpCheckOut);
            this.tabControl1.Controls.Add(this.tbpHandOut);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 429);
            this.tabControl1.TabIndex = 43;
            // 
            // tbpCheckIn
            // 
            this.tbpCheckIn.Controls.Add(this.button1);
            this.tbpCheckIn.Controls.Add(this.label1);
            this.tbpCheckIn.Controls.Add(this.label2);
            this.tbpCheckIn.Controls.Add(this.button2);
            this.tbpCheckIn.Controls.Add(this.label3);
            this.tbpCheckIn.Controls.Add(this.label4);
            this.tbpCheckIn.Controls.Add(this.label5);
            this.tbpCheckIn.Controls.Add(this.label6);
            this.tbpCheckIn.Controls.Add(this.label7);
            this.tbpCheckIn.Controls.Add(this.textBox1);
            this.tbpCheckIn.Controls.Add(this.textBox2);
            this.tbpCheckIn.Controls.Add(this.textBox3);
            this.tbpCheckIn.Controls.Add(this.textBox4);
            this.tbpCheckIn.Location = new System.Drawing.Point(4, 25);
            this.tbpCheckIn.Name = "tbpCheckIn";
            this.tbpCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckIn.Size = new System.Drawing.Size(923, 400);
            this.tbpCheckIn.TabIndex = 0;
            this.tbpCheckIn.Text = "Check In Simulator";
            this.tbpCheckIn.UseVisualStyleBackColor = true;
            // 
            // tbpCheckOut
            // 
            this.tbpCheckOut.Controls.Add(this.btnClearForm);
            this.tbpCheckOut.Controls.Add(this.lblCheckOutTitle);
            this.tbpCheckOut.Controls.Add(this.lblDate_Time_Title);
            this.tbpCheckOut.Controls.Add(this.btnCheckOut);
            this.tbpCheckOut.Controls.Add(this.lblDateAndTime);
            this.tbpCheckOut.Controls.Add(this.lblID);
            this.tbpCheckOut.Controls.Add(this.lblName);
            this.tbpCheckOut.Controls.Add(this.lblStudentID);
            this.tbpCheckOut.Controls.Add(this.lblStudentName);
            this.tbpCheckOut.Controls.Add(this.txtStudent_ID);
            this.tbpCheckOut.Controls.Add(this.txtItemID);
            this.tbpCheckOut.Controls.Add(this.txtItemName);
            this.tbpCheckOut.Controls.Add(this.txtStudentName);
            this.tbpCheckOut.Location = new System.Drawing.Point(4, 25);
            this.tbpCheckOut.Name = "tbpCheckOut";
            this.tbpCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckOut.Size = new System.Drawing.Size(923, 400);
            this.tbpCheckOut.TabIndex = 1;
            this.tbpCheckOut.Text = "Check Out Simulator";
            this.tbpCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblDate_Time_Title
            // 
            this.lblDate_Time_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate_Time_Title.AutoSize = true;
            this.lblDate_Time_Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_Time_Title.Location = new System.Drawing.Point(306, 270);
            this.lblDate_Time_Title.Name = "lblDate_Time_Title";
            this.lblDate_Time_Title.Size = new System.Drawing.Size(80, 18);
            this.lblDate_Time_Title.TabIndex = 53;
            this.lblDate_Time_Title.Text = "Date/Time";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(483, 315);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(99, 46);
            this.btnCheckOut.TabIndex = 52;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(424, 270);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(158, 18);
            this.lblDateAndTime.TabIndex = 51;
            this.lblDateAndTime.Text = "11/15/2021 10:43 AM";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(305, 223);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 19);
            this.lblID.TabIndex = 50;
            this.lblID.Text = "Item ID";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(304, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 19);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Item Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(304, 123);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(89, 19);
            this.lblStudentID.TabIndex = 48;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(304, 73);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(117, 19);
            this.lblStudentName.TabIndex = 47;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudent_ID
            // 
            this.txtStudent_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudent_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent_ID.Location = new System.Drawing.Point(427, 120);
            this.txtStudent_ID.Name = "txtStudent_ID";
            this.txtStudent_ID.Size = new System.Drawing.Size(100, 26);
            this.txtStudent_ID.TabIndex = 46;
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(427, 220);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 26);
            this.txtItemID.TabIndex = 45;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(427, 170);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(219, 26);
            this.txtItemName.TabIndex = 44;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(427, 70);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(219, 26);
            this.txtStudentName.TabIndex = 43;
            // 
            // tbpHandOut
            // 
            this.tbpHandOut.Location = new System.Drawing.Point(4, 25);
            this.tbpHandOut.Name = "tbpHandOut";
            this.tbpHandOut.Size = new System.Drawing.Size(923, 400);
            this.tbpHandOut.TabIndex = 2;
            this.tbpHandOut.Text = "Hand-Out Item";
            this.tbpHandOut.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(364, 315);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(99, 46);
            this.btnClearForm.TabIndex = 56;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // lblCheckOutTitle
            // 
            this.lblCheckOutTitle.AutoSize = true;
            this.lblCheckOutTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTitle.Location = new System.Drawing.Point(305, 23);
            this.lblCheckOutTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOutTitle.Name = "lblCheckOutTitle";
            this.lblCheckOutTitle.Size = new System.Drawing.Size(156, 24);
            this.lblCheckOutTitle.TabIndex = 55;
            this.lblCheckOutTitle.Text = "Item Checkout";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 69;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Item Checkin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Date/Time";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(469, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 66;
            this.button2.Text = "Check In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "11/15/2021 10:43 AM";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Item ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Item Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Student ID";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Student Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(413, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(413, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 59;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(413, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 26);
            this.textBox3.TabIndex = 58;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(413, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 26);
            this.textBox4.TabIndex = 57;
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
            this.tbpCheckIn.ResumeLayout(false);
            this.tbpCheckIn.PerformLayout();
            this.tbpCheckOut.ResumeLayout(false);
            this.tbpCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCheckIn;
        private System.Windows.Forms.TabPage tbpCheckOut;
        private System.Windows.Forms.Label lblDate_Time_Title;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudent_ID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TabPage tbpHandOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label lblCheckOutTitle;
    }
}