
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
            this.nudCreateQty = new System.Windows.Forms.NumericUpDown();
            this.txtCreateFeatures = new System.Windows.Forms.TextBox();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCreateCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.txtCreateDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.txtCreateUrl = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.cmbCreateCategory = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbCreateNLevel = new System.Windows.Forms.ComboBox();
            this.lblNLevel = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbCreateVendor = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCreateItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbpDeleteItem = new System.Windows.Forms.TabPage();
            this.nudCreateAlertQty = new System.Windows.Forms.NumericUpDown();
            this.mtxCreateCost = new System.Windows.Forms.MaskedTextBox();
            this.cmbCreateRoom = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbAddCabinet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAddNLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAddRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAddCommodity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAddQty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDeleteCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDeleteCommodity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDeleteCabinet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDeleteNLevel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbDeleteRoom = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpAddItems.SuspendLayout();
            this.tbpCreateItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateQty)).BeginInit();
            this.tbpDeleteItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateAlertQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).BeginInit();
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
            this.tbpAddItems.Controls.Add(this.cmbAddCategory);
            this.tbpAddItems.Controls.Add(this.label9);
            this.tbpAddItems.Controls.Add(this.btnAddCancel);
            this.tbpAddItems.Controls.Add(this.btnAdd);
            this.tbpAddItems.Controls.Add(this.label7);
            this.tbpAddItems.Controls.Add(this.label6);
            this.tbpAddItems.Controls.Add(this.nudAddQty);
            this.tbpAddItems.Controls.Add(this.label5);
            this.tbpAddItems.Controls.Add(this.txtCurrentQty);
            this.tbpAddItems.Controls.Add(this.cmbAddCommodity);
            this.tbpAddItems.Controls.Add(this.label4);
            this.tbpAddItems.Controls.Add(this.cmbAddCabinet);
            this.tbpAddItems.Controls.Add(this.label1);
            this.tbpAddItems.Controls.Add(this.cmbAddNLevel);
            this.tbpAddItems.Controls.Add(this.label2);
            this.tbpAddItems.Controls.Add(this.cmbAddRoom);
            this.tbpAddItems.Controls.Add(this.label3);
            this.tbpAddItems.Location = new System.Drawing.Point(4, 22);
            this.tbpAddItems.Name = "tbpAddItems";
            this.tbpAddItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddItems.Size = new System.Drawing.Size(923, 403);
            this.tbpAddItems.TabIndex = 0;
            this.tbpAddItems.Text = "Add Quantity for Existing Item";
            this.tbpAddItems.UseVisualStyleBackColor = true;
            // 
            // tbpCreateItem
            // 
            this.tbpCreateItem.Controls.Add(this.mtxCreateCost);
            this.tbpCreateItem.Controls.Add(this.nudCreateAlertQty);
            this.tbpCreateItem.Controls.Add(this.nudCreateQty);
            this.tbpCreateItem.Controls.Add(this.txtCreateFeatures);
            this.tbpCreateItem.Controls.Add(this.btnCreateCancel);
            this.tbpCreateItem.Controls.Add(this.btnCreate);
            this.tbpCreateItem.Controls.Add(this.cmbCreateCabinet);
            this.tbpCreateItem.Controls.Add(this.lblCabinet);
            this.tbpCreateItem.Controls.Add(this.txtCreateDescription);
            this.tbpCreateItem.Controls.Add(this.lblDescription);
            this.tbpCreateItem.Controls.Add(this.lblFeatures);
            this.tbpCreateItem.Controls.Add(this.lblLowStock);
            this.tbpCreateItem.Controls.Add(this.txtCreateUrl);
            this.tbpCreateItem.Controls.Add(this.lblLink);
            this.tbpCreateItem.Controls.Add(this.lblCost);
            this.tbpCreateItem.Controls.Add(this.cmbCreateCategory);
            this.tbpCreateItem.Controls.Add(this.lblSupplier);
            this.tbpCreateItem.Controls.Add(this.cmbCreateNLevel);
            this.tbpCreateItem.Controls.Add(this.lblNLevel);
            this.tbpCreateItem.Controls.Add(this.cmbCreateRoom);
            this.tbpCreateItem.Controls.Add(this.lblLocation);
            this.tbpCreateItem.Controls.Add(this.lblQuantity);
            this.tbpCreateItem.Controls.Add(this.cmbCreateVendor);
            this.tbpCreateItem.Controls.Add(this.lblCategory);
            this.tbpCreateItem.Controls.Add(this.txtCreateItemName);
            this.tbpCreateItem.Controls.Add(this.lblItemName);
            this.tbpCreateItem.Location = new System.Drawing.Point(4, 22);
            this.tbpCreateItem.Name = "tbpCreateItem";
            this.tbpCreateItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateItem.Size = new System.Drawing.Size(923, 403);
            this.tbpCreateItem.TabIndex = 1;
            this.tbpCreateItem.Text = "Create New Item";
            this.tbpCreateItem.UseVisualStyleBackColor = true;
            // 
            // nudCreateQty
            // 
            this.nudCreateQty.Location = new System.Drawing.Point(134, 101);
            this.nudCreateQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreateQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCreateQty.Name = "nudCreateQty";
            this.nudCreateQty.Size = new System.Drawing.Size(120, 20);
            this.nudCreateQty.TabIndex = 143;
            this.nudCreateQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCreateFeatures
            // 
            this.txtCreateFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateFeatures.Location = new System.Drawing.Point(492, 225);
            this.txtCreateFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateFeatures.Name = "txtCreateFeatures";
            this.txtCreateFeatures.Size = new System.Drawing.Size(159, 26);
            this.txtCreateFeatures.TabIndex = 142;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCancel.Location = new System.Drawing.Point(778, 354);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(77, 43);
            this.btnCreateCancel.TabIndex = 141;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = true;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(684, 354);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 43);
            this.btnCreate.TabIndex = 140;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // cmbCreateCabinet
            // 
            this.cmbCreateCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCabinet.FormattingEnabled = true;
            this.cmbCreateCabinet.Location = new System.Drawing.Point(134, 191);
            this.cmbCreateCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateCabinet.Name = "cmbCreateCabinet";
            this.cmbCreateCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbCreateCabinet.TabIndex = 137;
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
            // txtCreateDescription
            // 
            this.txtCreateDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateDescription.Location = new System.Drawing.Point(134, 287);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(313, 110);
            this.txtCreateDescription.TabIndex = 133;
            this.txtCreateDescription.Text = "";
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
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(370, 185);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(118, 19);
            this.lblLowStock.TabIndex = 127;
            this.lblLowStock.Text = "Alert Quantity:";
            // 
            // txtCreateUrl
            // 
            this.txtCreateUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUrl.Location = new System.Drawing.Point(492, 141);
            this.txtCreateUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateUrl.Name = "txtCreateUrl";
            this.txtCreateUrl.Size = new System.Drawing.Size(159, 26);
            this.txtCreateUrl.TabIndex = 126;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(403, 144);
            this.lblLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(85, 19);
            this.lblLink.TabIndex = 125;
            this.lblLink.Text = "Item URL:";
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
            // cmbCreateCategory
            // 
            this.cmbCreateCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCategory.FormattingEnabled = true;
            this.cmbCreateCategory.Location = new System.Drawing.Point(134, 55);
            this.cmbCreateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateCategory.Name = "cmbCreateCategory";
            this.cmbCreateCategory.Size = new System.Drawing.Size(159, 26);
            this.cmbCreateCategory.TabIndex = 123;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(409, 55);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 19);
            this.lblSupplier.TabIndex = 122;
            this.lblSupplier.Text = "Vendor:";
            // 
            // cmbCreateNLevel
            // 
            this.cmbCreateNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateNLevel.FormattingEnabled = true;
            this.cmbCreateNLevel.Location = new System.Drawing.Point(134, 244);
            this.cmbCreateNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateNLevel.Name = "cmbCreateNLevel";
            this.cmbCreateNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbCreateNLevel.TabIndex = 120;
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
            // cmbCreateVendor
            // 
            this.cmbCreateVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateVendor.FormattingEnabled = true;
            this.cmbCreateVendor.Location = new System.Drawing.Point(483, 52);
            this.cmbCreateVendor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateVendor.Name = "cmbCreateVendor";
            this.cmbCreateVendor.Size = new System.Drawing.Size(159, 26);
            this.cmbCreateVendor.TabIndex = 115;
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
            // txtCreateItemName
            // 
            this.txtCreateItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateItemName.Location = new System.Drawing.Point(134, 10);
            this.txtCreateItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateItemName.Name = "txtCreateItemName";
            this.txtCreateItemName.Size = new System.Drawing.Size(254, 26);
            this.txtCreateItemName.TabIndex = 113;
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
            // tbpDeleteItem
            // 
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteCategory);
            this.tbpDeleteItem.Controls.Add(this.label8);
            this.tbpDeleteItem.Controls.Add(this.label10);
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteCommodity);
            this.tbpDeleteItem.Controls.Add(this.label11);
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteCabinet);
            this.tbpDeleteItem.Controls.Add(this.label12);
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteNLevel);
            this.tbpDeleteItem.Controls.Add(this.label13);
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteRoom);
            this.tbpDeleteItem.Controls.Add(this.label14);
            this.tbpDeleteItem.Controls.Add(this.btnDeleteCancel);
            this.tbpDeleteItem.Controls.Add(this.btnDelete);
            this.tbpDeleteItem.Location = new System.Drawing.Point(4, 22);
            this.tbpDeleteItem.Name = "tbpDeleteItem";
            this.tbpDeleteItem.Size = new System.Drawing.Size(923, 403);
            this.tbpDeleteItem.TabIndex = 2;
            this.tbpDeleteItem.Text = "Delete Existing Item";
            this.tbpDeleteItem.UseVisualStyleBackColor = true;
            // 
            // nudCreateAlertQty
            // 
            this.nudCreateAlertQty.Location = new System.Drawing.Point(493, 184);
            this.nudCreateAlertQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreateAlertQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCreateAlertQty.Name = "nudCreateAlertQty";
            this.nudCreateAlertQty.Size = new System.Drawing.Size(120, 20);
            this.nudCreateAlertQty.TabIndex = 145;
            this.nudCreateAlertQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mtxCreateCost
            // 
            this.mtxCreateCost.Location = new System.Drawing.Point(493, 98);
            this.mtxCreateCost.Mask = "$9999999.00";
            this.mtxCreateCost.Name = "mtxCreateCost";
            this.mtxCreateCost.Size = new System.Drawing.Size(100, 20);
            this.mtxCreateCost.TabIndex = 146;
            this.mtxCreateCost.ValidatingType = typeof(int);
            // 
            // cmbCreateRoom
            // 
            this.cmbCreateRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateRoom.FormattingEnabled = true;
            this.cmbCreateRoom.Location = new System.Drawing.Point(134, 144);
            this.cmbCreateRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateRoom.Name = "cmbCreateRoom";
            this.cmbCreateRoom.Size = new System.Drawing.Size(159, 26);
            this.cmbCreateRoom.TabIndex = 118;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(69, 147);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 19);
            this.lblLocation.TabIndex = 117;
            this.lblLocation.Text = "Room:";
            // 
            // cmbAddCabinet
            // 
            this.cmbAddCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCabinet.FormattingEnabled = true;
            this.cmbAddCabinet.Location = new System.Drawing.Point(117, 208);
            this.cmbAddCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCabinet.Name = "cmbAddCabinet";
            this.cmbAddCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCabinet.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 142;
            this.label1.Text = "Cabinet:";
            // 
            // cmbAddNLevel
            // 
            this.cmbAddNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddNLevel.FormattingEnabled = true;
            this.cmbAddNLevel.Location = new System.Drawing.Point(117, 261);
            this.cmbAddNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddNLevel.Name = "cmbAddNLevel";
            this.cmbAddNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbAddNLevel.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 140;
            this.label2.Text = "N Level:";
            // 
            // cmbAddRoom
            // 
            this.cmbAddRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddRoom.FormattingEnabled = true;
            this.cmbAddRoom.Location = new System.Drawing.Point(117, 161);
            this.cmbAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddRoom.Name = "cmbAddRoom";
            this.cmbAddRoom.Size = new System.Drawing.Size(159, 26);
            this.cmbAddRoom.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 138;
            this.label3.Text = "Room:";
            // 
            // cmbAddCommodity
            // 
            this.cmbAddCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCommodity.FormattingEnabled = true;
            this.cmbAddCommodity.Location = new System.Drawing.Point(129, 61);
            this.cmbAddCommodity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCommodity.Name = "cmbAddCommodity";
            this.cmbAddCommodity.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCommodity.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 144;
            this.label4.Text = "Commodity:";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Location = new System.Drawing.Point(495, 212);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentQty.TabIndex = 146;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 147;
            this.label5.Text = "Current Quantity:";
            // 
            // nudAddQty
            // 
            this.nudAddQty.Location = new System.Drawing.Point(495, 257);
            this.nudAddQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAddQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddQty.Name = "nudAddQty";
            this.nudAddQty.Size = new System.Drawing.Size(120, 20);
            this.nudAddQty.TabIndex = 148;
            this.nudAddQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 149;
            this.label6.Text = "Additional Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Update the quantity for this Commodity for the following room, cab, and NL";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(840, 354);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(77, 43);
            this.btnAddCancel.TabIndex = 151;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(746, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 43);
            this.btnAdd.TabIndex = 150;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(828, 340);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(77, 43);
            this.btnDeleteCancel.TabIndex = 166;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(734, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 43);
            this.btnDelete.TabIndex = 165;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(129, 31);
            this.cmbAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCategory.TabIndex = 153;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 152;
            this.label9.Text = "Category:";
            // 
            // cmbDeleteCategory
            // 
            this.cmbDeleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCategory.FormattingEnabled = true;
            this.cmbDeleteCategory.Location = new System.Drawing.Point(150, 21);
            this.cmbDeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteCategory.Name = "cmbDeleteCategory";
            this.cmbDeleteCategory.Size = new System.Drawing.Size(159, 26);
            this.cmbDeleteCategory.TabIndex = 177;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 176;
            this.label8.Text = "Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 13);
            this.label10.TabIndex = 167;
            this.label10.Text = "Delete the commodity for the following room, cab, and NL";
            // 
            // cmbDeleteCommodity
            // 
            this.cmbDeleteCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCommodity.FormattingEnabled = true;
            this.cmbDeleteCommodity.Location = new System.Drawing.Point(150, 51);
            this.cmbDeleteCommodity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteCommodity.Name = "cmbDeleteCommodity";
            this.cmbDeleteCommodity.Size = new System.Drawing.Size(159, 26);
            this.cmbDeleteCommodity.TabIndex = 175;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 174;
            this.label11.Text = "Commodity:";
            // 
            // cmbDeleteCabinet
            // 
            this.cmbDeleteCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCabinet.FormattingEnabled = true;
            this.cmbDeleteCabinet.Location = new System.Drawing.Point(138, 198);
            this.cmbDeleteCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteCabinet.Name = "cmbDeleteCabinet";
            this.cmbDeleteCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbDeleteCabinet.TabIndex = 173;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 201);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 172;
            this.label12.Text = "Cabinet:";
            // 
            // cmbDeleteNLevel
            // 
            this.cmbDeleteNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteNLevel.FormattingEnabled = true;
            this.cmbDeleteNLevel.Location = new System.Drawing.Point(138, 251);
            this.cmbDeleteNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteNLevel.Name = "cmbDeleteNLevel";
            this.cmbDeleteNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbDeleteNLevel.TabIndex = 171;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(62, 254);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 170;
            this.label13.Text = "N Level:";
            // 
            // cmbDeleteRoom
            // 
            this.cmbDeleteRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteRoom.FormattingEnabled = true;
            this.cmbDeleteRoom.Location = new System.Drawing.Point(138, 151);
            this.cmbDeleteRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteRoom.Name = "cmbDeleteRoom";
            this.cmbDeleteRoom.Size = new System.Drawing.Size(159, 26);
            this.cmbDeleteRoom.TabIndex = 169;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 154);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 19);
            this.label14.TabIndex = 168;
            this.label14.Text = "Room:";
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
            this.tbpAddItems.ResumeLayout(false);
            this.tbpAddItems.PerformLayout();
            this.tbpCreateItem.ResumeLayout(false);
            this.tbpCreateItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateQty)).EndInit();
            this.tbpDeleteItem.ResumeLayout(false);
            this.tbpDeleteItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateAlertQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpAddItems;
        private System.Windows.Forms.TabPage tbpCreateItem;
        private System.Windows.Forms.TabPage tbpDeleteItem;
        private System.Windows.Forms.Button btnCreateCancel;
        private System.Windows.Forms.Button btnCreate;
        internal System.Windows.Forms.ComboBox cmbCreateCabinet;
        internal System.Windows.Forms.Label lblCabinet;
        internal System.Windows.Forms.RichTextBox txtCreateDescription;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.Label lblFeatures;
        internal System.Windows.Forms.Label lblLowStock;
        internal System.Windows.Forms.TextBox txtCreateUrl;
        internal System.Windows.Forms.Label lblLink;
        internal System.Windows.Forms.Label lblCost;
        internal System.Windows.Forms.ComboBox cmbCreateCategory;
        internal System.Windows.Forms.Label lblSupplier;
        internal System.Windows.Forms.ComboBox cmbCreateNLevel;
        internal System.Windows.Forms.Label lblNLevel;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.ComboBox cmbCreateVendor;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.TextBox txtCreateItemName;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.TextBox txtCreateFeatures;
        private System.Windows.Forms.NumericUpDown nudCreateQty;
        private System.Windows.Forms.NumericUpDown nudCreateAlertQty;
        private System.Windows.Forms.MaskedTextBox mtxCreateCost;
        internal System.Windows.Forms.ComboBox cmbCreateRoom;
        internal System.Windows.Forms.Label lblLocation;
        internal System.Windows.Forms.ComboBox cmbAddCabinet;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbAddNLevel;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbAddRoom;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbAddCommodity;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAddQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.ComboBox cmbAddCategory;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cmbDeleteCategory;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cmbDeleteCommodity;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cmbDeleteCabinet;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.ComboBox cmbDeleteNLevel;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cmbDeleteRoom;
        internal System.Windows.Forms.Label label14;
    }
}