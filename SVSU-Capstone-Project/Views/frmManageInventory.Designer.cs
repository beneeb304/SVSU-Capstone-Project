
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInventory));
            this.tbcInventory = new System.Windows.Forms.TabControl();
            this.tbpUseItem = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUseItemTypeVal = new System.Windows.Forms.Label();
            this.lblUseItemCategoryVal = new System.Windows.Forms.Label();
            this.lblUseItemNameVal = new System.Windows.Forms.Label();
            this.lblUseItemType = new System.Windows.Forms.Label();
            this.lblUseItemCategory = new System.Windows.Forms.Label();
            this.lblUseItemName = new System.Windows.Forms.Label();
            this.trvUseSelectByRoom = new System.Windows.Forms.TreeView();
            this.lblUseRemainder = new System.Windows.Forms.Label();
            this.lblUseUsed = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblUseOperatorSymb = new System.Windows.Forms.Label();
            this.txtUseRemaining = new System.Windows.Forms.TextBox();
            this.lblUseAvailable = new System.Windows.Forms.Label();
            this.nudUseDeduct = new System.Windows.Forms.NumericUpDown();
            this.txtUseAvailable = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUseReset = new System.Windows.Forms.Button();
            this.btnUseAccept = new System.Windows.Forms.Button();
            this.tbpCreateItem = new System.Windows.Forms.TabPage();
            this.nudCreateCost = new System.Windows.Forms.NumericUpDown();
            this.cmbCreateType = new System.Windows.Forms.ComboBox();
            this.lblCreateType = new System.Windows.Forms.Label();
            this.tbpCreateSelector = new System.Windows.Forms.TabControl();
            this.tbpCreateSelectByCategory = new System.Windows.Forms.TabPage();
            this.trvCreateSelectByCategory = new System.Windows.Forms.TreeView();
            this.tbpCreateSelectByRoom = new System.Windows.Forms.TabPage();
            this.trvCreateSelectByRoom = new System.Windows.Forms.TreeView();
            this.nudCreateAlertQty = new System.Windows.Forms.NumericUpDown();
            this.txtCreateFeatures = new System.Windows.Forms.TextBox();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.txtCreateUrl = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.cmbCreateCategory = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbCreateVendor = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCreateItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbpAddItems = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAddQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.cmbAddCommodity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAddCabinet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAddNLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAddRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcMoveItem = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.nudMoveQuantity = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMoveAvailable = new System.Windows.Forms.TextBox();
            this.lblMoveTitle = new System.Windows.Forms.Label();
            this.btnMoveReset = new System.Windows.Forms.Button();
            this.btnMoveAccept = new System.Windows.Forms.Button();
            this.lblMoveCommodity = new System.Windows.Forms.Label();
            this.cmbMoveCommodity = new System.Windows.Forms.ComboBox();
            this.lblMoveCategory = new System.Windows.Forms.Label();
            this.cmbMoveCategory = new System.Windows.Forms.ComboBox();
            this.gbMoveDestination = new System.Windows.Forms.GroupBox();
            this.lblMoveToDesc = new System.Windows.Forms.Label();
            this.lblMoveRoomTo = new System.Windows.Forms.Label();
            this.cmbMoveRoomTo = new System.Windows.Forms.ComboBox();
            this.lblMoveNLevelTo = new System.Windows.Forms.Label();
            this.cmbMoveNLevelTo = new System.Windows.Forms.ComboBox();
            this.lblMoveCabinetTo = new System.Windows.Forms.Label();
            this.cmbMoveCabinetTo = new System.Windows.Forms.ComboBox();
            this.gbMoveSource = new System.Windows.Forms.GroupBox();
            this.lblMoveFromDesc = new System.Windows.Forms.Label();
            this.lblMoveRoomFrom = new System.Windows.Forms.Label();
            this.cmbMoveRoomFrom = new System.Windows.Forms.ComboBox();
            this.lblMoveNLevelFrom = new System.Windows.Forms.Label();
            this.cmbMoveNLevelFrom = new System.Windows.Forms.ComboBox();
            this.lblMoveCabinetFrom = new System.Windows.Forms.Label();
            this.cmbMoveCabinetFrom = new System.Windows.Forms.ComboBox();
            this.tbpDeleteItem = new System.Windows.Forms.TabPage();
            this.btnConfirmReset = new System.Windows.Forms.Button();
            this.btnDeleteConfirm = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvDeletionDelta = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbDeleteCommodity = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbDeleteCategory = new System.Windows.Forms.ComboBox();
            this.tbcInventory.SuspendLayout();
            this.tbpUseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUseDeduct)).BeginInit();
            this.tbpCreateItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateCost)).BeginInit();
            this.tbpCreateSelector.SuspendLayout();
            this.tbpCreateSelectByCategory.SuspendLayout();
            this.tbpCreateSelectByRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateAlertQty)).BeginInit();
            this.tbpAddItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).BeginInit();
            this.tbcMoveItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveQuantity)).BeginInit();
            this.gbMoveDestination.SuspendLayout();
            this.gbMoveSource.SuspendLayout();
            this.tbpDeleteItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletionDelta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcInventory
            // 
            this.tbcInventory.Controls.Add(this.tbpUseItem);
            this.tbcInventory.Controls.Add(this.tbpCreateItem);
            this.tbcInventory.Controls.Add(this.tbpAddItems);
            this.tbcInventory.Controls.Add(this.tbcMoveItem);
            this.tbcInventory.Controls.Add(this.tbpDeleteItem);
            this.tbcInventory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcInventory.Location = new System.Drawing.Point(12, 12);
            this.tbcInventory.Name = "tbcInventory";
            this.tbcInventory.SelectedIndex = 0;
            this.tbcInventory.Size = new System.Drawing.Size(931, 429);
            this.tbcInventory.TabIndex = 0;
            // 
            // tbpUseItem
            // 
            this.tbpUseItem.Controls.Add(this.label8);
            this.tbpUseItem.Controls.Add(this.lblUseItemTypeVal);
            this.tbpUseItem.Controls.Add(this.lblUseItemCategoryVal);
            this.tbpUseItem.Controls.Add(this.lblUseItemNameVal);
            this.tbpUseItem.Controls.Add(this.lblUseItemType);
            this.tbpUseItem.Controls.Add(this.lblUseItemCategory);
            this.tbpUseItem.Controls.Add(this.lblUseItemName);
            this.tbpUseItem.Controls.Add(this.trvUseSelectByRoom);
            this.tbpUseItem.Controls.Add(this.lblUseRemainder);
            this.tbpUseItem.Controls.Add(this.lblUseUsed);
            this.tbpUseItem.Controls.Add(this.label24);
            this.tbpUseItem.Controls.Add(this.lblUseOperatorSymb);
            this.tbpUseItem.Controls.Add(this.txtUseRemaining);
            this.tbpUseItem.Controls.Add(this.lblUseAvailable);
            this.tbpUseItem.Controls.Add(this.nudUseDeduct);
            this.tbpUseItem.Controls.Add(this.txtUseAvailable);
            this.tbpUseItem.Controls.Add(this.label17);
            this.tbpUseItem.Controls.Add(this.btnUseReset);
            this.tbpUseItem.Controls.Add(this.btnUseAccept);
            this.tbpUseItem.Location = new System.Drawing.Point(4, 25);
            this.tbpUseItem.Name = "tbpUseItem";
            this.tbpUseItem.Size = new System.Drawing.Size(923, 400);
            this.tbpUseItem.TabIndex = 2;
            this.tbpUseItem.Text = "Use Item";
            this.tbpUseItem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 204;
            this.label8.Text = "By Room";
            // 
            // lblUseItemTypeVal
            // 
            this.lblUseItemTypeVal.AutoSize = true;
            this.lblUseItemTypeVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUseItemTypeVal.Location = new System.Drawing.Point(508, 122);
            this.lblUseItemTypeVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseItemTypeVal.Name = "lblUseItemTypeVal";
            this.lblUseItemTypeVal.Size = new System.Drawing.Size(0, 18);
            this.lblUseItemTypeVal.TabIndex = 203;
            // 
            // lblUseItemCategoryVal
            // 
            this.lblUseItemCategoryVal.AutoSize = true;
            this.lblUseItemCategoryVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUseItemCategoryVal.Location = new System.Drawing.Point(508, 83);
            this.lblUseItemCategoryVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseItemCategoryVal.Name = "lblUseItemCategoryVal";
            this.lblUseItemCategoryVal.Size = new System.Drawing.Size(0, 18);
            this.lblUseItemCategoryVal.TabIndex = 202;
            // 
            // lblUseItemNameVal
            // 
            this.lblUseItemNameVal.AutoSize = true;
            this.lblUseItemNameVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUseItemNameVal.Location = new System.Drawing.Point(508, 45);
            this.lblUseItemNameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseItemNameVal.Name = "lblUseItemNameVal";
            this.lblUseItemNameVal.Size = new System.Drawing.Size(0, 18);
            this.lblUseItemNameVal.TabIndex = 201;
            // 
            // lblUseItemType
            // 
            this.lblUseItemType.AutoSize = true;
            this.lblUseItemType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemType.Location = new System.Drawing.Point(404, 121);
            this.lblUseItemType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseItemType.Name = "lblUseItemType";
            this.lblUseItemType.Size = new System.Drawing.Size(52, 19);
            this.lblUseItemType.TabIndex = 200;
            this.lblUseItemType.Text = "Type:";
            // 
            // lblUseItemCategory
            // 
            this.lblUseItemCategory.AutoSize = true;
            this.lblUseItemCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemCategory.Location = new System.Drawing.Point(404, 83);
            this.lblUseItemCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseItemCategory.Name = "lblUseItemCategory";
            this.lblUseItemCategory.Size = new System.Drawing.Size(85, 19);
            this.lblUseItemCategory.TabIndex = 197;
            this.lblUseItemCategory.Text = "Category:";
            // 
            // lblUseItemName
            // 
            this.lblUseItemName.AutoSize = true;
            this.lblUseItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemName.Location = new System.Drawing.Point(404, 45);
            this.lblUseItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseItemName.Name = "lblUseItemName";
            this.lblUseItemName.Size = new System.Drawing.Size(95, 19);
            this.lblUseItemName.TabIndex = 196;
            this.lblUseItemName.Text = "Item Name:";
            // 
            // trvUseSelectByRoom
            // 
            this.trvUseSelectByRoom.Location = new System.Drawing.Point(21, 83);
            this.trvUseSelectByRoom.Name = "trvUseSelectByRoom";
            this.trvUseSelectByRoom.Size = new System.Drawing.Size(272, 298);
            this.trvUseSelectByRoom.TabIndex = 195;
            this.trvUseSelectByRoom.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvUseSelectByRoom_BeforeSelect);
            this.trvUseSelectByRoom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvUseSelectByRoom_AfterSelect);
            // 
            // lblUseRemainder
            // 
            this.lblUseRemainder.AutoSize = true;
            this.lblUseRemainder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseRemainder.Location = new System.Drawing.Point(698, 207);
            this.lblUseRemainder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseRemainder.Name = "lblUseRemainder";
            this.lblUseRemainder.Size = new System.Drawing.Size(98, 19);
            this.lblUseRemainder.TabIndex = 194;
            this.lblUseRemainder.Text = "Remainder:";
            // 
            // lblUseUsed
            // 
            this.lblUseUsed.AutoSize = true;
            this.lblUseUsed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseUsed.Location = new System.Drawing.Point(550, 207);
            this.lblUseUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseUsed.Name = "lblUseUsed";
            this.lblUseUsed.Size = new System.Drawing.Size(55, 19);
            this.lblUseUsed.TabIndex = 193;
            this.lblUseUsed.Text = "Used:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(679, 231);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 19);
            this.label24.TabIndex = 192;
            this.label24.Text = "=";
            // 
            // lblUseOperatorSymb
            // 
            this.lblUseOperatorSymb.AutoSize = true;
            this.lblUseOperatorSymb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseOperatorSymb.Location = new System.Drawing.Point(535, 230);
            this.lblUseOperatorSymb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseOperatorSymb.Name = "lblUseOperatorSymb";
            this.lblUseOperatorSymb.Size = new System.Drawing.Size(14, 19);
            this.lblUseOperatorSymb.TabIndex = 191;
            this.lblUseOperatorSymb.Text = "-";
            // 
            // txtUseRemaining
            // 
            this.txtUseRemaining.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseRemaining.Location = new System.Drawing.Point(702, 227);
            this.txtUseRemaining.Name = "txtUseRemaining";
            this.txtUseRemaining.ReadOnly = true;
            this.txtUseRemaining.Size = new System.Drawing.Size(120, 26);
            this.txtUseRemaining.TabIndex = 190;
            // 
            // lblUseAvailable
            // 
            this.lblUseAvailable.AutoSize = true;
            this.lblUseAvailable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseAvailable.Location = new System.Drawing.Point(406, 206);
            this.lblUseAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseAvailable.Name = "lblUseAvailable";
            this.lblUseAvailable.Size = new System.Drawing.Size(83, 19);
            this.lblUseAvailable.TabIndex = 189;
            this.lblUseAvailable.Text = "Available:";
            // 
            // nudUseDeduct
            // 
            this.nudUseDeduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUseDeduct.Location = new System.Drawing.Point(554, 228);
            this.nudUseDeduct.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUseDeduct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUseDeduct.Name = "nudUseDeduct";
            this.nudUseDeduct.Size = new System.Drawing.Size(120, 26);
            this.nudUseDeduct.TabIndex = 188;
            this.nudUseDeduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUseDeduct.ValueChanged += new System.EventHandler(this.nudUseDeduct_ValueChanged);
            // 
            // txtUseAvailable
            // 
            this.txtUseAvailable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseAvailable.Location = new System.Drawing.Point(410, 228);
            this.txtUseAvailable.Name = "txtUseAvailable";
            this.txtUseAvailable.ReadOnly = true;
            this.txtUseAvailable.Size = new System.Drawing.Size(120, 26);
            this.txtUseAvailable.TabIndex = 187;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 22);
            this.label17.TabIndex = 186;
            this.label17.Text = "Use Existing Item";
            // 
            // btnUseReset
            // 
            this.btnUseReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseReset.Location = new System.Drawing.Point(827, 338);
            this.btnUseReset.Name = "btnUseReset";
            this.btnUseReset.Size = new System.Drawing.Size(77, 43);
            this.btnUseReset.TabIndex = 7;
            this.btnUseReset.Text = "Reset";
            this.btnUseReset.UseVisualStyleBackColor = true;
            this.btnUseReset.Click += new System.EventHandler(this.btnUseCancel_Click);
            // 
            // btnUseAccept
            // 
            this.btnUseAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseAccept.Location = new System.Drawing.Point(744, 338);
            this.btnUseAccept.Name = "btnUseAccept";
            this.btnUseAccept.Size = new System.Drawing.Size(77, 43);
            this.btnUseAccept.TabIndex = 8;
            this.btnUseAccept.Text = "Use";
            this.btnUseAccept.UseVisualStyleBackColor = true;
            this.btnUseAccept.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // tbpCreateItem
            // 
            this.tbpCreateItem.Controls.Add(this.nudCreateCost);
            this.tbpCreateItem.Controls.Add(this.cmbCreateType);
            this.tbpCreateItem.Controls.Add(this.lblCreateType);
            this.tbpCreateItem.Controls.Add(this.tbpCreateSelector);
            this.tbpCreateItem.Controls.Add(this.nudCreateAlertQty);
            this.tbpCreateItem.Controls.Add(this.txtCreateFeatures);
            this.tbpCreateItem.Controls.Add(this.btnCreateCancel);
            this.tbpCreateItem.Controls.Add(this.btnCreate);
            this.tbpCreateItem.Controls.Add(this.txtCreateDescription);
            this.tbpCreateItem.Controls.Add(this.lblDescription);
            this.tbpCreateItem.Controls.Add(this.lblFeatures);
            this.tbpCreateItem.Controls.Add(this.lblLowStock);
            this.tbpCreateItem.Controls.Add(this.txtCreateUrl);
            this.tbpCreateItem.Controls.Add(this.lblLink);
            this.tbpCreateItem.Controls.Add(this.lblCost);
            this.tbpCreateItem.Controls.Add(this.cmbCreateCategory);
            this.tbpCreateItem.Controls.Add(this.lblSupplier);
            this.tbpCreateItem.Controls.Add(this.cmbCreateVendor);
            this.tbpCreateItem.Controls.Add(this.lblCategory);
            this.tbpCreateItem.Controls.Add(this.txtCreateItemName);
            this.tbpCreateItem.Controls.Add(this.lblItemName);
            this.tbpCreateItem.Location = new System.Drawing.Point(4, 25);
            this.tbpCreateItem.Name = "tbpCreateItem";
            this.tbpCreateItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateItem.Size = new System.Drawing.Size(923, 400);
            this.tbpCreateItem.TabIndex = 1;
            this.tbpCreateItem.Text = "Create / Modify";
            this.tbpCreateItem.UseVisualStyleBackColor = true;
            // 
            // nudCreateCost
            // 
            this.nudCreateCost.DecimalPlaces = 2;
            this.nudCreateCost.Font = new System.Drawing.Font("Arial", 12F);
            this.nudCreateCost.Location = new System.Drawing.Point(422, 243);
            this.nudCreateCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCreateCost.Name = "nudCreateCost";
            this.nudCreateCost.Size = new System.Drawing.Size(120, 26);
            this.nudCreateCost.TabIndex = 135;
            this.nudCreateCost.ThousandsSeparator = true;
            // 
            // cmbCreateType
            // 
            this.cmbCreateType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateType.FormattingEnabled = true;
            this.cmbCreateType.Location = new System.Drawing.Point(422, 111);
            this.cmbCreateType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateType.Name = "cmbCreateType";
            this.cmbCreateType.Size = new System.Drawing.Size(250, 26);
            this.cmbCreateType.TabIndex = 133;
            // 
            // lblCreateType
            // 
            this.lblCreateType.AutoSize = true;
            this.lblCreateType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateType.Location = new System.Drawing.Point(281, 114);
            this.lblCreateType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateType.Name = "lblCreateType";
            this.lblCreateType.Size = new System.Drawing.Size(88, 19);
            this.lblCreateType.TabIndex = 134;
            this.lblCreateType.Text = "Item Type:";
            // 
            // tbpCreateSelector
            // 
            this.tbpCreateSelector.Controls.Add(this.tbpCreateSelectByCategory);
            this.tbpCreateSelector.Controls.Add(this.tbpCreateSelectByRoom);
            this.tbpCreateSelector.Location = new System.Drawing.Point(7, 6);
            this.tbpCreateSelector.Name = "tbpCreateSelector";
            this.tbpCreateSelector.SelectedIndex = 0;
            this.tbpCreateSelector.Size = new System.Drawing.Size(269, 388);
            this.tbpCreateSelector.TabIndex = 132;
            // 
            // tbpCreateSelectByCategory
            // 
            this.tbpCreateSelectByCategory.Controls.Add(this.trvCreateSelectByCategory);
            this.tbpCreateSelectByCategory.Location = new System.Drawing.Point(4, 25);
            this.tbpCreateSelectByCategory.Name = "tbpCreateSelectByCategory";
            this.tbpCreateSelectByCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateSelectByCategory.Size = new System.Drawing.Size(261, 359);
            this.tbpCreateSelectByCategory.TabIndex = 0;
            this.tbpCreateSelectByCategory.Text = "By Category";
            this.tbpCreateSelectByCategory.UseVisualStyleBackColor = true;
            // 
            // trvCreateSelectByCategory
            // 
            this.trvCreateSelectByCategory.Location = new System.Drawing.Point(0, 0);
            this.trvCreateSelectByCategory.Name = "trvCreateSelectByCategory";
            this.trvCreateSelectByCategory.Size = new System.Drawing.Size(261, 359);
            this.trvCreateSelectByCategory.TabIndex = 0;
            this.trvCreateSelectByCategory.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvCreateSelect_BeforeSelect);
            this.trvCreateSelectByCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCreateSelect_AfterSelect);
            // 
            // tbpCreateSelectByRoom
            // 
            this.tbpCreateSelectByRoom.Controls.Add(this.trvCreateSelectByRoom);
            this.tbpCreateSelectByRoom.Location = new System.Drawing.Point(4, 25);
            this.tbpCreateSelectByRoom.Name = "tbpCreateSelectByRoom";
            this.tbpCreateSelectByRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateSelectByRoom.Size = new System.Drawing.Size(261, 359);
            this.tbpCreateSelectByRoom.TabIndex = 1;
            this.tbpCreateSelectByRoom.Text = "By Room";
            this.tbpCreateSelectByRoom.UseVisualStyleBackColor = true;
            // 
            // trvCreateSelectByRoom
            // 
            this.trvCreateSelectByRoom.Location = new System.Drawing.Point(0, 0);
            this.trvCreateSelectByRoom.Name = "trvCreateSelectByRoom";
            this.trvCreateSelectByRoom.Size = new System.Drawing.Size(261, 359);
            this.trvCreateSelectByRoom.TabIndex = 1;
            this.trvCreateSelectByRoom.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvCreateSelect_BeforeSelect);
            this.trvCreateSelectByRoom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCreateSelect_AfterSelect);
            // 
            // nudCreateAlertQty
            // 
            this.nudCreateAlertQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCreateAlertQty.Location = new System.Drawing.Point(422, 305);
            this.nudCreateAlertQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreateAlertQty.Name = "nudCreateAlertQty";
            this.nudCreateAlertQty.Size = new System.Drawing.Size(120, 26);
            this.nudCreateAlertQty.TabIndex = 7;
            // 
            // txtCreateFeatures
            // 
            this.txtCreateFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateFeatures.Location = new System.Drawing.Point(422, 336);
            this.txtCreateFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateFeatures.Name = "txtCreateFeatures";
            this.txtCreateFeatures.Size = new System.Drawing.Size(159, 26);
            this.txtCreateFeatures.TabIndex = 8;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCancel.Location = new System.Drawing.Point(825, 338);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(77, 43);
            this.btnCreateCancel.TabIndex = 9;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = true;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(742, 338);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 43);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateDescription.Location = new System.Drawing.Point(422, 142);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(254, 65);
            this.txtCreateDescription.TabIndex = 3;
            this.txtCreateDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(281, 145);
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
            this.lblFeatures.Location = new System.Drawing.Point(281, 339);
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
            this.lblLowStock.Location = new System.Drawing.Point(281, 307);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(118, 19);
            this.lblLowStock.TabIndex = 127;
            this.lblLowStock.Text = "Alert Quantity:";
            // 
            // txtCreateUrl
            // 
            this.txtCreateUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUrl.Location = new System.Drawing.Point(422, 274);
            this.txtCreateUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateUrl.Name = "txtCreateUrl";
            this.txtCreateUrl.Size = new System.Drawing.Size(159, 26);
            this.txtCreateUrl.TabIndex = 6;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(281, 277);
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
            this.lblCost.Location = new System.Drawing.Point(281, 245);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(86, 19);
            this.lblCost.TabIndex = 124;
            this.lblCost.Text = "Unit Cost:";
            // 
            // cmbCreateCategory
            // 
            this.cmbCreateCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCategory.FormattingEnabled = true;
            this.cmbCreateCategory.Location = new System.Drawing.Point(422, 81);
            this.cmbCreateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateCategory.Name = "cmbCreateCategory";
            this.cmbCreateCategory.Size = new System.Drawing.Size(250, 26);
            this.cmbCreateCategory.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(281, 215);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 19);
            this.lblSupplier.TabIndex = 122;
            this.lblSupplier.Text = "Vendor:";
            // 
            // cmbCreateVendor
            // 
            this.cmbCreateVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateVendor.FormattingEnabled = true;
            this.cmbCreateVendor.Location = new System.Drawing.Point(422, 212);
            this.cmbCreateVendor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreateVendor.Name = "cmbCreateVendor";
            this.cmbCreateVendor.Size = new System.Drawing.Size(159, 26);
            this.cmbCreateVendor.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(281, 84);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 19);
            this.lblCategory.TabIndex = 114;
            this.lblCategory.Text = "Category:";
            // 
            // txtCreateItemName
            // 
            this.txtCreateItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateItemName.Location = new System.Drawing.Point(422, 51);
            this.txtCreateItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateItemName.Name = "txtCreateItemName";
            this.txtCreateItemName.Size = new System.Drawing.Size(250, 26);
            this.txtCreateItemName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(281, 54);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 19);
            this.lblItemName.TabIndex = 112;
            this.lblItemName.Text = "Item Name:";
            // 
            // tbpAddItems
            // 
            this.tbpAddItems.Controls.Add(this.label10);
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
            this.tbpAddItems.Location = new System.Drawing.Point(4, 25);
            this.tbpAddItems.Name = "tbpAddItems";
            this.tbpAddItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddItems.Size = new System.Drawing.Size(923, 400);
            this.tbpAddItems.TabIndex = 0;
            this.tbpAddItems.Text = "Add Stock for Existing Item";
            this.tbpAddItems.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 22);
            this.label10.TabIndex = 154;
            this.label10.Text = "Add Stock for Existing Item";
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(147, 59);
            this.cmbAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(250, 26);
            this.cmbAddCategory.TabIndex = 1;
            this.cmbAddCategory.SelectedValueChanged += new System.EventHandler(this.cmbAddCategory_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 152;
            this.label9.Text = "Category:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(822, 338);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(77, 43);
            this.btnAddCancel.TabIndex = 8;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(739, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(585, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Update the quantity for this Commodity for the following Room, Cabinet, and N Lev" +
    "el";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 19);
            this.label6.TabIndex = 149;
            this.label6.Text = "Additional Quantity:";
            // 
            // nudAddQty
            // 
            this.nudAddQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddQty.Location = new System.Drawing.Point(555, 240);
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
            this.nudAddQty.Size = new System.Drawing.Size(120, 26);
            this.nudAddQty.TabIndex = 7;
            this.nudAddQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 147;
            this.label5.Text = "Current Quantity:";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQty.Location = new System.Drawing.Point(555, 191);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(120, 26);
            this.txtCurrentQty.TabIndex = 6;
            // 
            // cmbAddCommodity
            // 
            this.cmbAddCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCommodity.FormattingEnabled = true;
            this.cmbAddCommodity.Location = new System.Drawing.Point(147, 101);
            this.cmbAddCommodity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCommodity.Name = "cmbAddCommodity";
            this.cmbAddCommodity.Size = new System.Drawing.Size(250, 26);
            this.cmbAddCommodity.TabIndex = 2;
            this.cmbAddCommodity.SelectedValueChanged += new System.EventHandler(this.cmbAddCommodity_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 144;
            this.label4.Text = "Commodity:";
            // 
            // cmbAddCabinet
            // 
            this.cmbAddCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCabinet.FormattingEnabled = true;
            this.cmbAddCabinet.Location = new System.Drawing.Point(147, 239);
            this.cmbAddCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddCabinet.Name = "cmbAddCabinet";
            this.cmbAddCabinet.Size = new System.Drawing.Size(159, 26);
            this.cmbAddCabinet.TabIndex = 4;
            this.cmbAddCabinet.SelectedValueChanged += new System.EventHandler(this.txtCurrentQty_DependancyUpdated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 242);
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
            this.cmbAddNLevel.Location = new System.Drawing.Point(147, 287);
            this.cmbAddNLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddNLevel.Name = "cmbAddNLevel";
            this.cmbAddNLevel.Size = new System.Drawing.Size(54, 26);
            this.cmbAddNLevel.TabIndex = 5;
            this.cmbAddNLevel.SelectedValueChanged += new System.EventHandler(this.txtCurrentQty_DependancyUpdated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 290);
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
            this.cmbAddRoom.Location = new System.Drawing.Point(147, 191);
            this.cmbAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddRoom.Name = "cmbAddRoom";
            this.cmbAddRoom.Size = new System.Drawing.Size(159, 26);
            this.cmbAddRoom.TabIndex = 3;
            this.cmbAddRoom.SelectedValueChanged += new System.EventHandler(this.cmbAddRoom_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 138;
            this.label3.Text = "Room:";
            // 
            // tbcMoveItem
            // 
            this.tbcMoveItem.Controls.Add(this.label27);
            this.tbcMoveItem.Controls.Add(this.nudMoveQuantity);
            this.tbcMoveItem.Controls.Add(this.label28);
            this.tbcMoveItem.Controls.Add(this.txtMoveAvailable);
            this.tbcMoveItem.Controls.Add(this.lblMoveTitle);
            this.tbcMoveItem.Controls.Add(this.btnMoveReset);
            this.tbcMoveItem.Controls.Add(this.btnMoveAccept);
            this.tbcMoveItem.Controls.Add(this.lblMoveCommodity);
            this.tbcMoveItem.Controls.Add(this.cmbMoveCommodity);
            this.tbcMoveItem.Controls.Add(this.lblMoveCategory);
            this.tbcMoveItem.Controls.Add(this.cmbMoveCategory);
            this.tbcMoveItem.Controls.Add(this.gbMoveDestination);
            this.tbcMoveItem.Controls.Add(this.gbMoveSource);
            this.tbcMoveItem.Location = new System.Drawing.Point(4, 25);
            this.tbcMoveItem.Name = "tbcMoveItem";
            this.tbcMoveItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbcMoveItem.Size = new System.Drawing.Size(923, 400);
            this.tbcMoveItem.TabIndex = 3;
            this.tbcMoveItem.Text = "Move Stock";
            this.tbcMoveItem.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(394, 226);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(143, 19);
            this.label27.TabIndex = 223;
            this.label27.Text = "Quantity to Move:";
            // 
            // nudMoveQuantity
            // 
            this.nudMoveQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMoveQuantity.Location = new System.Drawing.Point(398, 249);
            this.nudMoveQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMoveQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMoveQuantity.Name = "nudMoveQuantity";
            this.nudMoveQuantity.Size = new System.Drawing.Size(120, 26);
            this.nudMoveQuantity.TabIndex = 221;
            this.nudMoveQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(394, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 19);
            this.label28.TabIndex = 222;
            this.label28.Text = "Available:";
            // 
            // txtMoveAvailable
            // 
            this.txtMoveAvailable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoveAvailable.Location = new System.Drawing.Point(398, 165);
            this.txtMoveAvailable.Name = "txtMoveAvailable";
            this.txtMoveAvailable.ReadOnly = true;
            this.txtMoveAvailable.Size = new System.Drawing.Size(130, 26);
            this.txtMoveAvailable.TabIndex = 220;
            // 
            // lblMoveTitle
            // 
            this.lblMoveTitle.AutoSize = true;
            this.lblMoveTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveTitle.Location = new System.Drawing.Point(17, 12);
            this.lblMoveTitle.Name = "lblMoveTitle";
            this.lblMoveTitle.Size = new System.Drawing.Size(185, 22);
            this.lblMoveTitle.TabIndex = 219;
            this.lblMoveTitle.Text = "Move Existing Item";
            // 
            // btnMoveReset
            // 
            this.btnMoveReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveReset.Location = new System.Drawing.Point(824, 351);
            this.btnMoveReset.Name = "btnMoveReset";
            this.btnMoveReset.Size = new System.Drawing.Size(77, 43);
            this.btnMoveReset.TabIndex = 217;
            this.btnMoveReset.Text = "Reset";
            this.btnMoveReset.UseVisualStyleBackColor = true;
            this.btnMoveReset.Click += new System.EventHandler(this.btnMoveReset_Click);
            // 
            // btnMoveAccept
            // 
            this.btnMoveAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAccept.Location = new System.Drawing.Point(741, 351);
            this.btnMoveAccept.Name = "btnMoveAccept";
            this.btnMoveAccept.Size = new System.Drawing.Size(77, 43);
            this.btnMoveAccept.TabIndex = 218;
            this.btnMoveAccept.Text = "Move";
            this.btnMoveAccept.UseVisualStyleBackColor = true;
            this.btnMoveAccept.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblMoveCommodity
            // 
            this.lblMoveCommodity.AutoSize = true;
            this.lblMoveCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCommodity.Location = new System.Drawing.Point(17, 82);
            this.lblMoveCommodity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveCommodity.Name = "lblMoveCommodity";
            this.lblMoveCommodity.Size = new System.Drawing.Size(103, 19);
            this.lblMoveCommodity.TabIndex = 215;
            this.lblMoveCommodity.Text = "Commodity:";
            // 
            // cmbMoveCommodity
            // 
            this.cmbMoveCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCommodity.FormattingEnabled = true;
            this.cmbMoveCommodity.Location = new System.Drawing.Point(124, 79);
            this.cmbMoveCommodity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveCommodity.Name = "cmbMoveCommodity";
            this.cmbMoveCommodity.Size = new System.Drawing.Size(250, 26);
            this.cmbMoveCommodity.TabIndex = 214;
            this.cmbMoveCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbMoveCommodity_SelectedIndexChanged);
            // 
            // lblMoveCategory
            // 
            this.lblMoveCategory.AutoSize = true;
            this.lblMoveCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCategory.Location = new System.Drawing.Point(17, 48);
            this.lblMoveCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveCategory.Name = "lblMoveCategory";
            this.lblMoveCategory.Size = new System.Drawing.Size(85, 19);
            this.lblMoveCategory.TabIndex = 216;
            this.lblMoveCategory.Text = "Category:";
            // 
            // cmbMoveCategory
            // 
            this.cmbMoveCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCategory.FormattingEnabled = true;
            this.cmbMoveCategory.Location = new System.Drawing.Point(124, 45);
            this.cmbMoveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveCategory.Name = "cmbMoveCategory";
            this.cmbMoveCategory.Size = new System.Drawing.Size(250, 26);
            this.cmbMoveCategory.TabIndex = 213;
            this.cmbMoveCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMoveCategory_SelectedIndexChanged);
            // 
            // gbMoveDestination
            // 
            this.gbMoveDestination.Controls.Add(this.lblMoveToDesc);
            this.gbMoveDestination.Controls.Add(this.lblMoveRoomTo);
            this.gbMoveDestination.Controls.Add(this.cmbMoveRoomTo);
            this.gbMoveDestination.Controls.Add(this.lblMoveNLevelTo);
            this.gbMoveDestination.Controls.Add(this.cmbMoveNLevelTo);
            this.gbMoveDestination.Controls.Add(this.lblMoveCabinetTo);
            this.gbMoveDestination.Controls.Add(this.cmbMoveCabinetTo);
            this.gbMoveDestination.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMoveDestination.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbMoveDestination.Location = new System.Drawing.Point(572, 117);
            this.gbMoveDestination.Name = "gbMoveDestination";
            this.gbMoveDestination.Size = new System.Drawing.Size(329, 229);
            this.gbMoveDestination.TabIndex = 212;
            this.gbMoveDestination.TabStop = false;
            this.gbMoveDestination.Text = "Destination:";
            // 
            // lblMoveToDesc
            // 
            this.lblMoveToDesc.AutoSize = true;
            this.lblMoveToDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveToDesc.Location = new System.Drawing.Point(6, 38);
            this.lblMoveToDesc.Name = "lblMoveToDesc";
            this.lblMoveToDesc.Size = new System.Drawing.Size(263, 18);
            this.lblMoveToDesc.TabIndex = 192;
            this.lblMoveToDesc.Text = "Select location to deposit the item to.";
            // 
            // lblMoveRoomTo
            // 
            this.lblMoveRoomTo.AutoSize = true;
            this.lblMoveRoomTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveRoomTo.Location = new System.Drawing.Point(28, 79);
            this.lblMoveRoomTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveRoomTo.Name = "lblMoveRoomTo";
            this.lblMoveRoomTo.Size = new System.Drawing.Size(61, 19);
            this.lblMoveRoomTo.TabIndex = 195;
            this.lblMoveRoomTo.Text = "Room:";
            // 
            // cmbMoveRoomTo
            // 
            this.cmbMoveRoomTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveRoomTo.FormattingEnabled = true;
            this.cmbMoveRoomTo.Location = new System.Drawing.Point(135, 76);
            this.cmbMoveRoomTo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveRoomTo.Name = "cmbMoveRoomTo";
            this.cmbMoveRoomTo.Size = new System.Drawing.Size(159, 26);
            this.cmbMoveRoomTo.TabIndex = 189;
            this.cmbMoveRoomTo.SelectedIndexChanged += new System.EventHandler(this.cmbMoveRoomTo_SelectedIndexChanged);
            // 
            // lblMoveNLevelTo
            // 
            this.lblMoveNLevelTo.AutoSize = true;
            this.lblMoveNLevelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveNLevelTo.Location = new System.Drawing.Point(28, 175);
            this.lblMoveNLevelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveNLevelTo.Name = "lblMoveNLevelTo";
            this.lblMoveNLevelTo.Size = new System.Drawing.Size(72, 19);
            this.lblMoveNLevelTo.TabIndex = 196;
            this.lblMoveNLevelTo.Text = "N Level:";
            // 
            // cmbMoveNLevelTo
            // 
            this.cmbMoveNLevelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveNLevelTo.FormattingEnabled = true;
            this.cmbMoveNLevelTo.Location = new System.Drawing.Point(135, 172);
            this.cmbMoveNLevelTo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveNLevelTo.Name = "cmbMoveNLevelTo";
            this.cmbMoveNLevelTo.Size = new System.Drawing.Size(54, 26);
            this.cmbMoveNLevelTo.TabIndex = 191;
            // 
            // lblMoveCabinetTo
            // 
            this.lblMoveCabinetTo.AutoSize = true;
            this.lblMoveCabinetTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCabinetTo.Location = new System.Drawing.Point(28, 127);
            this.lblMoveCabinetTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveCabinetTo.Name = "lblMoveCabinetTo";
            this.lblMoveCabinetTo.Size = new System.Drawing.Size(74, 19);
            this.lblMoveCabinetTo.TabIndex = 197;
            this.lblMoveCabinetTo.Text = "Cabinet:";
            // 
            // cmbMoveCabinetTo
            // 
            this.cmbMoveCabinetTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCabinetTo.FormattingEnabled = true;
            this.cmbMoveCabinetTo.Location = new System.Drawing.Point(135, 124);
            this.cmbMoveCabinetTo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveCabinetTo.Name = "cmbMoveCabinetTo";
            this.cmbMoveCabinetTo.Size = new System.Drawing.Size(159, 26);
            this.cmbMoveCabinetTo.TabIndex = 190;
            this.cmbMoveCabinetTo.SelectedIndexChanged += new System.EventHandler(this.cmbMoveCabinetTo_SelectedIndexChanged);
            // 
            // gbMoveSource
            // 
            this.gbMoveSource.Controls.Add(this.lblMoveFromDesc);
            this.gbMoveSource.Controls.Add(this.lblMoveRoomFrom);
            this.gbMoveSource.Controls.Add(this.cmbMoveRoomFrom);
            this.gbMoveSource.Controls.Add(this.lblMoveNLevelFrom);
            this.gbMoveSource.Controls.Add(this.cmbMoveNLevelFrom);
            this.gbMoveSource.Controls.Add(this.lblMoveCabinetFrom);
            this.gbMoveSource.Controls.Add(this.cmbMoveCabinetFrom);
            this.gbMoveSource.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMoveSource.Location = new System.Drawing.Point(12, 117);
            this.gbMoveSource.Name = "gbMoveSource";
            this.gbMoveSource.Size = new System.Drawing.Size(339, 229);
            this.gbMoveSource.TabIndex = 211;
            this.gbMoveSource.TabStop = false;
            this.gbMoveSource.Text = "Source:";
            // 
            // lblMoveFromDesc
            // 
            this.lblMoveFromDesc.AutoSize = true;
            this.lblMoveFromDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveFromDesc.Location = new System.Drawing.Point(6, 38);
            this.lblMoveFromDesc.Name = "lblMoveFromDesc";
            this.lblMoveFromDesc.Size = new System.Drawing.Size(290, 18);
            this.lblMoveFromDesc.TabIndex = 192;
            this.lblMoveFromDesc.Text = "Select location to withdraw the item from.";
            // 
            // lblMoveRoomFrom
            // 
            this.lblMoveRoomFrom.AutoSize = true;
            this.lblMoveRoomFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveRoomFrom.Location = new System.Drawing.Point(28, 79);
            this.lblMoveRoomFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveRoomFrom.Name = "lblMoveRoomFrom";
            this.lblMoveRoomFrom.Size = new System.Drawing.Size(61, 19);
            this.lblMoveRoomFrom.TabIndex = 195;
            this.lblMoveRoomFrom.Text = "Room:";
            // 
            // cmbMoveRoomFrom
            // 
            this.cmbMoveRoomFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveRoomFrom.FormattingEnabled = true;
            this.cmbMoveRoomFrom.Location = new System.Drawing.Point(135, 76);
            this.cmbMoveRoomFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveRoomFrom.Name = "cmbMoveRoomFrom";
            this.cmbMoveRoomFrom.Size = new System.Drawing.Size(159, 26);
            this.cmbMoveRoomFrom.TabIndex = 189;
            this.cmbMoveRoomFrom.SelectedIndexChanged += new System.EventHandler(this.cmbMoveRoomFrom_SelectedIndexChanged);
            // 
            // lblMoveNLevelFrom
            // 
            this.lblMoveNLevelFrom.AutoSize = true;
            this.lblMoveNLevelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveNLevelFrom.Location = new System.Drawing.Point(28, 175);
            this.lblMoveNLevelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveNLevelFrom.Name = "lblMoveNLevelFrom";
            this.lblMoveNLevelFrom.Size = new System.Drawing.Size(72, 19);
            this.lblMoveNLevelFrom.TabIndex = 196;
            this.lblMoveNLevelFrom.Text = "N Level:";
            // 
            // cmbMoveNLevelFrom
            // 
            this.cmbMoveNLevelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveNLevelFrom.FormattingEnabled = true;
            this.cmbMoveNLevelFrom.Location = new System.Drawing.Point(135, 172);
            this.cmbMoveNLevelFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveNLevelFrom.Name = "cmbMoveNLevelFrom";
            this.cmbMoveNLevelFrom.Size = new System.Drawing.Size(54, 26);
            this.cmbMoveNLevelFrom.TabIndex = 191;
            this.cmbMoveNLevelFrom.SelectedIndexChanged += new System.EventHandler(this.cmbMoveNLevelFrom_SelectedIndexChanged);
            // 
            // lblMoveCabinetFrom
            // 
            this.lblMoveCabinetFrom.AutoSize = true;
            this.lblMoveCabinetFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCabinetFrom.Location = new System.Drawing.Point(28, 127);
            this.lblMoveCabinetFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveCabinetFrom.Name = "lblMoveCabinetFrom";
            this.lblMoveCabinetFrom.Size = new System.Drawing.Size(74, 19);
            this.lblMoveCabinetFrom.TabIndex = 197;
            this.lblMoveCabinetFrom.Text = "Cabinet:";
            // 
            // cmbMoveCabinetFrom
            // 
            this.cmbMoveCabinetFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCabinetFrom.FormattingEnabled = true;
            this.cmbMoveCabinetFrom.Location = new System.Drawing.Point(135, 124);
            this.cmbMoveCabinetFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoveCabinetFrom.Name = "cmbMoveCabinetFrom";
            this.cmbMoveCabinetFrom.Size = new System.Drawing.Size(159, 26);
            this.cmbMoveCabinetFrom.TabIndex = 190;
            this.cmbMoveCabinetFrom.SelectedIndexChanged += new System.EventHandler(this.cmbMoveCabinetFrom_SelectedIndexChanged);
            // 
            // tbpDeleteItem
            // 
            this.tbpDeleteItem.Controls.Add(this.btnConfirmReset);
            this.tbpDeleteItem.Controls.Add(this.btnDeleteConfirm);
            this.tbpDeleteItem.Controls.Add(this.label21);
            this.tbpDeleteItem.Controls.Add(this.dgvDeletionDelta);
            this.tbpDeleteItem.Controls.Add(this.label20);
            this.tbpDeleteItem.Controls.Add(this.label12);
            this.tbpDeleteItem.Controls.Add(this.label18);
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteCommodity);
            this.tbpDeleteItem.Controls.Add(this.label19);
            this.tbpDeleteItem.Controls.Add(this.cmbDeleteCategory);
            this.tbpDeleteItem.Location = new System.Drawing.Point(4, 25);
            this.tbpDeleteItem.Name = "tbpDeleteItem";
            this.tbpDeleteItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeleteItem.Size = new System.Drawing.Size(923, 400);
            this.tbpDeleteItem.TabIndex = 4;
            this.tbpDeleteItem.Text = "Delete Item";
            this.tbpDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnConfirmReset
            // 
            this.btnConfirmReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReset.Location = new System.Drawing.Point(832, 343);
            this.btnConfirmReset.Name = "btnConfirmReset";
            this.btnConfirmReset.Size = new System.Drawing.Size(77, 43);
            this.btnConfirmReset.TabIndex = 228;
            this.btnConfirmReset.Text = "Reset";
            this.btnConfirmReset.UseVisualStyleBackColor = true;
            this.btnConfirmReset.Click += new System.EventHandler(this.btnConfirmReset_Click);
            // 
            // btnDeleteConfirm
            // 
            this.btnDeleteConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConfirm.Location = new System.Drawing.Point(737, 343);
            this.btnDeleteConfirm.Name = "btnDeleteConfirm";
            this.btnDeleteConfirm.Size = new System.Drawing.Size(89, 43);
            this.btnDeleteConfirm.TabIndex = 229;
            this.btnDeleteConfirm.Text = "Confirm";
            this.btnDeleteConfirm.UseVisualStyleBackColor = true;
            this.btnDeleteConfirm.Click += new System.EventHandler(this.btnDeleteConfirm_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(378, 19);
            this.label21.TabIndex = 227;
            this.label21.Text = "Change Log: These are the changes to be made.\r\n";
            // 
            // dgvDeletionDelta
            // 
            this.dgvDeletionDelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletionDelta.Location = new System.Drawing.Point(18, 164);
            this.dgvDeletionDelta.Name = "dgvDeletionDelta";
            this.dgvDeletionDelta.ReadOnly = true;
            this.dgvDeletionDelta.RowHeadersWidth = 51;
            this.dgvDeletionDelta.Size = new System.Drawing.Size(713, 222);
            this.dgvDeletionDelta.TabIndex = 226;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(405, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(469, 72);
            this.label20.TabIndex = 225;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 22);
            this.label12.TabIndex = 224;
            this.label12.Text = "Delete Existing Item";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 85);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 19);
            this.label18.TabIndex = 222;
            this.label18.Text = "Commodity:";
            // 
            // cmbDeleteCommodity
            // 
            this.cmbDeleteCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCommodity.FormattingEnabled = true;
            this.cmbDeleteCommodity.Location = new System.Drawing.Point(122, 82);
            this.cmbDeleteCommodity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteCommodity.Name = "cmbDeleteCommodity";
            this.cmbDeleteCommodity.Size = new System.Drawing.Size(250, 26);
            this.cmbDeleteCommodity.TabIndex = 221;
            this.cmbDeleteCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCommodity_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 51);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 19);
            this.label19.TabIndex = 223;
            this.label19.Text = "Category:";
            // 
            // cmbDeleteCategory
            // 
            this.cmbDeleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCategory.FormattingEnabled = true;
            this.cmbDeleteCategory.Location = new System.Drawing.Point(122, 48);
            this.cmbDeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteCategory.Name = "cmbDeleteCategory";
            this.cmbDeleteCategory.Size = new System.Drawing.Size(250, 26);
            this.cmbDeleteCategory.TabIndex = 220;
            this.cmbDeleteCategory.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCategory_SelectedIndexChanged);
            // 
            // frmManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.tbcInventory);
            this.Name = "frmManageInventory";
            this.Text = "Manage Inventory";
            this.tbcInventory.ResumeLayout(false);
            this.tbpUseItem.ResumeLayout(false);
            this.tbpUseItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUseDeduct)).EndInit();
            this.tbpCreateItem.ResumeLayout(false);
            this.tbpCreateItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateCost)).EndInit();
            this.tbpCreateSelector.ResumeLayout(false);
            this.tbpCreateSelectByCategory.ResumeLayout(false);
            this.tbpCreateSelectByRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateAlertQty)).EndInit();
            this.tbpAddItems.ResumeLayout(false);
            this.tbpAddItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).EndInit();
            this.tbcMoveItem.ResumeLayout(false);
            this.tbcMoveItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveQuantity)).EndInit();
            this.gbMoveDestination.ResumeLayout(false);
            this.gbMoveDestination.PerformLayout();
            this.gbMoveSource.ResumeLayout(false);
            this.gbMoveSource.PerformLayout();
            this.tbpDeleteItem.ResumeLayout(false);
            this.tbpDeleteItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletionDelta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcInventory;
        private System.Windows.Forms.TabPage tbpAddItems;
        private System.Windows.Forms.TabPage tbpCreateItem;
        private System.Windows.Forms.TabPage tbpUseItem;
        private System.Windows.Forms.Button btnCreateCancel;
        private System.Windows.Forms.Button btnCreate;
        internal System.Windows.Forms.RichTextBox txtCreateDescription;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.Label lblFeatures;
        internal System.Windows.Forms.Label lblLowStock;
        internal System.Windows.Forms.TextBox txtCreateUrl;
        internal System.Windows.Forms.Label lblLink;
        internal System.Windows.Forms.Label lblCost;
        internal System.Windows.Forms.ComboBox cmbCreateCategory;
        internal System.Windows.Forms.Label lblSupplier;
        internal System.Windows.Forms.ComboBox cmbCreateVendor;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.TextBox txtCreateItemName;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.TextBox txtCreateFeatures;
        private System.Windows.Forms.NumericUpDown nudCreateAlertQty;
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
        private System.Windows.Forms.Button btnUseReset;
        private System.Windows.Forms.Button btnUseAccept;
        internal System.Windows.Forms.ComboBox cmbAddCategory;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tbcMoveItem;
        internal System.Windows.Forms.ComboBox cmbMoveCabinetFrom;
        internal System.Windows.Forms.Label lblMoveCabinetFrom;
        internal System.Windows.Forms.ComboBox cmbMoveNLevelFrom;
        internal System.Windows.Forms.Label lblMoveNLevelFrom;
        internal System.Windows.Forms.ComboBox cmbMoveRoomFrom;
        internal System.Windows.Forms.Label lblMoveRoomFrom;
        private System.Windows.Forms.Label lblMoveFromDesc;
        private System.Windows.Forms.GroupBox gbMoveSource;
        private System.Windows.Forms.GroupBox gbMoveDestination;
        private System.Windows.Forms.Label lblMoveToDesc;
        internal System.Windows.Forms.Label lblMoveRoomTo;
        internal System.Windows.Forms.ComboBox cmbMoveRoomTo;
        internal System.Windows.Forms.Label lblMoveNLevelTo;
        internal System.Windows.Forms.ComboBox cmbMoveNLevelTo;
        internal System.Windows.Forms.Label lblMoveCabinetTo;
        internal System.Windows.Forms.ComboBox cmbMoveCabinetTo;
        internal System.Windows.Forms.Label lblMoveCommodity;
        internal System.Windows.Forms.ComboBox cmbMoveCommodity;
        internal System.Windows.Forms.Label lblMoveCategory;
        internal System.Windows.Forms.ComboBox cmbMoveCategory;
        private System.Windows.Forms.Button btnMoveReset;
        private System.Windows.Forms.Button btnMoveAccept;
        private System.Windows.Forms.Label lblMoveTitle;
        private System.Windows.Forms.TabPage tbpDeleteItem;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.ComboBox cmbDeleteCommodity;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.ComboBox cmbDeleteCategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvDeletionDelta;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Label lblUseOperatorSymb;
        private System.Windows.Forms.TextBox txtUseRemaining;
        internal System.Windows.Forms.Label lblUseAvailable;
        private System.Windows.Forms.NumericUpDown nudUseDeduct;
        private System.Windows.Forms.TextBox txtUseAvailable;
        internal System.Windows.Forms.Label lblUseRemainder;
        internal System.Windows.Forms.Label lblUseUsed;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown nudMoveQuantity;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMoveAvailable;
        private System.Windows.Forms.Button btnConfirmReset;
        private System.Windows.Forms.Button btnDeleteConfirm;
        private System.Windows.Forms.TabControl tbpCreateSelector;
        private System.Windows.Forms.TabPage tbpCreateSelectByCategory;
        private System.Windows.Forms.TabPage tbpCreateSelectByRoom;
        private System.Windows.Forms.TreeView trvCreateSelectByCategory;
        private System.Windows.Forms.TreeView trvCreateSelectByRoom;
        private System.Windows.Forms.TreeView trvUseSelectByRoom;
        internal System.Windows.Forms.Label lblUseItemType;
        internal System.Windows.Forms.Label lblUseItemCategory;
        internal System.Windows.Forms.Label lblUseItemName;
        internal System.Windows.Forms.Label lblUseItemTypeVal;
        internal System.Windows.Forms.Label lblUseItemCategoryVal;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblUseItemNameVal;
        internal System.Windows.Forms.ComboBox cmbCreateType;
        internal System.Windows.Forms.Label lblCreateType;
        private System.Windows.Forms.NumericUpDown nudCreateCost;
    }
}
