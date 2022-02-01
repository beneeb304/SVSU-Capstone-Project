
namespace SVSU_Capstone_Project.Views
{
    partial class frmManageInventory
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
            this.tbpAddItems = new System.Windows.Forms.TabPage();
            this.tbpCreateItem = new System.Windows.Forms.TabPage();
            this.tbpDeleteItem = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkMultipleLocations = new System.Windows.Forms.CheckBox();
            this.btnManageLocations = new System.Windows.Forms.Button();
            this.cmbCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tbpCreateItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAddItems);
            this.tabControl1.Controls.Add(this.tbpCreateItem);
            this.tabControl1.Controls.Add(this.tbpDeleteItem);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpAddItems
            // 
            this.tbpAddItems.Location = new System.Drawing.Point(4, 22);
            this.tbpAddItems.Name = "tbpAddItems";
            this.tbpAddItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddItems.Size = new System.Drawing.Size(923, 403);
            this.tbpAddItems.TabIndex = 0;
            this.tbpAddItems.Text = "Add Item Quantity";
            this.tbpAddItems.UseVisualStyleBackColor = true;
            // 
            // tbpCreateItem
            // 
            this.tbpCreateItem.Controls.Add(this.btnCancel);
            this.tbpCreateItem.Controls.Add(this.btnSave);
            this.tbpCreateItem.Controls.Add(this.chkMultipleLocations);
            this.tbpCreateItem.Controls.Add(this.btnManageLocations);
            this.tbpCreateItem.Controls.Add(this.cmbCabinet);
            this.tbpCreateItem.Controls.Add(this.lblCabinet);
            this.tbpCreateItem.Controls.Add(this.txtQuantity);
            this.tbpCreateItem.Controls.Add(this.txtDescription);
            this.tbpCreateItem.Controls.Add(this.txtCost);
            this.tbpCreateItem.Controls.Add(this.lblDescription);
            this.tbpCreateItem.Controls.Add(this.cmbFeatures);
            this.tbpCreateItem.Controls.Add(this.lblFeatures);
            this.tbpCreateItem.Controls.Add(this.txtLowStock);
            this.tbpCreateItem.Controls.Add(this.lblLowStock);
            this.tbpCreateItem.Controls.Add(this.txtLink);
            this.tbpCreateItem.Controls.Add(this.lblLink);
            this.tbpCreateItem.Controls.Add(this.lblCost);
            this.tbpCreateItem.Controls.Add(this.cmbCategory);
            this.tbpCreateItem.Controls.Add(this.lblSupplier);
            this.tbpCreateItem.Controls.Add(this.chkNLevel);
            this.tbpCreateItem.Controls.Add(this.cmbNLevel);
            this.tbpCreateItem.Controls.Add(this.lblNLevel);
            this.tbpCreateItem.Controls.Add(this.cmbLocation);
            this.tbpCreateItem.Controls.Add(this.lblLocation);
            this.tbpCreateItem.Controls.Add(this.lblQuantity);
            this.tbpCreateItem.Controls.Add(this.cmbSupplier);
            this.tbpCreateItem.Controls.Add(this.lblCategory);
            this.tbpCreateItem.Controls.Add(this.txtItemName);
            this.tbpCreateItem.Controls.Add(this.lblItemName);
            this.tbpCreateItem.Location = new System.Drawing.Point(4, 22);
            this.tbpCreateItem.Name = "tbpCreateItem";
            this.tbpCreateItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateItem.Size = new System.Drawing.Size(923, 403);
            this.tbpCreateItem.TabIndex = 1;
            this.tbpCreateItem.Text = "Create Item";
            this.tbpCreateItem.UseVisualStyleBackColor = true;
            // 
            // tbpDeleteItem
            // 
            this.tbpDeleteItem.Location = new System.Drawing.Point(4, 22);
            this.tbpDeleteItem.Name = "tbpDeleteItem";
            this.tbpDeleteItem.Size = new System.Drawing.Size(923, 403);
            this.tbpDeleteItem.TabIndex = 2;
            this.tbpDeleteItem.Text = "Delete Item";
            this.tbpDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(778, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 43);
            this.btnCancel.TabIndex = 141;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(684, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 43);
            this.btnSave.TabIndex = 140;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chkMultipleLocations
            // 
            this.chkMultipleLocations.AutoSize = true;
            this.chkMultipleLocations.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMultipleLocations.Location = new System.Drawing.Point(245, 222);
            this.chkMultipleLocations.Name = "chkMultipleLocations";
            this.chkMultipleLocations.Size = new System.Drawing.Size(143, 20);
            this.chkMultipleLocations.TabIndex = 139;
            this.chkMultipleLocations.Text = "Multiple Locations";
            this.chkMultipleLocations.UseVisualStyleBackColor = true;
            // 
            // btnManageLocations
            // 
            this.btnManageLocations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLocations.Location = new System.Drawing.Point(135, 144);
            this.btnManageLocations.Name = "btnManageLocations";
            this.btnManageLocations.Size = new System.Drawing.Size(158, 26);
            this.btnManageLocations.TabIndex = 138;
            this.btnManageLocations.Text = "Manage Locations";
            this.btnManageLocations.UseVisualStyleBackColor = true;
            this.btnManageLocations.Visible = false;
            // 
            // cmbCabinet
            // 
            this.cmbCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCabinet.FormattingEnabled = true;
            this.cmbCabinet.Location = new System.Drawing.Point(134, 191);
            this.cmbCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCabinet.Name = "cmbCabinet";
            this.cmbCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbCabinet.TabIndex = 137;
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.Location = new System.Drawing.Point(56, 194);
            this.lblCabinet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(74, 19);
            this.lblCabinet.TabIndex = 136;
            this.lblCabinet.Text = "Cabinet:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(134, 99);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(66, 26);
            this.txtQuantity.TabIndex = 134;
            this.txtQuantity.Text = "0";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(134, 287);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(517, 110);
            this.txtDescription.TabIndex = 133;
            this.txtDescription.Text = "";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(492, 99);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(66, 26);
            this.txtCost.TabIndex = 132;
            this.txtCost.Text = "0";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(27, 290);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 19);
            this.lblDescription.TabIndex = 131;
            this.lblDescription.Text = "Description:";
            // 
            // cmbFeatures
            // 
            this.cmbFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeatures.FormattingEnabled = true;
            this.cmbFeatures.Location = new System.Drawing.Point(492, 225);
            this.cmbFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFeatures.Name = "cmbFeatures";
            this.cmbFeatures.Size = new System.Drawing.Size(159, 26);
            this.cmbFeatures.TabIndex = 130;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(406, 228);
            this.lblFeatures.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(82, 19);
            this.lblFeatures.TabIndex = 129;
            this.lblFeatures.Text = "Features:";
            // 
            // txtLowStock
            // 
            this.txtLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowStock.Location = new System.Drawing.Point(492, 182);
            this.txtLowStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtLowStock.Name = "txtLowStock";
            this.txtLowStock.Size = new System.Drawing.Size(66, 26);
            this.txtLowStock.TabIndex = 128;
            this.txtLowStock.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(392, 185);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(96, 19);
            this.lblLowStock.TabIndex = 127;
            this.lblLowStock.Text = "Low Stock:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(492, 141);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(159, 26);
            this.txtLink.TabIndex = 126;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(440, 144);
            this.lblLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(48, 19);
            this.lblLink.TabIndex = 125;
            this.lblLink.Text = "Link:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(437, 99);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(51, 19);
            this.lblCost.TabIndex = 124;
            this.lblCost.Text = "Cost:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(134, 55);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(159, 26);
            this.cmbCategory.TabIndex = 123;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(409, 55);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(79, 19);
            this.lblSupplier.TabIndex = 122;
            this.lblSupplier.Text = "Supplier:";
            // 
            // chkNLevel
            // 
            this.chkNLevel.AutoSize = true;
            this.chkNLevel.Checked = true;
            this.chkNLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNLevel.Location = new System.Drawing.Point(134, 251);
            this.chkNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.chkNLevel.Name = "chkNLevel";
            this.chkNLevel.Size = new System.Drawing.Size(15, 14);
            this.chkNLevel.TabIndex = 121;
            this.chkNLevel.UseVisualStyleBackColor = true;
            // 
            // cmbNLevel
            // 
            this.cmbNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNLevel.FormattingEnabled = true;
            this.cmbNLevel.Location = new System.Drawing.Point(155, 244);
            this.cmbNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNLevel.Name = "cmbNLevel";
            this.cmbNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbNLevel.TabIndex = 120;
            // 
            // lblNLevel
            // 
            this.lblNLevel.AutoSize = true;
            this.lblNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLevel.Location = new System.Drawing.Point(58, 247);
            this.lblNLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNLevel.Name = "lblNLevel";
            this.lblNLevel.Size = new System.Drawing.Size(72, 19);
            this.lblNLevel.TabIndex = 119;
            this.lblNLevel.Text = "N Level:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(134, 144);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(159, 26);
            this.cmbLocation.TabIndex = 118;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(48, 147);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(82, 19);
            this.lblLocation.TabIndex = 117;
            this.lblLocation.Text = "Location:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(51, 102);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 19);
            this.lblQuantity.TabIndex = 116;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(492, 55);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(159, 26);
            this.cmbSupplier.TabIndex = 115;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(45, 58);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 19);
            this.lblCategory.TabIndex = 114;
            this.lblCategory.Text = "Category:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(134, 10);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(254, 26);
            this.txtItemName.TabIndex = 113;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(35, 13);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 19);
            this.lblItemName.TabIndex = 112;
            this.lblItemName.Text = "Item Name:";
            // 
            // frmManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmManageInventory";
            this.Text = "Manage Inventory";
            this.tabControl1.ResumeLayout(false);
            this.tbpCreateItem.ResumeLayout(false);
            this.tbpCreateItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpAddItems;
        private System.Windows.Forms.TabPage tbpCreateItem;
        private System.Windows.Forms.TabPage tbpDeleteItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkMultipleLocations;
        private System.Windows.Forms.Button btnManageLocations;
        internal System.Windows.Forms.ComboBox cmbCabinet;
        internal System.Windows.Forms.Label lblCabinet;
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
    }
}