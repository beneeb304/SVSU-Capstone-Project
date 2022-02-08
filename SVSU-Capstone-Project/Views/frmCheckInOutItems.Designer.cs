
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
            this.btnClearCI = new System.Windows.Forms.Button();
            this.lblCIHeader = new System.Windows.Forms.Label();
            this.lblTimeCI = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblTimeClockCI = new System.Windows.Forms.Label();
            this.lblItemIdCI = new System.Windows.Forms.Label();
            this.lblItemNameCI = new System.Windows.Forms.Label();
            this.lblSvsuIdCI = new System.Windows.Forms.Label();
            this.lblStudentNameCI = new System.Windows.Forms.Label();
            this.txtItemIdCI = new System.Windows.Forms.TextBox();
            this.txtItemNameCI = new System.Windows.Forms.TextBox();
            this.txtStudentNameCI = new System.Windows.Forms.TextBox();
            this.tbpCheckOut = new System.Windows.Forms.TabPage();
            this.btnClearCO = new System.Windows.Forms.Button();
            this.lblCOHeader = new System.Windows.Forms.Label();
            this.lblTimeCO = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblTimeClockCO = new System.Windows.Forms.Label();
            this.lblItemIdCO = new System.Windows.Forms.Label();
            this.lblItemNameCO = new System.Windows.Forms.Label();
            this.lblSvsuIdCO = new System.Windows.Forms.Label();
            this.lblStudentNameCO = new System.Windows.Forms.Label();
            this.txtItemIdCO = new System.Windows.Forms.TextBox();
            this.txtItemNameCO = new System.Windows.Forms.TextBox();
            this.txtStudentNameCO = new System.Windows.Forms.TextBox();
            this.tbpHandOut = new System.Windows.Forms.TabPage();
            this.txtSvsuIdCI = new System.Windows.Forms.MaskedTextBox();
            this.txtSvsuIdCO = new System.Windows.Forms.MaskedTextBox();
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
            this.tbpCheckIn.Controls.Add(this.txtSvsuIdCI);
            this.tbpCheckIn.Controls.Add(this.btnClearCI);
            this.tbpCheckIn.Controls.Add(this.lblCIHeader);
            this.tbpCheckIn.Controls.Add(this.lblTimeCI);
            this.tbpCheckIn.Controls.Add(this.btnCheckIn);
            this.tbpCheckIn.Controls.Add(this.lblTimeClockCI);
            this.tbpCheckIn.Controls.Add(this.lblItemIdCI);
            this.tbpCheckIn.Controls.Add(this.lblItemNameCI);
            this.tbpCheckIn.Controls.Add(this.lblSvsuIdCI);
            this.tbpCheckIn.Controls.Add(this.lblStudentNameCI);
            this.tbpCheckIn.Controls.Add(this.txtItemIdCI);
            this.tbpCheckIn.Controls.Add(this.txtItemNameCI);
            this.tbpCheckIn.Controls.Add(this.txtStudentNameCI);
            this.tbpCheckIn.Location = new System.Drawing.Point(4, 25);
            this.tbpCheckIn.Name = "tbpCheckIn";
            this.tbpCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckIn.Size = new System.Drawing.Size(923, 400);
            this.tbpCheckIn.TabIndex = 0;
            this.tbpCheckIn.Text = "Check In Simulator";
            this.tbpCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnClearCI
            // 
            this.btnClearCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCI.Location = new System.Drawing.Point(350, 323);
            this.btnClearCI.Name = "btnClearCI";
            this.btnClearCI.Size = new System.Drawing.Size(99, 46);
            this.btnClearCI.TabIndex = 69;
            this.btnClearCI.Text = "Clear";
            this.btnClearCI.UseVisualStyleBackColor = true;
            // 
            // lblCIHeader
            // 
            this.lblCIHeader.AutoSize = true;
            this.lblCIHeader.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIHeader.Location = new System.Drawing.Point(290, 32);
            this.lblCIHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCIHeader.Name = "lblCIHeader";
            this.lblCIHeader.Size = new System.Drawing.Size(147, 24);
            this.lblCIHeader.TabIndex = 68;
            this.lblCIHeader.Text = "Item Check In";
            // 
            // lblTimeCI
            // 
            this.lblTimeCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeCI.AutoSize = true;
            this.lblTimeCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCI.Location = new System.Drawing.Point(290, 278);
            this.lblTimeCI.Name = "lblTimeCI";
            this.lblTimeCI.Size = new System.Drawing.Size(85, 19);
            this.lblTimeCI.TabIndex = 67;
            this.lblTimeCI.Text = "Date/Time";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(469, 323);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(99, 46);
            this.btnCheckIn.TabIndex = 66;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblTimeClockCI
            // 
            this.lblTimeClockCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeClockCI.AutoSize = true;
            this.lblTimeClockCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeClockCI.Location = new System.Drawing.Point(410, 278);
            this.lblTimeClockCI.Name = "lblTimeClockCI";
            this.lblTimeClockCI.Size = new System.Drawing.Size(158, 18);
            this.lblTimeClockCI.TabIndex = 65;
            this.lblTimeClockCI.Text = "11/15/2021 10:43 AM";
            // 
            // lblItemIdCI
            // 
            this.lblItemIdCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemIdCI.AutoSize = true;
            this.lblItemIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemIdCI.Location = new System.Drawing.Point(290, 181);
            this.lblItemIdCI.Name = "lblItemIdCI";
            this.lblItemIdCI.Size = new System.Drawing.Size(61, 19);
            this.lblItemIdCI.TabIndex = 64;
            this.lblItemIdCI.Text = "Item ID";
            // 
            // lblItemNameCI
            // 
            this.lblItemNameCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemNameCI.AutoSize = true;
            this.lblItemNameCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameCI.Location = new System.Drawing.Point(290, 231);
            this.lblItemNameCI.Name = "lblItemNameCI";
            this.lblItemNameCI.Size = new System.Drawing.Size(89, 19);
            this.lblItemNameCI.TabIndex = 63;
            this.lblItemNameCI.Text = "Item Name";
            // 
            // lblSvsuIdCI
            // 
            this.lblSvsuIdCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSvsuIdCI.AutoSize = true;
            this.lblSvsuIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvsuIdCI.Location = new System.Drawing.Point(290, 81);
            this.lblSvsuIdCI.Name = "lblSvsuIdCI";
            this.lblSvsuIdCI.Size = new System.Drawing.Size(89, 19);
            this.lblSvsuIdCI.TabIndex = 62;
            this.lblSvsuIdCI.Text = "Student ID";
            // 
            // lblStudentNameCI
            // 
            this.lblStudentNameCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentNameCI.AutoSize = true;
            this.lblStudentNameCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNameCI.Location = new System.Drawing.Point(290, 131);
            this.lblStudentNameCI.Name = "lblStudentNameCI";
            this.lblStudentNameCI.Size = new System.Drawing.Size(117, 19);
            this.lblStudentNameCI.TabIndex = 61;
            this.lblStudentNameCI.Text = "Student Name";
            // 
            // txtItemIdCI
            // 
            this.txtItemIdCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemIdCI.Location = new System.Drawing.Point(413, 178);
            this.txtItemIdCI.Name = "txtItemIdCI";
            this.txtItemIdCI.Size = new System.Drawing.Size(100, 26);
            this.txtItemIdCI.TabIndex = 59;
            // 
            // txtItemNameCI
            // 
            this.txtItemNameCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemNameCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNameCI.Location = new System.Drawing.Point(413, 228);
            this.txtItemNameCI.Name = "txtItemNameCI";
            this.txtItemNameCI.Size = new System.Drawing.Size(219, 26);
            this.txtItemNameCI.TabIndex = 58;
            // 
            // txtStudentNameCI
            // 
            this.txtStudentNameCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentNameCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNameCI.Location = new System.Drawing.Point(413, 128);
            this.txtStudentNameCI.Name = "txtStudentNameCI";
            this.txtStudentNameCI.Size = new System.Drawing.Size(219, 26);
            this.txtStudentNameCI.TabIndex = 57;
            // 
            // tbpCheckOut
            // 
            this.tbpCheckOut.Controls.Add(this.txtSvsuIdCO);
            this.tbpCheckOut.Controls.Add(this.btnClearCO);
            this.tbpCheckOut.Controls.Add(this.lblCOHeader);
            this.tbpCheckOut.Controls.Add(this.lblTimeCO);
            this.tbpCheckOut.Controls.Add(this.btnCheckOut);
            this.tbpCheckOut.Controls.Add(this.lblTimeClockCO);
            this.tbpCheckOut.Controls.Add(this.lblItemIdCO);
            this.tbpCheckOut.Controls.Add(this.lblItemNameCO);
            this.tbpCheckOut.Controls.Add(this.lblSvsuIdCO);
            this.tbpCheckOut.Controls.Add(this.lblStudentNameCO);
            this.tbpCheckOut.Controls.Add(this.txtItemIdCO);
            this.tbpCheckOut.Controls.Add(this.txtItemNameCO);
            this.tbpCheckOut.Controls.Add(this.txtStudentNameCO);
            this.tbpCheckOut.Location = new System.Drawing.Point(4, 25);
            this.tbpCheckOut.Name = "tbpCheckOut";
            this.tbpCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckOut.Size = new System.Drawing.Size(923, 400);
            this.tbpCheckOut.TabIndex = 1;
            this.tbpCheckOut.Text = "Check Out Simulator";
            this.tbpCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnClearCO
            // 
            this.btnClearCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCO.Location = new System.Drawing.Point(350, 323);
            this.btnClearCO.Name = "btnClearCO";
            this.btnClearCO.Size = new System.Drawing.Size(99, 46);
            this.btnClearCO.TabIndex = 56;
            this.btnClearCO.Text = "Clear";
            this.btnClearCO.UseVisualStyleBackColor = true;
            // 
            // lblCOHeader
            // 
            this.lblCOHeader.AutoSize = true;
            this.lblCOHeader.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOHeader.Location = new System.Drawing.Point(290, 32);
            this.lblCOHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCOHeader.Name = "lblCOHeader";
            this.lblCOHeader.Size = new System.Drawing.Size(165, 24);
            this.lblCOHeader.TabIndex = 55;
            this.lblCOHeader.Text = "Item Check Out";
            // 
            // lblTimeCO
            // 
            this.lblTimeCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeCO.AutoSize = true;
            this.lblTimeCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCO.Location = new System.Drawing.Point(290, 278);
            this.lblTimeCO.Name = "lblTimeCO";
            this.lblTimeCO.Size = new System.Drawing.Size(85, 19);
            this.lblTimeCO.TabIndex = 53;
            this.lblTimeCO.Text = "Date/Time";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(469, 323);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(99, 46);
            this.btnCheckOut.TabIndex = 52;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblTimeClockCO
            // 
            this.lblTimeClockCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeClockCO.AutoSize = true;
            this.lblTimeClockCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeClockCO.Location = new System.Drawing.Point(410, 278);
            this.lblTimeClockCO.Name = "lblTimeClockCO";
            this.lblTimeClockCO.Size = new System.Drawing.Size(158, 18);
            this.lblTimeClockCO.TabIndex = 51;
            this.lblTimeClockCO.Text = "11/15/2021 10:43 AM";
            this.lblTimeClockCO.Click += new System.EventHandler(this.lblDateAndTime_Click);
            // 
            // lblItemIdCO
            // 
            this.lblItemIdCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemIdCO.AutoSize = true;
            this.lblItemIdCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemIdCO.Location = new System.Drawing.Point(290, 181);
            this.lblItemIdCO.Name = "lblItemIdCO";
            this.lblItemIdCO.Size = new System.Drawing.Size(61, 19);
            this.lblItemIdCO.TabIndex = 50;
            this.lblItemIdCO.Text = "Item ID";
            // 
            // lblItemNameCO
            // 
            this.lblItemNameCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemNameCO.AutoSize = true;
            this.lblItemNameCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameCO.Location = new System.Drawing.Point(290, 231);
            this.lblItemNameCO.Name = "lblItemNameCO";
            this.lblItemNameCO.Size = new System.Drawing.Size(89, 19);
            this.lblItemNameCO.TabIndex = 49;
            this.lblItemNameCO.Text = "Item Name";
            // 
            // lblSvsuIdCO
            // 
            this.lblSvsuIdCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSvsuIdCO.AutoSize = true;
            this.lblSvsuIdCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvsuIdCO.Location = new System.Drawing.Point(290, 81);
            this.lblSvsuIdCO.Name = "lblSvsuIdCO";
            this.lblSvsuIdCO.Size = new System.Drawing.Size(89, 19);
            this.lblSvsuIdCO.TabIndex = 48;
            this.lblSvsuIdCO.Text = "Student ID";
            // 
            // lblStudentNameCO
            // 
            this.lblStudentNameCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentNameCO.AutoSize = true;
            this.lblStudentNameCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNameCO.Location = new System.Drawing.Point(290, 131);
            this.lblStudentNameCO.Name = "lblStudentNameCO";
            this.lblStudentNameCO.Size = new System.Drawing.Size(117, 19);
            this.lblStudentNameCO.TabIndex = 47;
            this.lblStudentNameCO.Text = "Student Name";
            // 
            // txtItemIdCO
            // 
            this.txtItemIdCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemIdCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemIdCO.Location = new System.Drawing.Point(413, 178);
            this.txtItemIdCO.Name = "txtItemIdCO";
            this.txtItemIdCO.Size = new System.Drawing.Size(100, 26);
            this.txtItemIdCO.TabIndex = 45;
            this.txtItemIdCO.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // txtItemNameCO
            // 
            this.txtItemNameCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemNameCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNameCO.Location = new System.Drawing.Point(413, 228);
            this.txtItemNameCO.Name = "txtItemNameCO";
            this.txtItemNameCO.Size = new System.Drawing.Size(219, 26);
            this.txtItemNameCO.TabIndex = 44;
            this.txtItemNameCO.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // txtStudentNameCO
            // 
            this.txtStudentNameCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentNameCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNameCO.Location = new System.Drawing.Point(413, 128);
            this.txtStudentNameCO.Name = "txtStudentNameCO";
            this.txtStudentNameCO.Size = new System.Drawing.Size(219, 26);
            this.txtStudentNameCO.TabIndex = 43;
            this.txtStudentNameCO.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
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
            // txtSvsuIdCI
            // 
            this.txtSvsuIdCI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSvsuIdCI.Location = new System.Drawing.Point(413, 78);
            this.txtSvsuIdCI.Mask = "000000";
            this.txtSvsuIdCI.Name = "txtSvsuIdCI";
            this.txtSvsuIdCI.Size = new System.Drawing.Size(100, 26);
            this.txtSvsuIdCI.TabIndex = 70;
            this.txtSvsuIdCI.ValidatingType = typeof(int);
            this.txtSvsuIdCI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSvsuIdCI_MaskInputRejected);
            // 
            // txtSvsuIdCO
            // 
            this.txtSvsuIdCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSvsuIdCO.Location = new System.Drawing.Point(413, 78);
            this.txtSvsuIdCO.Mask = "000000";
            this.txtSvsuIdCO.Name = "txtSvsuIdCO";
            this.txtSvsuIdCO.Size = new System.Drawing.Size(100, 26);
            this.txtSvsuIdCO.TabIndex = 71;
            this.txtSvsuIdCO.ValidatingType = typeof(int);
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
        private System.Windows.Forms.Label lblTimeCO;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblTimeClockCO;
        private System.Windows.Forms.Label lblItemIdCO;
        private System.Windows.Forms.Label lblItemNameCO;
        private System.Windows.Forms.Label lblSvsuIdCO;
        private System.Windows.Forms.Label lblStudentNameCO;
        private System.Windows.Forms.TextBox txtItemIdCO;
        private System.Windows.Forms.TextBox txtItemNameCO;
        private System.Windows.Forms.TextBox txtStudentNameCO;
        private System.Windows.Forms.TabPage tbpHandOut;
        private System.Windows.Forms.Button btnClearCI;
        private System.Windows.Forms.Label lblCIHeader;
        private System.Windows.Forms.Label lblTimeCI;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblTimeClockCI;
        private System.Windows.Forms.Label lblItemIdCI;
        private System.Windows.Forms.Label lblItemNameCI;
        private System.Windows.Forms.Label lblSvsuIdCI;
        private System.Windows.Forms.Label lblStudentNameCI;
        private System.Windows.Forms.TextBox txtItemIdCI;
        private System.Windows.Forms.TextBox txtItemNameCI;
        private System.Windows.Forms.TextBox txtStudentNameCI;
        private System.Windows.Forms.Button btnClearCO;
        private System.Windows.Forms.Label lblCOHeader;
        private System.Windows.Forms.MaskedTextBox txtSvsuIdCI;
        private System.Windows.Forms.MaskedTextBox txtSvsuIdCO;
    }
}