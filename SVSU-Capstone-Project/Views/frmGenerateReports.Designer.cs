
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
            this.lblBeginDate = new System.Windows.Forms.Label();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.pcbCalEnd = new System.Windows.Forms.PictureBox();
            this.pcbCalBegin = new System.Windows.Forms.PictureBox();
            this.txtBeginDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.invDbDataSet1 = new SVSU_Capstone_Project.InvDbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).BeginInit();
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
            // pcbCalEnd
            // 
            this.pcbCalEnd.Image = global::SVSU_Capstone_Project.Properties.Resources.calendar;
            this.pcbCalEnd.Location = new System.Drawing.Point(440, 138);
            this.pcbCalEnd.Margin = new System.Windows.Forms.Padding(4);
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
            this.pcbCalBegin.Margin = new System.Windows.Forms.Padding(4);
            this.pcbCalBegin.Name = "pcbCalBegin";
            this.pcbCalBegin.Size = new System.Drawing.Size(33, 32);
            this.pcbCalBegin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCalBegin.TabIndex = 18;
            this.pcbCalBegin.TabStop = false;
            this.pcbCalBegin.Click += new System.EventHandler(this.pcbCalBegin_Click);
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeginDate.Location = new System.Drawing.Point(188, 81);
            this.txtBeginDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.ReadOnly = true;
            this.txtBeginDate.Size = new System.Drawing.Size(243, 30);
            this.txtBeginDate.TabIndex = 23;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(188, 138);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(243, 30);
            this.txtEndDate.TabIndex = 24;
            // 
            // invDbDataSet1
            // 
            this.invDbDataSet1.DataSetName = "InvDbDataSet";
            this.invDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Controls.Add(this.lblEndingDate);
            this.Controls.Add(this.lblBeginDate);
            this.Controls.Add(this.lblGenorateReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGenerateReports";
            this.Text = "frmGenerateReports";
            this.Load += new System.EventHandler(this.frmGenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenorateReports;
        private System.Windows.Forms.Label lblBeginDate;
        private System.Windows.Forms.Label lblEndingDate;
        private System.Windows.Forms.PictureBox pcbCalBegin;
        private System.Windows.Forms.PictureBox pcbCalEnd;
        private System.Windows.Forms.TextBox txtBeginDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private InvDbDataSet invDbDataSet1;
    }
}
