
namespace SVSU_Capstone_Project.Views
{
    partial class frmMultipleLocations
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstLocationsAll = new System.Windows.Forms.ListBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstCabinetsAll = new System.Windows.Forms.ListBox();
            this.lstCabinets = new System.Windows.Forms.ListBox();
            this.btnLocationAdd = new System.Windows.Forms.Button();
            this.btnLocationRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCabinetRemove = new System.Windows.Forms.Button();
            this.btnCabinetAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 22);
            this.lblTitle.TabIndex = 95;
            this.lblTitle.Text = "Manage Locations For";
            // 
            // lstLocationsAll
            // 
            this.lstLocationsAll.FormattingEnabled = true;
            this.lstLocationsAll.Location = new System.Drawing.Point(16, 77);
            this.lstLocationsAll.Name = "lstLocationsAll";
            this.lstLocationsAll.Size = new System.Drawing.Size(153, 277);
            this.lstLocationsAll.TabIndex = 96;
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(236, 77);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(153, 277);
            this.lstLocations.TabIndex = 97;
            // 
            // lstCabinetsAll
            // 
            this.lstCabinetsAll.FormattingEnabled = true;
            this.lstCabinetsAll.Location = new System.Drawing.Point(449, 77);
            this.lstCabinetsAll.Name = "lstCabinetsAll";
            this.lstCabinetsAll.Size = new System.Drawing.Size(153, 290);
            this.lstCabinetsAll.TabIndex = 98;
            // 
            // lstCabinets
            // 
            this.lstCabinets.FormattingEnabled = true;
            this.lstCabinets.Location = new System.Drawing.Point(669, 77);
            this.lstCabinets.Name = "lstCabinets";
            this.lstCabinets.Size = new System.Drawing.Size(153, 290);
            this.lstCabinets.TabIndex = 99;
            // 
            // btnLocationAdd
            // 
            this.btnLocationAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationAdd.Location = new System.Drawing.Point(175, 139);
            this.btnLocationAdd.Name = "btnLocationAdd";
            this.btnLocationAdd.Size = new System.Drawing.Size(55, 55);
            this.btnLocationAdd.TabIndex = 100;
            this.btnLocationAdd.Text = "→";
            this.btnLocationAdd.UseVisualStyleBackColor = true;
            // 
            // btnLocationRemove
            // 
            this.btnLocationRemove.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationRemove.Location = new System.Drawing.Point(175, 228);
            this.btnLocationRemove.Name = "btnLocationRemove";
            this.btnLocationRemove.Size = new System.Drawing.Size(55, 55);
            this.btnLocationRemove.TabIndex = 101;
            this.btnLocationRemove.Text = "← ";
            this.btnLocationRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "Locations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 105;
            this.label2.Text = "Cabinets";
            // 
            // btnCabinetRemove
            // 
            this.btnCabinetRemove.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetRemove.Location = new System.Drawing.Point(608, 228);
            this.btnCabinetRemove.Name = "btnCabinetRemove";
            this.btnCabinetRemove.Size = new System.Drawing.Size(55, 55);
            this.btnCabinetRemove.TabIndex = 107;
            this.btnCabinetRemove.Text = "← ";
            this.btnCabinetRemove.UseVisualStyleBackColor = true;
            // 
            // btnCabinetAdd
            // 
            this.btnCabinetAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabinetAdd.Location = new System.Drawing.Point(608, 139);
            this.btnCabinetAdd.Name = "btnCabinetAdd";
            this.btnCabinetAdd.Size = new System.Drawing.Size(55, 55);
            this.btnCabinetAdd.TabIndex = 106;
            this.btnCabinetAdd.Text = "→";
            this.btnCabinetAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(664, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 43);
            this.btnSave.TabIndex = 108;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(758, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 43);
            this.btnCancel.TabIndex = 109;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 110;
            this.label3.Text = "Item\'s Locations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 111;
            this.label4.Text = "Item\'s Cabinets";
            // 
            // frmMultipleLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCabinetRemove);
            this.Controls.Add(this.btnCabinetAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocationRemove);
            this.Controls.Add(this.btnLocationAdd);
            this.Controls.Add(this.lstCabinets);
            this.Controls.Add(this.lstCabinetsAll);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.lstLocationsAll);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMultipleLocations";
            this.Text = "frmMultipleLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstLocationsAll;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstCabinetsAll;
        private System.Windows.Forms.ListBox lstCabinets;
        private System.Windows.Forms.Button btnLocationAdd;
        private System.Windows.Forms.Button btnLocationRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCabinetRemove;
        private System.Windows.Forms.Button btnCabinetAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}