
namespace SVSU_Capstone_Project.Views
{
    partial class frmGenerateReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.lblGenorateReports = new System.Windows.Forms.Label();
            this.btnGenorate = new System.Windows.Forms.Button();
            this.btnReportClear = new System.Windows.Forms.Button();
            this.lblBeginDate = new System.Windows.Forms.Label();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calBegin = new System.Windows.Forms.MonthCalendar();
            this.pcbCalEnd = new System.Windows.Forms.PictureBox();
            this.pcbCalBegin = new System.Windows.Forms.PictureBox();
            this.calEnd = new System.Windows.Forms.MonthCalendar();
            this.txtBeginDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalBegin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenorateReports
            // 
            this.lblGenorateReports.AutoSize = true;
            this.lblGenorateReports.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenorateReports.Location = new System.Drawing.Point(12, 9);
            this.lblGenorateReports.Name = "lblGenorateReports";
            this.lblGenorateReports.Size = new System.Drawing.Size(173, 22);
            this.lblGenorateReports.TabIndex = 4;
            this.lblGenorateReports.Text = "Generate Reports";
            // 
            // btnGenorate
            // 
            this.btnGenorate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenorate.Location = new System.Drawing.Point(111, 372);
            this.btnGenorate.Name = "btnGenorate";
            this.btnGenorate.Size = new System.Drawing.Size(89, 43);
            this.btnGenorate.TabIndex = 9;
            this.btnGenorate.Text = "Generate";
            this.btnGenorate.UseVisualStyleBackColor = true;
            // 
            // btnReportClear
            // 
            this.btnReportClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClear.Location = new System.Drawing.Point(16, 372);
            this.btnReportClear.Name = "btnReportClear";
            this.btnReportClear.Size = new System.Drawing.Size(89, 43);
            this.btnReportClear.TabIndex = 10;
            this.btnReportClear.Text = "Clear";
            this.btnReportClear.UseVisualStyleBackColor = true;
            this.btnReportClear.Click += new System.EventHandler(this.btnReportClear_Click);
            // 
            // lblBeginDate
            // 
            this.lblBeginDate.AutoSize = true;
            this.lblBeginDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginDate.Location = new System.Drawing.Point(12, 70);
            this.lblBeginDate.Name = "lblBeginDate";
            this.lblBeginDate.Size = new System.Drawing.Size(123, 19);
            this.lblBeginDate.TabIndex = 11;
            this.lblBeginDate.Text = "Begining Date:";
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndingDate.Location = new System.Drawing.Point(26, 116);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(109, 19);
            this.lblEndingDate.TabIndex = 12;
            this.lblEndingDate.Text = "Ending Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Label:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Label:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Label:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Label:";
            // 
            // calBegin
            // 
            this.calBegin.Location = new System.Drawing.Point(367, 66);
            this.calBegin.Name = "calBegin";
            this.calBegin.TabIndex = 17;
            this.calBegin.Visible = false;
            this.calBegin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calBegin_DateChanged);
            // 
            // pcbCalEnd
            // 
            this.pcbCalEnd.Image = global::SVSU_Capstone_Project.Properties.Resources.calendar;
            this.pcbCalEnd.Location = new System.Drawing.Point(330, 112);
            this.pcbCalEnd.Name = "pcbCalEnd";
            this.pcbCalEnd.Size = new System.Drawing.Size(25, 26);
            this.pcbCalEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCalEnd.TabIndex = 19;
            this.pcbCalEnd.TabStop = false;
            this.pcbCalEnd.Click += new System.EventHandler(this.pcbCalEnd_Click);
            // 
            // pcbCalBegin
            // 
            this.pcbCalBegin.Image = global::SVSU_Capstone_Project.Properties.Resources.calendar;
            this.pcbCalBegin.Location = new System.Drawing.Point(330, 66);
            this.pcbCalBegin.Name = "pcbCalBegin";
            this.pcbCalBegin.Size = new System.Drawing.Size(25, 26);
            this.pcbCalBegin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCalBegin.TabIndex = 18;
            this.pcbCalBegin.TabStop = false;
            this.pcbCalBegin.Click += new System.EventHandler(this.pcbCalBegin_Click);
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(367, 112);
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 22;
            this.calEnd.Visible = false;
            this.calEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEnd_DateChanged);
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeginDate.Location = new System.Drawing.Point(141, 66);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.ReadOnly = true;
            this.txtBeginDate.Size = new System.Drawing.Size(183, 26);
            this.txtBeginDate.TabIndex = 23;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(141, 112);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(183, 26);
            this.txtEndDate.TabIndex = 24;
            // 
            // frmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 444);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtBeginDate);
            this.Controls.Add(this.pcbCalEnd);
            this.Controls.Add(this.pcbCalBegin);
            this.Controls.Add(this.calBegin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEndingDate);
            this.Controls.Add(this.lblBeginDate);
            this.Controls.Add(this.btnReportClear);
            this.Controls.Add(this.btnGenorate);
            this.Controls.Add(this.lblGenorateReports);
            this.Controls.Add(this.calEnd);
            this.Name = "frmGenerateReports";
            this.Text = "frmGenerateReports";
            this.Load += new System.EventHandler(this.frmGenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalBegin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenorateReports;
        private System.Windows.Forms.Button btnGenorate;
        private System.Windows.Forms.Button btnReportClear;
        private System.Windows.Forms.Label lblBeginDate;
        private System.Windows.Forms.Label lblEndingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar calBegin;
        private System.Windows.Forms.PictureBox pcbCalBegin;
        private System.Windows.Forms.PictureBox pcbCalEnd;
        private System.Windows.Forms.MonthCalendar calEnd;
        private System.Windows.Forms.TextBox txtBeginDate;
        private System.Windows.Forms.TextBox txtEndDate;
    }
}
