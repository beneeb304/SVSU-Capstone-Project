
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
            this.tbpHandOut = new System.Windows.Forms.TabPage();
            this.lblCheckOutTitle = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tbpCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCheckIn);
            this.tabControl1.Controls.Add(this.tbpCheckOut);
            this.tabControl1.Controls.Add(this.tbpHandOut);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 429);
            this.tabControl1.TabIndex = 43;
            // 
            // tbpCheckIn
            // 
            this.tbpCheckIn.Location = new System.Drawing.Point(4, 22);
            this.tbpCheckIn.Name = "tbpCheckIn";
            this.tbpCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckIn.Size = new System.Drawing.Size(923, 403);
            this.tbpCheckIn.TabIndex = 0;
            this.tbpCheckIn.Text = "Check In Simulator";
            this.tbpCheckIn.UseVisualStyleBackColor = true;
            // 
            // tbpCheckOut
            // 
            this.tbpCheckOut.Controls.Add(this.lblCheckOutTitle);
            this.tbpCheckOut.Controls.Add(this.lblCheckout);
            this.tbpCheckOut.Controls.Add(this.lblDate_Time_Title);
            this.tbpCheckOut.Controls.Add(this.btnCheckin);
            this.tbpCheckOut.Controls.Add(this.lblDate_and_Time);
            this.tbpCheckOut.Controls.Add(this.lblID);
            this.tbpCheckOut.Controls.Add(this.lblName);
            this.tbpCheckOut.Controls.Add(this.lblStudentID);
            this.tbpCheckOut.Controls.Add(this.lblStudentName);
            this.tbpCheckOut.Controls.Add(this.txtStudent_ID);
            this.tbpCheckOut.Controls.Add(this.txtItemID);
            this.tbpCheckOut.Controls.Add(this.txtItemName);
            this.tbpCheckOut.Controls.Add(this.txtStudentName);
            this.tbpCheckOut.Location = new System.Drawing.Point(4, 22);
            this.tbpCheckOut.Name = "tbpCheckOut";
            this.tbpCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckOut.Size = new System.Drawing.Size(923, 403);
            this.tbpCheckOut.TabIndex = 1;
            this.tbpCheckOut.Text = "Check Out Simulator";
            this.tbpCheckOut.UseVisualStyleBackColor = true;
            // 
            // tbpHandOut
            // 
            this.tbpHandOut.Location = new System.Drawing.Point(4, 22);
            this.tbpHandOut.Name = "tbpHandOut";
            this.tbpHandOut.Size = new System.Drawing.Size(192, 74);
            this.tbpHandOut.TabIndex = 2;
            this.tbpHandOut.Text = "Hand-Out Item";
            this.tbpHandOut.UseVisualStyleBackColor = true;
            // 
            // lblCheckOutTitle
            // 
            this.lblCheckOutTitle.AutoSize = true;
            this.lblCheckOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTitle.Location = new System.Drawing.Point(268, 6);
            this.lblCheckOutTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOutTitle.Name = "lblCheckOutTitle";
            this.lblCheckOutTitle.Size = new System.Drawing.Size(203, 31);
            this.lblCheckOutTitle.TabIndex = 55;
            this.lblCheckOutTitle.Text = "Item Checkout";
            // 
            // lblCheckout
            // 
            this.lblCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(313, 300);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(341, 22);
            this.lblCheckout.TabIndex = 54;
            this.lblCheckout.Text = "OT-04 Checked Out on 11/15/2021 10:43 AM";
            // 
            // lblDate_Time_Title
            // 
            this.lblDate_Time_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate_Time_Title.AutoSize = true;
            this.lblDate_Time_Title.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_Time_Title.Location = new System.Drawing.Point(329, 251);
            this.lblDate_Time_Title.Name = "lblDate_Time_Title";
            this.lblDate_Time_Title.Size = new System.Drawing.Size(87, 22);
            this.lblDate_Time_Title.TabIndex = 53;
            this.lblDate_Time_Title.Text = "Date/Time";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(426, 351);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(99, 46);
            this.btnCheckin.TabIndex = 52;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            // 
            // lblDate_and_Time
            // 
            this.lblDate_and_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate_and_Time.AutoSize = true;
            this.lblDate_and_Time.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_and_Time.Location = new System.Drawing.Point(422, 251);
            this.lblDate_and_Time.Name = "lblDate_and_Time";
            this.lblDate_and_Time.Size = new System.Drawing.Size(168, 22);
            this.lblDate_and_Time.TabIndex = 51;
            this.lblDate_and_Time.Text = "11/15/2021 10:43 AM";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(354, 204);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 22);
            this.lblID.TabIndex = 50;
            this.lblID.Text = "Item ID";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(325, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 22);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Item Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(331, 104);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(85, 22);
            this.lblStudentID.TabIndex = 48;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(302, 53);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(114, 22);
            this.lblStudentName.TabIndex = 47;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudent_ID
            // 
            this.txtStudent_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudent_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent_ID.Location = new System.Drawing.Point(422, 101);
            this.txtStudent_ID.Name = "txtStudent_ID";
            this.txtStudent_ID.Size = new System.Drawing.Size(100, 26);
            this.txtStudent_ID.TabIndex = 46;
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(422, 201);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 26);
            this.txtItemID.TabIndex = 45;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(422, 151);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(219, 26);
            this.txtItemName.TabIndex = 44;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(422, 51);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(219, 26);
            this.txtStudentName.TabIndex = 43;
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
            this.tbpCheckOut.ResumeLayout(false);
            this.tbpCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCheckIn;
        private System.Windows.Forms.TabPage tbpCheckOut;
        private System.Windows.Forms.Label lblCheckOutTitle;
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
        private System.Windows.Forms.TabPage tbpHandOut;
    }
}