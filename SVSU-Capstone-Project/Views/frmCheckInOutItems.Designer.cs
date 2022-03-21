
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
            this.cmbChkInStudent = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnChkInCancel = new System.Windows.Forms.Button();
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
            this.btnChkOutCancel = new System.Windows.Forms.Button();
            this.btnChkOut = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbChkOutCommodity = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbcCheckInOut = new System.Windows.Forms.TabControl();
            this.tbpCheckIn.SuspendLayout();
            this.tbpCheckOut.SuspendLayout();
            this.tbcCheckInOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpCheckIn
            // 
            this.tbpCheckIn.Controls.Add(this.cmbChkInStudent);
            this.tbpCheckIn.Controls.Add(this.label22);
            this.tbpCheckIn.Controls.Add(this.label23);
            this.tbpCheckIn.Controls.Add(this.btnChkInCancel);
            this.tbpCheckIn.Controls.Add(this.btnChkIn);
            this.tbpCheckIn.Controls.Add(this.cmbChkInCommodity);
            this.tbpCheckIn.Controls.Add(this.label27);
            this.tbpCheckIn.Location = new System.Drawing.Point(4, 25);
            this.tbpCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpCheckIn.Name = "tbpCheckIn";
            this.tbpCheckIn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpCheckIn.Size = new System.Drawing.Size(923, 402);
            this.tbpCheckIn.TabIndex = 3;
            this.tbpCheckIn.Text = "Check In";
            this.tbpCheckIn.UseVisualStyleBackColor = true;
            // 
            // cmbChkInStudent
            // 
            this.cmbChkInStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChkInStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkInStudent.FormattingEnabled = true;
            this.cmbChkInStudent.Location = new System.Drawing.Point(133, 87);
            this.cmbChkInStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChkInStudent.Name = "cmbChkInStudent";
            this.cmbChkInStudent.Size = new System.Drawing.Size(336, 26);
            this.cmbChkInStudent.TabIndex = 214;
            this.cmbChkInStudent.SelectedIndexChanged += new System.EventHandler(this.cmbChkInStudent_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(26, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 19);
            this.label22.TabIndex = 211;
            this.label22.Text = "Student:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(191, 22);
            this.label23.TabIndex = 210;
            this.label23.Text = "Check In Asset Item";
            // 
            // btnChkInCancel
            // 
            this.btnChkInCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkInCancel.Location = new System.Drawing.Point(323, 237);
            this.btnChkInCancel.Name = "btnChkInCancel";
            this.btnChkInCancel.Size = new System.Drawing.Size(114, 43);
            this.btnChkInCancel.TabIndex = 204;
            this.btnChkInCancel.Text = "Cancel";
            this.btnChkInCancel.UseVisualStyleBackColor = true;
            this.btnChkInCancel.Click += new System.EventHandler(this.btnChkInCancel_Click);
            // 
            // btnChkIn
            // 
            this.btnChkIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkIn.Location = new System.Drawing.Point(147, 237);
            this.btnChkIn.Name = "btnChkIn";
            this.btnChkIn.Size = new System.Drawing.Size(114, 43);
            this.btnChkIn.TabIndex = 205;
            this.btnChkIn.Text = "Check In";
            this.btnChkIn.UseVisualStyleBackColor = true;
            this.btnChkIn.Click += new System.EventHandler(this.btnChkIn_Click);
            // 
            // cmbChkInCommodity
            // 
            this.cmbChkInCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChkInCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkInCommodity.FormattingEnabled = true;
            this.cmbChkInCommodity.Location = new System.Drawing.Point(133, 139);
            this.cmbChkInCommodity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChkInCommodity.Name = "cmbChkInCommodity";
            this.cmbChkInCommodity.Size = new System.Drawing.Size(336, 26);
            this.cmbChkInCommodity.TabIndex = 201;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 145);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 19);
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
            this.tbpCheckOut.Controls.Add(this.btnChkOutCancel);
            this.tbpCheckOut.Controls.Add(this.btnChkOut);
            this.tbpCheckOut.Controls.Add(this.label20);
            this.tbpCheckOut.Controls.Add(this.cmbChkOutCommodity);
            this.tbpCheckOut.Controls.Add(this.label21);
            this.tbpCheckOut.Location = new System.Drawing.Point(4, 25);
            this.tbpCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpCheckOut.Name = "tbpCheckOut";
            this.tbpCheckOut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpCheckOut.Size = new System.Drawing.Size(923, 402);
            this.tbpCheckOut.TabIndex = 2;
            this.tbpCheckOut.Text = "Check Out";
            this.tbpCheckOut.UseVisualStyleBackColor = true;
            // 
            // cmbChkOutStudent
            // 
            this.cmbChkOutStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChkOutStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkOutStudent.FormattingEnabled = true;
            this.cmbChkOutStudent.Location = new System.Drawing.Point(143, 65);
            this.cmbChkOutStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChkOutStudent.Name = "cmbChkOutStudent";
            this.cmbChkOutStudent.Size = new System.Drawing.Size(322, 26);
            this.cmbChkOutStudent.TabIndex = 199;
            // 
            // txtChkOutNotes
            // 
            this.txtChkOutNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChkOutNotes.Location = new System.Drawing.Point(563, 125);
            this.txtChkOutNotes.Name = "txtChkOutNotes";
            this.txtChkOutNotes.Size = new System.Drawing.Size(254, 185);
            this.txtChkOutNotes.TabIndex = 197;
            this.txtChkOutNotes.Text = "";
            // 
            // txtAvailableChkOutQuantity
            // 
            this.txtAvailableChkOutQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableChkOutQuantity.Location = new System.Drawing.Point(221, 171);
            this.txtAvailableChkOutQuantity.Name = "txtAvailableChkOutQuantity";
            this.txtAvailableChkOutQuantity.ReadOnly = true;
            this.txtAvailableChkOutQuantity.Size = new System.Drawing.Size(120, 26);
            this.txtAvailableChkOutQuantity.TabIndex = 184;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(478, 125);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 198;
            this.label14.Text = "Notes:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 19);
            this.label15.TabIndex = 196;
            this.label15.Text = "Student:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 22);
            this.label16.TabIndex = 195;
            this.label16.Text = "Check Out Asset Item";
            // 
            // btnChkOutCancel
            // 
            this.btnChkOutCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkOutCancel.Location = new System.Drawing.Point(702, 333);
            this.btnChkOutCancel.Name = "btnChkOutCancel";
            this.btnChkOutCancel.Size = new System.Drawing.Size(114, 43);
            this.btnChkOutCancel.TabIndex = 186;
            this.btnChkOutCancel.Text = "Cancel";
            this.btnChkOutCancel.UseVisualStyleBackColor = true;
            this.btnChkOutCancel.Click += new System.EventHandler(this.btnChkOutCancel_Click);
            // 
            // btnChkOut
            // 
            this.btnChkOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkOut.Location = new System.Drawing.Point(563, 333);
            this.btnChkOut.Name = "btnChkOut";
            this.btnChkOut.Size = new System.Drawing.Size(114, 43);
            this.btnChkOut.TabIndex = 187;
            this.btnChkOut.Text = "Check Out";
            this.btnChkOut.UseVisualStyleBackColor = true;
            this.btnChkOut.Click += new System.EventHandler(this.btnChkOut_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(58, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 19);
            this.label20.TabIndex = 192;
            this.label20.Text = "Available Quantity:";
            // 
            // cmbChkOutCommodity
            // 
            this.cmbChkOutCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChkOutCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChkOutCommodity.FormattingEnabled = true;
            this.cmbChkOutCommodity.Location = new System.Drawing.Point(143, 102);
            this.cmbChkOutCommodity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChkOutCommodity.Name = "cmbChkOutCommodity";
            this.cmbChkOutCommodity.Size = new System.Drawing.Size(322, 26);
            this.cmbChkOutCommodity.TabIndex = 180;
            this.cmbChkOutCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbChkOutCommodity_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(40, 105);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 19);
            this.label21.TabIndex = 191;
            this.label21.Text = "Commodity:";
            // 
            // tbcCheckInOut
            // 
            this.tbcCheckInOut.Controls.Add(this.tbpCheckOut);
            this.tbcCheckInOut.Controls.Add(this.tbpCheckIn);
            this.tbcCheckInOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCheckInOut.Location = new System.Drawing.Point(10, 12);
            this.tbcCheckInOut.Name = "tbcCheckInOut";
            this.tbcCheckInOut.SelectedIndex = 0;
            this.tbcCheckInOut.Size = new System.Drawing.Size(931, 431);
            this.tbcCheckInOut.TabIndex = 43;
            this.tbcCheckInOut.SelectedIndexChanged += new System.EventHandler(this.tbcCheckInOut_SelectedIndexChanged);
            // 
            // frmCheckInOutItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 453);
            this.Controls.Add(this.tbcCheckInOut);
            this.Name = "frmCheckInOutItems";
            this.Text = "Check-In/Out Items";
            this.tbpCheckIn.ResumeLayout(false);
            this.tbpCheckIn.PerformLayout();
            this.tbpCheckOut.ResumeLayout(false);
            this.tbpCheckOut.PerformLayout();
            this.tbcCheckInOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpCheckIn;
        internal System.Windows.Forms.ComboBox cmbChkInStudent;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnChkInCancel;
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
        private System.Windows.Forms.Button btnChkOutCancel;
        private System.Windows.Forms.Button btnChkOut;
        private System.Windows.Forms.Label label20;
        internal System.Windows.Forms.ComboBox cmbChkOutCommodity;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabControl tbcCheckInOut;
    }
}
