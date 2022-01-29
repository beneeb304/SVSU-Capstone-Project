
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
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblDate_Time_Title = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.lblDate_and_Time = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudent_ID = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblCheckOutTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCheckout
            // 
            this.lblCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(72, 371);
            this.lblCheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(435, 26);
            this.lblCheckout.TabIndex = 41;
            this.lblCheckout.Text = "OT-04 Checked Out on 11/15/2021 10:43 AM";
            this.lblCheckout.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblDate_Time_Title
            // 
            this.lblDate_Time_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate_Time_Title.AutoSize = true;
            this.lblDate_Time_Title.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_Time_Title.Location = new System.Drawing.Point(93, 310);
            this.lblDate_Time_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate_Time_Title.Name = "lblDate_Time_Title";
            this.lblDate_Time_Title.Size = new System.Drawing.Size(110, 26);
            this.lblDate_Time_Title.TabIndex = 40;
            this.lblDate_Time_Title.Text = "Date/Time";
            this.lblDate_Time_Title.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(223, 433);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(132, 57);
            this.btnCheckin.TabIndex = 39;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDate_and_Time
            // 
            this.lblDate_and_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate_and_Time.AutoSize = true;
            this.lblDate_and_Time.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_and_Time.Location = new System.Drawing.Point(217, 310);
            this.lblDate_and_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate_and_Time.Name = "lblDate_and_Time";
            this.lblDate_and_Time.Size = new System.Drawing.Size(218, 26);
            this.lblDate_and_Time.TabIndex = 38;
            this.lblDate_and_Time.Text = "11/15/2021 10:43 AM";
            this.lblDate_and_Time.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(127, 252);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 26);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "Item ID";
            this.lblID.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(88, 191);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 26);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Item Name";
            this.lblName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(96, 129);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(111, 26);
            this.lblStudentID.TabIndex = 35;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(57, 67);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(145, 26);
            this.lblStudentName.TabIndex = 34;
            this.lblStudentName.Text = "Student Name";
            this.lblStudentName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtStudent_ID
            // 
            this.txtStudent_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudent_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent_ID.Location = new System.Drawing.Point(217, 125);
            this.txtStudent_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudent_ID.Name = "txtStudent_ID";
            this.txtStudent_ID.Size = new System.Drawing.Size(132, 31);
            this.txtStudent_ID.TabIndex = 33;
            this.txtStudent_ID.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(217, 248);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(132, 31);
            this.txtItemID.TabIndex = 32;
            this.txtItemID.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(217, 187);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(291, 31);
            this.txtItemName.TabIndex = 31;
            this.txtItemName.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(217, 64);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(291, 31);
            this.txtStudentName.TabIndex = 30;
            this.txtStudentName.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // lblCheckOutTitle
            // 
            this.lblCheckOutTitle.AutoSize = true;
            this.lblCheckOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCheckOutTitle.Name = "lblCheckOutTitle";
            this.lblCheckOutTitle.Size = new System.Drawing.Size(249, 39);
            this.lblCheckOutTitle.TabIndex = 42;
            this.lblCheckOutTitle.Text = "Item Checkout";
            // 
            // frmCheckInOutItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 558);
            this.Controls.Add(this.lblCheckOutTitle);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.lblDate_Time_Title);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.lblDate_and_Time);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudent_ID);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtStudentName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheckInOutItems";
            this.Text = "Check-In/Out Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblDate_Time_Title;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label lblDate_and_Time;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudent_ID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblCheckOutTitle;
    }
}