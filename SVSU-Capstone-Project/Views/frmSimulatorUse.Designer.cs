﻿
namespace SVSU_Capstone_Project.Views
{
    partial class frmSimulatorUse
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
            this.label3 = new System.Windows.Forms.Label();
            this.tabSimulatorUse = new System.Windows.Forms.TabPage();
            this.tbcSimulatorUse = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSimulatorName = new System.Windows.Forms.ComboBox();
            this.dateSimulatorUse = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSimulatorStudent = new System.Windows.Forms.ComboBox();
            this.numSimulatorUsed = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabSimulatorUse.SuspendLayout();
            this.tbcSimulatorUse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulatorUsed)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 103;
            this.label3.Text = "Simulator Use";
            // 
            // tabSimulatorUse
            // 
            this.tabSimulatorUse.Controls.Add(this.btnCancel);
            this.tabSimulatorUse.Controls.Add(this.btnSave);
            this.tabSimulatorUse.Controls.Add(this.numSimulatorUsed);
            this.tabSimulatorUse.Controls.Add(this.cmbSimulatorStudent);
            this.tabSimulatorUse.Controls.Add(this.label5);
            this.tabSimulatorUse.Controls.Add(this.dateSimulatorUse);
            this.tabSimulatorUse.Controls.Add(this.cmbSimulatorName);
            this.tabSimulatorUse.Controls.Add(this.label4);
            this.tabSimulatorUse.Controls.Add(this.label2);
            this.tabSimulatorUse.Controls.Add(this.label1);
            this.tabSimulatorUse.Controls.Add(this.label3);
            this.tabSimulatorUse.Location = new System.Drawing.Point(4, 25);
            this.tabSimulatorUse.Name = "tabSimulatorUse";
            this.tabSimulatorUse.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulatorUse.Size = new System.Drawing.Size(1242, 505);
            this.tabSimulatorUse.TabIndex = 0;
            this.tabSimulatorUse.Text = "Simulator Use";
            this.tabSimulatorUse.UseVisualStyleBackColor = true;
            // 
            // tbcSimulatorUse
            // 
            this.tbcSimulatorUse.Controls.Add(this.tabSimulatorUse);
            this.tbcSimulatorUse.Location = new System.Drawing.Point(12, 12);
            this.tbcSimulatorUse.Name = "tbcSimulatorUse";
            this.tbcSimulatorUse.SelectedIndex = 0;
            this.tbcSimulatorUse.Size = new System.Drawing.Size(1250, 534);
            this.tbcSimulatorUse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 104;
            this.label1.Text = "Simulator Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 105;
            this.label2.Text = "Date Used:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(49, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 106;
            this.label4.Text = "Hours Used:";
            // 
            // cmbSimulatorName
            // 
            this.cmbSimulatorName.FormattingEnabled = true;
            this.cmbSimulatorName.Location = new System.Drawing.Point(271, 94);
            this.cmbSimulatorName.Name = "cmbSimulatorName";
            this.cmbSimulatorName.Size = new System.Drawing.Size(263, 24);
            this.cmbSimulatorName.TabIndex = 107;
            // 
            // dateSimulatorUse
            // 
            this.dateSimulatorUse.Location = new System.Drawing.Point(271, 236);
            this.dateSimulatorUse.Name = "dateSimulatorUse";
            this.dateSimulatorUse.Size = new System.Drawing.Size(263, 22);
            this.dateSimulatorUse.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(49, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Student:";
            // 
            // cmbSimulatorStudent
            // 
            this.cmbSimulatorStudent.FormattingEnabled = true;
            this.cmbSimulatorStudent.Location = new System.Drawing.Point(271, 163);
            this.cmbSimulatorStudent.Name = "cmbSimulatorStudent";
            this.cmbSimulatorStudent.Size = new System.Drawing.Size(263, 24);
            this.cmbSimulatorStudent.TabIndex = 110;
            // 
            // numSimulatorUsed
            // 
            this.numSimulatorUsed.Location = new System.Drawing.Point(271, 305);
            this.numSimulatorUsed.Name = "numSimulatorUsed";
            this.numSimulatorUsed.Size = new System.Drawing.Size(120, 22);
            this.numSimulatorUsed.TabIndex = 111;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(662, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 55);
            this.btnSave.TabIndex = 112;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(801, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 55);
            this.btnCancel.TabIndex = 113;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSimulatorUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 558);
            this.Controls.Add(this.tbcSimulatorUse);
            this.Name = "frmSimulatorUse";
            this.Text = "frmSimulatorUse";
            this.Load += new System.EventHandler(this.frmSimulatorUse_Load);
            this.tabSimulatorUse.ResumeLayout(false);
            this.tabSimulatorUse.PerformLayout();
            this.tbcSimulatorUse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSimulatorUsed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabSimulatorUse;
        private System.Windows.Forms.TabControl tbcSimulatorUse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSimulatorUse;
        private System.Windows.Forms.ComboBox cmbSimulatorName;
        private System.Windows.Forms.NumericUpDown numSimulatorUsed;
        private System.Windows.Forms.ComboBox cmbSimulatorStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}