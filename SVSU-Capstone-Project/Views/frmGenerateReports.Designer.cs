
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
            this.lblGenorateReports.Location = new System.Drawing.Point(16, 11);
            this.lblGenorateReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenorateReports.Name = "lblGenorateReports";
            this.lblGenorateReports.Size = new System.Drawing.Size(213, 29);
            this.lblGenorateReports.TabIndex = 4;
            this.lblGenorateReports.Text = "Generate Reports";
            // 
            // btnGenorate
            // 
            this.btnGenorate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenorate.Location = new System.Drawing.Point(21, 458);
            this.btnGenorate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenorate.Name = "btnGenorate";
            this.btnGenorate.Size = new System.Drawing.Size(119, 53);
            this.btnGenorate.TabIndex = 9;
            this.btnGenorate.Text = "Generate";
            this.btnGenorate.UseVisualStyleBackColor = true;
            // 
            // btnReportClear
            // 
            this.btnReportClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClear.Location = new System.Drawing.Point(148, 458);
            this.btnReportClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportClear.Name = "btnReportClear";
            this.btnReportClear.Size = new System.Drawing.Size(119, 53);
            this.btnReportClear.TabIndex = 10;
            this.btnReportClear.Text = "Clear";
            this.btnReportClear.UseVisualStyleBackColor = true;
            this.btnReportClear.Click += new System.EventHandler(this.btnReportClear_Click);
            // 
            // lblBeginDate
            // 
            this.lblBeginDate.AutoSize = true;
            this.lblBeginDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginDate.Location = new System.Drawing.Point(16, 86);
            this.lblBeginDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeginDate.Name = "lblBeginDate";
            this.lblBeginDate.Size = new System.Drawing.Size(149, 24);
            this.lblBeginDate.TabIndex = 11;
            this.lblBeginDate.Text = "Begining Date:";
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndingDate.Location = new System.Drawing.Point(35, 143);
            this.lblEndingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(132, 24);
            this.lblEndingDate.TabIndex = 12;
            this.lblEndingDate.Text = "Ending Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Label:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Label:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Label:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Label:";
            // 
            // calBegin
            // 
            this.calBegin.Location = new System.Drawing.Point(489, 81);
            this.calBegin.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calBegin.Name = "calBegin";
            this.calBegin.TabIndex = 17;
            this.calBegin.Visible = false;
            this.calBegin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calBegin_DateChanged);
            // 
            // pcbCalEnd
            // 
            this.pcbCalEnd.Image = global::SVSU_Capstone_Project.Properties.Resources.calendar;
            this.pcbCalEnd.Location = new System.Drawing.Point(440, 138);
            this.pcbCalEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCalEnd.Name = "pcbCalEnd";
            this.pcbCalEnd.Size = new System.Drawing.Size(33, 32);
            this.pcbCalEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCalEnd.TabIndex = 19;
            this.pcbCalEnd.TabStop = false;
            this.pcbCalEnd.Click += new System.EventHandler(this.pcbCalEnd_Click);
            // 
            // pcbCalBegin
            // 
            this.pcbCalBegin.Image = global::SVSU_Capstone_Project.Properties.Resources.calendar;
            this.pcbCalBegin.Location = new System.Drawing.Point(440, 81);
            this.pcbCalBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCalBegin.Name = "pcbCalBegin";
            this.pcbCalBegin.Size = new System.Drawing.Size(33, 32);
            this.pcbCalBegin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCalBegin.TabIndex = 18;
            this.pcbCalBegin.TabStop = false;
            this.pcbCalBegin.Click += new System.EventHandler(this.pcbCalBegin_Click);
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(489, 138);
            this.calEnd.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 22;
            this.calEnd.Visible = false;
            this.calEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEnd_DateChanged);
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeginDate.Location = new System.Drawing.Point(188, 81);
            this.txtBeginDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.ReadOnly = true;
            this.txtBeginDate.Size = new System.Drawing.Size(243, 30);
            this.txtBeginDate.TabIndex = 23;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(188, 138);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(243, 30);
            this.txtEndDate.TabIndex = 24;
            // 
            // frmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 546);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
