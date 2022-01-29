
namespace SVSU_Capstone_Project.Views
{
    partial class frmAddItems
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbFeatures = new System.Windows.Forms.ComboBox();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.txtLowStock = new System.Windows.Forms.TextBox();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.chkNLevel = new System.Windows.Forms.CheckBox();
            this.cmbNLevel = new System.Windows.Forms.ComboBox();
            this.lblNLevel = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblAddItems = new System.Windows.Forms.Label();
            this.cmbCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.btnManageLocations = new System.Windows.Forms.Button();
            this.chkMultipleLocations = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(114, 133);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(66, 26);
            this.txtQuantity.TabIndex = 83;
            this.txtQuantity.Text = "0";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(114, 321);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(517, 110);
            this.txtDescription.TabIndex = 82;
            this.txtDescription.Text = "";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(472, 133);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(66, 26);
            this.txtCost.TabIndex = 81;
            this.txtCost.Text = "0";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 324);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 19);
            this.lblDescription.TabIndex = 80;
            this.lblDescription.Text = "Description:";
            // 
            // cmbFeatures
            // 
            this.cmbFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeatures.FormattingEnabled = true;
            this.cmbFeatures.Location = new System.Drawing.Point(472, 259);
            this.cmbFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFeatures.Name = "cmbFeatures";
            this.cmbFeatures.Size = new System.Drawing.Size(159, 26);
            this.cmbFeatures.TabIndex = 79;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(386, 262);
            this.lblFeatures.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(82, 19);
            this.lblFeatures.TabIndex = 78;
            this.lblFeatures.Text = "Features:";
            // 
            // txtLowStock
            // 
            this.txtLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowStock.Location = new System.Drawing.Point(472, 216);
            this.txtLowStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtLowStock.Name = "txtLowStock";
            this.txtLowStock.Size = new System.Drawing.Size(66, 26);
            this.txtLowStock.TabIndex = 77;
            this.txtLowStock.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(372, 219);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(96, 19);
            this.lblLowStock.TabIndex = 76;
            this.lblLowStock.Text = "Low Stock:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(472, 175);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(159, 26);
            this.txtLink.TabIndex = 75;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(420, 178);
            this.lblLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(48, 19);
            this.lblLink.TabIndex = 74;
            this.lblLink.Text = "Link:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(417, 133);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(51, 19);
            this.lblCost.TabIndex = 73;
            this.lblCost.Text = "Cost:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(114, 89);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(159, 26);
            this.cmbCategory.TabIndex = 72;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(389, 89);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(79, 19);
            this.lblSupplier.TabIndex = 71;
            this.lblSupplier.Text = "Supplier:";
            // 
            // chkNLevel
            // 
            this.chkNLevel.AutoSize = true;
            this.chkNLevel.Checked = true;
            this.chkNLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNLevel.Location = new System.Drawing.Point(114, 285);
            this.chkNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.chkNLevel.Name = "chkNLevel";
            this.chkNLevel.Size = new System.Drawing.Size(15, 14);
            this.chkNLevel.TabIndex = 70;
            this.chkNLevel.UseVisualStyleBackColor = true;
            this.chkNLevel.CheckedChanged += new System.EventHandler(this.chkNLevel_CheckedChanged);
            // 
            // cmbNLevel
            // 
            this.cmbNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNLevel.FormattingEnabled = true;
            this.cmbNLevel.Location = new System.Drawing.Point(135, 278);
            this.cmbNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNLevel.Name = "cmbNLevel";
            this.cmbNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbNLevel.TabIndex = 69;
            // 
            // lblNLevel
            // 
            this.lblNLevel.AutoSize = true;
            this.lblNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLevel.Location = new System.Drawing.Point(38, 281);
            this.lblNLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNLevel.Name = "lblNLevel";
            this.lblNLevel.Size = new System.Drawing.Size(72, 19);
            this.lblNLevel.TabIndex = 68;
            this.lblNLevel.Text = "N Level:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(114, 178);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(159, 26);
            this.cmbLocation.TabIndex = 67;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(28, 181);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(82, 19);
            this.lblLocation.TabIndex = 66;
            this.lblLocation.Text = "Location:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(31, 136);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 19);
            this.lblQuantity.TabIndex = 65;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(472, 89);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(159, 26);
            this.cmbSupplier.TabIndex = 64;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(25, 92);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 19);
            this.lblCategory.TabIndex = 63;
            this.lblCategory.Text = "Category:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(114, 44);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(254, 26);
            this.txtItemName.TabIndex = 62;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(15, 47);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 19);
            this.lblItemName.TabIndex = 61;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItems.Location = new System.Drawing.Point(12, 9);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(102, 22);
            this.lblAddItems.TabIndex = 84;
            this.lblAddItems.Text = "Add Items";
            // 
            // cmbCabinet
            // 
            this.cmbCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCabinet.FormattingEnabled = true;
            this.cmbCabinet.Location = new System.Drawing.Point(114, 225);
            this.cmbCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCabinet.Name = "cmbCabinet";
            this.cmbCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbCabinet.TabIndex = 86;
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.Location = new System.Drawing.Point(36, 228);
            this.lblCabinet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(74, 19);
            this.lblCabinet.TabIndex = 85;
            this.lblCabinet.Text = "Cabinet:";
            // 
            // btnManageLocations
            // 
            this.btnManageLocations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLocations.Location = new System.Drawing.Point(115, 178);
            this.btnManageLocations.Name = "btnManageLocations";
            this.btnManageLocations.Size = new System.Drawing.Size(158, 26);
            this.btnManageLocations.TabIndex = 88;
            this.btnManageLocations.Text = "Manage Locations";
            this.btnManageLocations.UseVisualStyleBackColor = true;
            this.btnManageLocations.Visible = false;
            this.btnManageLocations.Click += new System.EventHandler(this.btnManageLocations_Click);
            // 
            // chkMultipleLocations
            // 
            this.chkMultipleLocations.AutoSize = true;
            this.chkMultipleLocations.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMultipleLocations.Location = new System.Drawing.Point(225, 256);
            this.chkMultipleLocations.Name = "chkMultipleLocations";
            this.chkMultipleLocations.Size = new System.Drawing.Size(143, 20);
            this.chkMultipleLocations.TabIndex = 89;
            this.chkMultipleLocations.Text = "Multiple Locations";
            this.chkMultipleLocations.UseVisualStyleBackColor = true;
            this.chkMultipleLocations.CheckedChanged += new System.EventHandler(this.chkMultipleLocations_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(758, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 43);
            this.btnCancel.TabIndex = 111;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(664, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 43);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkMultipleLocations);
            this.Controls.Add(this.btnManageLocations);
            this.Controls.Add(this.cmbCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblAddItems);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbFeatures);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.txtLowStock);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.chkNLevel);
            this.Controls.Add(this.cmbNLevel);
            this.Controls.Add(this.lblNLevel);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Name = "frmAddItems";
            this.Text = "Add Items";
            this.Load += new System.EventHandler(this.frmAddItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.RichTextBox txtDescription;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.ComboBox cmbFeatures;
        internal System.Windows.Forms.Label lblFeatures;
        internal System.Windows.Forms.TextBox txtLowStock;
        internal System.Windows.Forms.Label lblLowStock;
        internal System.Windows.Forms.TextBox txtLink;
        internal System.Windows.Forms.Label lblLink;
        internal System.Windows.Forms.Label lblCost;
        internal System.Windows.Forms.ComboBox cmbCategory;
        internal System.Windows.Forms.Label lblSupplier;
        internal System.Windows.Forms.CheckBox chkNLevel;
        internal System.Windows.Forms.ComboBox cmbNLevel;
        internal System.Windows.Forms.Label lblNLevel;
        internal System.Windows.Forms.ComboBox cmbLocation;
        internal System.Windows.Forms.Label lblLocation;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.ComboBox cmbSupplier;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.TextBox txtItemName;
        internal System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblAddItems;
        internal System.Windows.Forms.ComboBox cmbCabinet;
        internal System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Button btnManageLocations;
        private System.Windows.Forms.CheckBox chkMultipleLocations;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}