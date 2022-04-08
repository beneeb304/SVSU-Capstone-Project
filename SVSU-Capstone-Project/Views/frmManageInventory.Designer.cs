
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
            this.tbpMoveItem = new System.Windows.Forms.TabPage();
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
            this.tbpMoveItem.SuspendLayout();
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
            this.tbcInventory.Controls.Add(this.tbpMoveItem);
            this.tbcInventory.Controls.Add(this.tbpDeleteItem);
            this.tbcInventory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcInventory.Location = new System.Drawing.Point(16, 15);
            this.tbcInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcInventory.Name = "tbcInventory";
            this.tbcInventory.SelectedIndex = 0;
            this.tbcInventory.Size = new System.Drawing.Size(1241, 528);
            this.tbcInventory.TabIndex = 0;
            this.tbcInventory.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcInventory_Selected);
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
            this.tbpUseItem.Location = new System.Drawing.Point(4, 27);
            this.tbpUseItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpUseItem.Name = "tbpUseItem";
            this.tbpUseItem.Size = new System.Drawing.Size(1233, 497);
            this.tbpUseItem.TabIndex = 2;
            this.tbpUseItem.Text = "Use Item";
            this.tbpUseItem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 204;
            this.label8.Text = "By Room";
            // 
            // lblUseItemTypeVal
            // 
            this.lblUseItemTypeVal.AutoSize = true;
            this.lblUseItemTypeVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUseItemTypeVal.Location = new System.Drawing.Point(677, 150);
            this.lblUseItemTypeVal.Name = "lblUseItemTypeVal";
            this.lblUseItemTypeVal.Size = new System.Drawing.Size(0, 23);
            this.lblUseItemTypeVal.TabIndex = 203;
            // 
            // lblUseItemCategoryVal
            // 
            this.lblUseItemCategoryVal.AutoSize = true;
            this.lblUseItemCategoryVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUseItemCategoryVal.Location = new System.Drawing.Point(677, 102);
            this.lblUseItemCategoryVal.Name = "lblUseItemCategoryVal";
            this.lblUseItemCategoryVal.Size = new System.Drawing.Size(0, 23);
            this.lblUseItemCategoryVal.TabIndex = 202;
            // 
            // lblUseItemNameVal
            // 
            this.lblUseItemNameVal.AutoSize = true;
            this.lblUseItemNameVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUseItemNameVal.Location = new System.Drawing.Point(677, 55);
            this.lblUseItemNameVal.Name = "lblUseItemNameVal";
            this.lblUseItemNameVal.Size = new System.Drawing.Size(0, 23);
            this.lblUseItemNameVal.TabIndex = 201;
            // 
            // lblUseItemType
            // 
            this.lblUseItemType.AutoSize = true;
            this.lblUseItemType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemType.Location = new System.Drawing.Point(539, 149);
            this.lblUseItemType.Name = "lblUseItemType";
            this.lblUseItemType.Size = new System.Drawing.Size(63, 24);
            this.lblUseItemType.TabIndex = 200;
            this.lblUseItemType.Text = "Type:";
            // 
            // lblUseItemCategory
            // 
            this.lblUseItemCategory.AutoSize = true;
            this.lblUseItemCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemCategory.Location = new System.Drawing.Point(539, 102);
            this.lblUseItemCategory.Name = "lblUseItemCategory";
            this.lblUseItemCategory.Size = new System.Drawing.Size(103, 24);
            this.lblUseItemCategory.TabIndex = 197;
            this.lblUseItemCategory.Text = "Category:";
            // 
            // lblUseItemName
            // 
            this.lblUseItemName.AutoSize = true;
            this.lblUseItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseItemName.Location = new System.Drawing.Point(539, 55);
            this.lblUseItemName.Name = "lblUseItemName";
            this.lblUseItemName.Size = new System.Drawing.Size(116, 24);
            this.lblUseItemName.TabIndex = 196;
            this.lblUseItemName.Text = "Item Name:";
            // 
            // trvUseSelectByRoom
            // 
            this.trvUseSelectByRoom.Location = new System.Drawing.Point(28, 102);
            this.trvUseSelectByRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvUseSelectByRoom.Name = "trvUseSelectByRoom";
            this.trvUseSelectByRoom.Size = new System.Drawing.Size(361, 366);
            this.trvUseSelectByRoom.TabIndex = 1;
            this.trvUseSelectByRoom.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvUseSelectByRoom_BeforeSelect);
            this.trvUseSelectByRoom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvUseSelectByRoom_AfterSelect);
            // 
            // lblUseRemainder
            // 
            this.lblUseRemainder.AutoSize = true;
            this.lblUseRemainder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseRemainder.Location = new System.Drawing.Point(931, 255);
            this.lblUseRemainder.Name = "lblUseRemainder";
            this.lblUseRemainder.Size = new System.Drawing.Size(150, 24);
            this.lblUseRemainder.TabIndex = 194;
            this.lblUseRemainder.Text = "New Total Qty:";
            // 
            // lblUseUsed
            // 
            this.lblUseUsed.AutoSize = true;
            this.lblUseUsed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseUsed.Location = new System.Drawing.Point(733, 255);
            this.lblUseUsed.Name = "lblUseUsed";
            this.lblUseUsed.Size = new System.Drawing.Size(105, 24);
            this.lblUseUsed.TabIndex = 193;
            this.lblUseUsed.Text = "Used Qty:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(905, 284);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 24);
            this.label24.TabIndex = 192;
            this.label24.Text = "=";
            // 
            // lblUseOperatorSymb
            // 
            this.lblUseOperatorSymb.AutoSize = true;
            this.lblUseOperatorSymb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseOperatorSymb.Location = new System.Drawing.Point(713, 283);
            this.lblUseOperatorSymb.Name = "lblUseOperatorSymb";
            this.lblUseOperatorSymb.Size = new System.Drawing.Size(17, 24);
            this.lblUseOperatorSymb.TabIndex = 191;
            this.lblUseOperatorSymb.Text = "-";
            // 
            // txtUseRemaining
            // 
            this.txtUseRemaining.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseRemaining.Location = new System.Drawing.Point(936, 279);
            this.txtUseRemaining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUseRemaining.Name = "txtUseRemaining";
            this.txtUseRemaining.ReadOnly = true;
            this.txtUseRemaining.Size = new System.Drawing.Size(159, 30);
            this.txtUseRemaining.TabIndex = 4;
            // 
            // lblUseAvailable
            // 
            this.lblUseAvailable.AutoSize = true;
            this.lblUseAvailable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseAvailable.Location = new System.Drawing.Point(541, 254);
            this.lblUseAvailable.Name = "lblUseAvailable";
            this.lblUseAvailable.Size = new System.Drawing.Size(140, 24);
            this.lblUseAvailable.TabIndex = 189;
            this.lblUseAvailable.Text = "Available Qty:";
            // 
            // nudUseDeduct
            // 
            this.nudUseDeduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUseDeduct.Location = new System.Drawing.Point(739, 281);
            this.nudUseDeduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudUseDeduct.ReadOnly = true;
            this.nudUseDeduct.Size = new System.Drawing.Size(160, 30);
            this.nudUseDeduct.TabIndex = 3;
            this.nudUseDeduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUseDeduct.ValueChanged += new System.EventHandler(this.nudUseDeduct_ValueChanged);
            this.nudUseDeduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudQuantity_KeyPress);
            // 
            // txtUseAvailable
            // 
            this.txtUseAvailable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseAvailable.Location = new System.Drawing.Point(547, 281);
            this.txtUseAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUseAvailable.Name = "txtUseAvailable";
            this.txtUseAvailable.ReadOnly = true;
            this.txtUseAvailable.Size = new System.Drawing.Size(159, 30);
            this.txtUseAvailable.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 29);
            this.label17.TabIndex = 186;
            this.label17.Text = "Use Existing Item";
            // 
            // btnUseReset
            // 
            this.btnUseReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseReset.Location = new System.Drawing.Point(1103, 416);
            this.btnUseReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUseReset.Name = "btnUseReset";
            this.btnUseReset.Size = new System.Drawing.Size(103, 53);
            this.btnUseReset.TabIndex = 6;
            this.btnUseReset.Text = "Reset";
            this.btnUseReset.UseVisualStyleBackColor = true;
            this.btnUseReset.Click += new System.EventHandler(this.btnUseCancel_Click);
            // 
            // btnUseAccept
            // 
            this.btnUseAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseAccept.Location = new System.Drawing.Point(992, 416);
            this.btnUseAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUseAccept.Name = "btnUseAccept";
            this.btnUseAccept.Size = new System.Drawing.Size(103, 53);
            this.btnUseAccept.TabIndex = 5;
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
            this.tbpCreateItem.Location = new System.Drawing.Point(4, 27);
            this.tbpCreateItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateItem.Name = "tbpCreateItem";
            this.tbpCreateItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateItem.Size = new System.Drawing.Size(1233, 497);
            this.tbpCreateItem.TabIndex = 1;
            this.tbpCreateItem.Text = "Create / Modify";
            this.tbpCreateItem.UseVisualStyleBackColor = true;
            // 
            // nudCreateCost
            // 
            this.nudCreateCost.DecimalPlaces = 2;
            this.nudCreateCost.Font = new System.Drawing.Font("Arial", 12F);
            this.nudCreateCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCreateCost.Location = new System.Drawing.Point(563, 260);
            this.nudCreateCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCreateCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCreateCost.Name = "nudCreateCost";
            this.nudCreateCost.Size = new System.Drawing.Size(160, 30);
            this.nudCreateCost.TabIndex = 9;
            this.nudCreateCost.ThousandsSeparator = true;
            // 
            // cmbCreateType
            // 
            this.cmbCreateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateType.FormattingEnabled = true;
            this.cmbCreateType.Location = new System.Drawing.Point(563, 97);
            this.cmbCreateType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateType.Name = "cmbCreateType";
            this.cmbCreateType.Size = new System.Drawing.Size(332, 31);
            this.cmbCreateType.TabIndex = 4;
            // 
            // lblCreateType
            // 
            this.lblCreateType.AutoSize = true;
            this.lblCreateType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateType.Location = new System.Drawing.Point(375, 101);
            this.lblCreateType.Name = "lblCreateType";
            this.lblCreateType.Size = new System.Drawing.Size(109, 24);
            this.lblCreateType.TabIndex = 134;
            this.lblCreateType.Text = "Item Type:";
            // 
            // tbpCreateSelector
            // 
            this.tbpCreateSelector.Controls.Add(this.tbpCreateSelectByCategory);
            this.tbpCreateSelector.Controls.Add(this.tbpCreateSelectByRoom);
            this.tbpCreateSelector.Location = new System.Drawing.Point(9, 7);
            this.tbpCreateSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateSelector.Name = "tbpCreateSelector";
            this.tbpCreateSelector.SelectedIndex = 0;
            this.tbpCreateSelector.Size = new System.Drawing.Size(359, 478);
            this.tbpCreateSelector.TabIndex = 1;
            // 
            // tbpCreateSelectByCategory
            // 
            this.tbpCreateSelectByCategory.Controls.Add(this.trvCreateSelectByCategory);
            this.tbpCreateSelectByCategory.Location = new System.Drawing.Point(4, 27);
            this.tbpCreateSelectByCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateSelectByCategory.Name = "tbpCreateSelectByCategory";
            this.tbpCreateSelectByCategory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateSelectByCategory.Size = new System.Drawing.Size(351, 447);
            this.tbpCreateSelectByCategory.TabIndex = 0;
            this.tbpCreateSelectByCategory.Text = "By Category";
            this.tbpCreateSelectByCategory.UseVisualStyleBackColor = true;
            // 
            // trvCreateSelectByCategory
            // 
            this.trvCreateSelectByCategory.Location = new System.Drawing.Point(-5, 0);
            this.trvCreateSelectByCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvCreateSelectByCategory.Name = "trvCreateSelectByCategory";
            this.trvCreateSelectByCategory.Size = new System.Drawing.Size(357, 446);
            this.trvCreateSelectByCategory.TabIndex = 0;
            this.trvCreateSelectByCategory.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvCreateSelect_BeforeSelect);
            this.trvCreateSelectByCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCreateSelect_AfterSelect);
            // 
            // tbpCreateSelectByRoom
            // 
            this.tbpCreateSelectByRoom.Controls.Add(this.trvCreateSelectByRoom);
            this.tbpCreateSelectByRoom.Location = new System.Drawing.Point(4, 27);
            this.tbpCreateSelectByRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateSelectByRoom.Name = "tbpCreateSelectByRoom";
            this.tbpCreateSelectByRoom.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpCreateSelectByRoom.Size = new System.Drawing.Size(351, 447);
            this.tbpCreateSelectByRoom.TabIndex = 1;
            this.tbpCreateSelectByRoom.Text = "By Room";
            this.tbpCreateSelectByRoom.UseVisualStyleBackColor = true;
            // 
            // trvCreateSelectByRoom
            // 
            this.trvCreateSelectByRoom.Location = new System.Drawing.Point(0, 0);
            this.trvCreateSelectByRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvCreateSelectByRoom.Name = "trvCreateSelectByRoom";
            this.trvCreateSelectByRoom.Size = new System.Drawing.Size(347, 441);
            this.trvCreateSelectByRoom.TabIndex = 1;
            this.trvCreateSelectByRoom.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvCreateSelect_BeforeSelect);
            this.trvCreateSelectByRoom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCreateSelect_AfterSelect);
            // 
            // nudCreateAlertQty
            // 
            this.nudCreateAlertQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCreateAlertQty.Location = new System.Drawing.Point(563, 336);
            this.nudCreateAlertQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCreateAlertQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreateAlertQty.Name = "nudCreateAlertQty";
            this.nudCreateAlertQty.ReadOnly = true;
            this.nudCreateAlertQty.Size = new System.Drawing.Size(160, 30);
            this.nudCreateAlertQty.TabIndex = 11;
            // 
            // txtCreateFeatures
            // 
            this.txtCreateFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateFeatures.Location = new System.Drawing.Point(563, 374);
            this.txtCreateFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateFeatures.Name = "txtCreateFeatures";
            this.txtCreateFeatures.ShortcutsEnabled = false;
            this.txtCreateFeatures.Size = new System.Drawing.Size(211, 30);
            this.txtCreateFeatures.TabIndex = 12;
            this.txtCreateFeatures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemNametxt_KeyPress);
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCancel.Location = new System.Drawing.Point(1100, 416);
            this.btnCreateCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(103, 53);
            this.btnCreateCancel.TabIndex = 14;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = true;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(989, 416);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 53);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateDescription.Location = new System.Drawing.Point(563, 135);
            this.txtCreateDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateDescription.MaxLength = 255;
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.ShortcutsEnabled = false;
            this.txtCreateDescription.Size = new System.Drawing.Size(337, 79);
            this.txtCreateDescription.TabIndex = 5;
            this.txtCreateDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(375, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 24);
            this.lblDescription.TabIndex = 131;
            this.lblDescription.Text = "Description:";
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(375, 378);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(100, 24);
            this.lblFeatures.TabIndex = 129;
            this.lblFeatures.Text = "Features:";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(375, 338);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(148, 24);
            this.lblLowStock.TabIndex = 127;
            this.lblLowStock.Text = "Alert Quantity:";
            // 
            // txtCreateUrl
            // 
            this.txtCreateUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUrl.Location = new System.Drawing.Point(563, 298);
            this.txtCreateUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUrl.Name = "txtCreateUrl";
            this.txtCreateUrl.ShortcutsEnabled = false;
            this.txtCreateUrl.Size = new System.Drawing.Size(211, 30);
            this.txtCreateUrl.TabIndex = 10;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(375, 302);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(103, 24);
            this.lblLink.TabIndex = 125;
            this.lblLink.Text = "Item URL:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(375, 262);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(105, 24);
            this.lblCost.TabIndex = 124;
            this.lblCost.Text = "Unit Cost:";
            // 
            // cmbCreateCategory
            // 
            this.cmbCreateCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCategory.FormattingEnabled = true;
            this.cmbCreateCategory.Location = new System.Drawing.Point(563, 60);
            this.cmbCreateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateCategory.Name = "cmbCreateCategory";
            this.cmbCreateCategory.Size = new System.Drawing.Size(332, 31);
            this.cmbCreateCategory.TabIndex = 3;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(375, 225);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(84, 24);
            this.lblSupplier.TabIndex = 122;
            this.lblSupplier.Text = "Vendor:";
            // 
            // cmbCreateVendor
            // 
            this.cmbCreateVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateVendor.FormattingEnabled = true;
            this.cmbCreateVendor.Location = new System.Drawing.Point(563, 222);
            this.cmbCreateVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateVendor.Name = "cmbCreateVendor";
            this.cmbCreateVendor.Size = new System.Drawing.Size(211, 31);
            this.cmbCreateVendor.TabIndex = 8;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(375, 64);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 24);
            this.lblCategory.TabIndex = 114;
            this.lblCategory.Text = "Category:";
            // 
            // txtCreateItemName
            // 
            this.txtCreateItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateItemName.Location = new System.Drawing.Point(563, 23);
            this.txtCreateItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateItemName.Name = "txtCreateItemName";
            this.txtCreateItemName.ShortcutsEnabled = false;
            this.txtCreateItemName.Size = new System.Drawing.Size(332, 30);
            this.txtCreateItemName.TabIndex = 2;
            this.txtCreateItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemNametxt_KeyPress);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(375, 27);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(116, 24);
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
            this.tbpAddItems.Location = new System.Drawing.Point(4, 27);
            this.tbpAddItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpAddItems.Name = "tbpAddItems";
            this.tbpAddItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpAddItems.Size = new System.Drawing.Size(1233, 497);
            this.tbpAddItems.TabIndex = 0;
            this.tbpAddItems.Text = "Add Stock for Existing Item";
            this.tbpAddItems.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 29);
            this.label10.TabIndex = 154;
            this.label10.Text = "Add Stock for Existing Item";
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(196, 73);
            this.cmbAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(332, 31);
            this.cmbAddCategory.TabIndex = 1;
            this.cmbAddCategory.SelectedValueChanged += new System.EventHandler(this.cmbAddCategory_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 152;
            this.label9.Text = "Category:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(1096, 416);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(103, 53);
            this.btnAddCancel.TabIndex = 9;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(985, 416);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 53);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(748, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Update the quantity for this Commodity for the following Room, Cabinet, and N Lev" +
    "el";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 149;
            this.label6.Text = "Additional Quantity:";
            // 
            // nudAddQty
            // 
            this.nudAddQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddQty.Location = new System.Drawing.Point(740, 295);
            this.nudAddQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudAddQty.ReadOnly = true;
            this.nudAddQty.Size = new System.Drawing.Size(160, 30);
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
            this.label5.Location = new System.Drawing.Point(484, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 147;
            this.label5.Text = "Current Quantity:";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQty.Location = new System.Drawing.Point(740, 235);
            this.txtCurrentQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(159, 30);
            this.txtCurrentQty.TabIndex = 6;
            // 
            // cmbAddCommodity
            // 
            this.cmbAddCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCommodity.FormattingEnabled = true;
            this.cmbAddCommodity.Location = new System.Drawing.Point(196, 124);
            this.cmbAddCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddCommodity.Name = "cmbAddCommodity";
            this.cmbAddCommodity.Size = new System.Drawing.Size(332, 31);
            this.cmbAddCommodity.TabIndex = 2;
            this.cmbAddCommodity.SelectedValueChanged += new System.EventHandler(this.cmbAddCommodity_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 144;
            this.label4.Text = "Commodity:";
            // 
            // cmbAddCabinet
            // 
            this.cmbAddCabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCabinet.FormattingEnabled = true;
            this.cmbAddCabinet.Location = new System.Drawing.Point(196, 294);
            this.cmbAddCabinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddCabinet.Name = "cmbAddCabinet";
            this.cmbAddCabinet.Size = new System.Drawing.Size(211, 31);
            this.cmbAddCabinet.TabIndex = 4;
            this.cmbAddCabinet.SelectedValueChanged += new System.EventHandler(this.txtCurrentQty_DependancyUpdated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 142;
            this.label1.Text = "Cabinet:";
            // 
            // cmbAddNLevel
            // 
            this.cmbAddNLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddNLevel.FormattingEnabled = true;
            this.cmbAddNLevel.Location = new System.Drawing.Point(196, 353);
            this.cmbAddNLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddNLevel.Name = "cmbAddNLevel";
            this.cmbAddNLevel.Size = new System.Drawing.Size(71, 31);
            this.cmbAddNLevel.TabIndex = 5;
            this.cmbAddNLevel.SelectedValueChanged += new System.EventHandler(this.txtCurrentQty_DependancyUpdated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 140;
            this.label2.Text = "N Level:";
            // 
            // cmbAddRoom
            // 
            this.cmbAddRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddRoom.FormattingEnabled = true;
            this.cmbAddRoom.Location = new System.Drawing.Point(196, 235);
            this.cmbAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddRoom.Name = "cmbAddRoom";
            this.cmbAddRoom.Size = new System.Drawing.Size(211, 31);
            this.cmbAddRoom.TabIndex = 3;
            this.cmbAddRoom.SelectedValueChanged += new System.EventHandler(this.cmbAddRoom_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 138;
            this.label3.Text = "Room:";
            // 
            // tbpMoveItem
            // 
            this.tbpMoveItem.Controls.Add(this.label27);
            this.tbpMoveItem.Controls.Add(this.nudMoveQuantity);
            this.tbpMoveItem.Controls.Add(this.label28);
            this.tbpMoveItem.Controls.Add(this.txtMoveAvailable);
            this.tbpMoveItem.Controls.Add(this.lblMoveTitle);
            this.tbpMoveItem.Controls.Add(this.btnMoveReset);
            this.tbpMoveItem.Controls.Add(this.btnMoveAccept);
            this.tbpMoveItem.Controls.Add(this.lblMoveCommodity);
            this.tbpMoveItem.Controls.Add(this.cmbMoveCommodity);
            this.tbpMoveItem.Controls.Add(this.lblMoveCategory);
            this.tbpMoveItem.Controls.Add(this.cmbMoveCategory);
            this.tbpMoveItem.Controls.Add(this.gbMoveDestination);
            this.tbpMoveItem.Controls.Add(this.gbMoveSource);
            this.tbpMoveItem.Location = new System.Drawing.Point(4, 27);
            this.tbpMoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpMoveItem.Name = "tbpMoveItem";
            this.tbpMoveItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpMoveItem.Size = new System.Drawing.Size(1233, 497);
            this.tbpMoveItem.TabIndex = 3;
            this.tbpMoveItem.Text = "Move Stock";
            this.tbpMoveItem.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(525, 278);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(180, 24);
            this.label27.TabIndex = 223;
            this.label27.Text = "Quantity to Move:";
            // 
            // nudMoveQuantity
            // 
            this.nudMoveQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMoveQuantity.Location = new System.Drawing.Point(531, 306);
            this.nudMoveQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudMoveQuantity.ReadOnly = true;
            this.nudMoveQuantity.Size = new System.Drawing.Size(160, 30);
            this.nudMoveQuantity.TabIndex = 8;
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
            this.label28.Location = new System.Drawing.Point(525, 175);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 24);
            this.label28.TabIndex = 222;
            this.label28.Text = "Available:";
            // 
            // txtMoveAvailable
            // 
            this.txtMoveAvailable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoveAvailable.Location = new System.Drawing.Point(531, 203);
            this.txtMoveAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoveAvailable.Name = "txtMoveAvailable";
            this.txtMoveAvailable.ReadOnly = true;
            this.txtMoveAvailable.Size = new System.Drawing.Size(172, 30);
            this.txtMoveAvailable.TabIndex = 7;
            // 
            // lblMoveTitle
            // 
            this.lblMoveTitle.AutoSize = true;
            this.lblMoveTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveTitle.Location = new System.Drawing.Point(23, 15);
            this.lblMoveTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoveTitle.Name = "lblMoveTitle";
            this.lblMoveTitle.Size = new System.Drawing.Size(232, 29);
            this.lblMoveTitle.TabIndex = 219;
            this.lblMoveTitle.Text = "Move Existing Item";
            // 
            // btnMoveReset
            // 
            this.btnMoveReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveReset.Location = new System.Drawing.Point(1099, 432);
            this.btnMoveReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveReset.Name = "btnMoveReset";
            this.btnMoveReset.Size = new System.Drawing.Size(103, 53);
            this.btnMoveReset.TabIndex = 14;
            this.btnMoveReset.Text = "Reset";
            this.btnMoveReset.UseVisualStyleBackColor = true;
            this.btnMoveReset.Click += new System.EventHandler(this.btnMoveReset_Click);
            // 
            // btnMoveAccept
            // 
            this.btnMoveAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAccept.Location = new System.Drawing.Point(988, 432);
            this.btnMoveAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveAccept.Name = "btnMoveAccept";
            this.btnMoveAccept.Size = new System.Drawing.Size(103, 53);
            this.btnMoveAccept.TabIndex = 13;
            this.btnMoveAccept.Text = "Move";
            this.btnMoveAccept.UseVisualStyleBackColor = true;
            this.btnMoveAccept.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblMoveCommodity
            // 
            this.lblMoveCommodity.AutoSize = true;
            this.lblMoveCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCommodity.Location = new System.Drawing.Point(23, 101);
            this.lblMoveCommodity.Name = "lblMoveCommodity";
            this.lblMoveCommodity.Size = new System.Drawing.Size(124, 24);
            this.lblMoveCommodity.TabIndex = 215;
            this.lblMoveCommodity.Text = "Commodity:";
            // 
            // cmbMoveCommodity
            // 
            this.cmbMoveCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCommodity.FormattingEnabled = true;
            this.cmbMoveCommodity.Location = new System.Drawing.Point(165, 97);
            this.cmbMoveCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCommodity.Name = "cmbMoveCommodity";
            this.cmbMoveCommodity.Size = new System.Drawing.Size(332, 31);
            this.cmbMoveCommodity.TabIndex = 2;
            this.cmbMoveCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbMoveCommodity_SelectedIndexChanged);
            // 
            // lblMoveCategory
            // 
            this.lblMoveCategory.AutoSize = true;
            this.lblMoveCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCategory.Location = new System.Drawing.Point(23, 59);
            this.lblMoveCategory.Name = "lblMoveCategory";
            this.lblMoveCategory.Size = new System.Drawing.Size(103, 24);
            this.lblMoveCategory.TabIndex = 216;
            this.lblMoveCategory.Text = "Category:";
            // 
            // cmbMoveCategory
            // 
            this.cmbMoveCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCategory.FormattingEnabled = true;
            this.cmbMoveCategory.Location = new System.Drawing.Point(165, 55);
            this.cmbMoveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCategory.Name = "cmbMoveCategory";
            this.cmbMoveCategory.Size = new System.Drawing.Size(332, 31);
            this.cmbMoveCategory.TabIndex = 1;
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
            this.gbMoveDestination.Location = new System.Drawing.Point(763, 144);
            this.gbMoveDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMoveDestination.Name = "gbMoveDestination";
            this.gbMoveDestination.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMoveDestination.Size = new System.Drawing.Size(439, 282);
            this.gbMoveDestination.TabIndex = 9;
            this.gbMoveDestination.TabStop = false;
            this.gbMoveDestination.Text = "Destination:";
            // 
            // lblMoveToDesc
            // 
            this.lblMoveToDesc.AutoSize = true;
            this.lblMoveToDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveToDesc.Location = new System.Drawing.Point(8, 47);
            this.lblMoveToDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoveToDesc.Name = "lblMoveToDesc";
            this.lblMoveToDesc.Size = new System.Drawing.Size(336, 23);
            this.lblMoveToDesc.TabIndex = 192;
            this.lblMoveToDesc.Text = "Select location to deposit the item to.";
            // 
            // lblMoveRoomTo
            // 
            this.lblMoveRoomTo.AutoSize = true;
            this.lblMoveRoomTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveRoomTo.Location = new System.Drawing.Point(37, 97);
            this.lblMoveRoomTo.Name = "lblMoveRoomTo";
            this.lblMoveRoomTo.Size = new System.Drawing.Size(72, 24);
            this.lblMoveRoomTo.TabIndex = 195;
            this.lblMoveRoomTo.Text = "Room:";
            // 
            // cmbMoveRoomTo
            // 
            this.cmbMoveRoomTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveRoomTo.Enabled = false;
            this.cmbMoveRoomTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveRoomTo.FormattingEnabled = true;
            this.cmbMoveRoomTo.Location = new System.Drawing.Point(180, 94);
            this.cmbMoveRoomTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveRoomTo.Name = "cmbMoveRoomTo";
            this.cmbMoveRoomTo.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveRoomTo.TabIndex = 10;
            this.cmbMoveRoomTo.SelectedIndexChanged += new System.EventHandler(this.cmbMoveRoomTo_SelectedIndexChanged);
            // 
            // lblMoveNLevelTo
            // 
            this.lblMoveNLevelTo.AutoSize = true;
            this.lblMoveNLevelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveNLevelTo.Location = new System.Drawing.Point(37, 215);
            this.lblMoveNLevelTo.Name = "lblMoveNLevelTo";
            this.lblMoveNLevelTo.Size = new System.Drawing.Size(87, 24);
            this.lblMoveNLevelTo.TabIndex = 196;
            this.lblMoveNLevelTo.Text = "N Level:";
            // 
            // cmbMoveNLevelTo
            // 
            this.cmbMoveNLevelTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveNLevelTo.Enabled = false;
            this.cmbMoveNLevelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveNLevelTo.FormattingEnabled = true;
            this.cmbMoveNLevelTo.Location = new System.Drawing.Point(180, 212);
            this.cmbMoveNLevelTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveNLevelTo.Name = "cmbMoveNLevelTo";
            this.cmbMoveNLevelTo.Size = new System.Drawing.Size(71, 31);
            this.cmbMoveNLevelTo.TabIndex = 12;
            // 
            // lblMoveCabinetTo
            // 
            this.lblMoveCabinetTo.AutoSize = true;
            this.lblMoveCabinetTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCabinetTo.Location = new System.Drawing.Point(37, 156);
            this.lblMoveCabinetTo.Name = "lblMoveCabinetTo";
            this.lblMoveCabinetTo.Size = new System.Drawing.Size(89, 24);
            this.lblMoveCabinetTo.TabIndex = 197;
            this.lblMoveCabinetTo.Text = "Cabinet:";
            // 
            // cmbMoveCabinetTo
            // 
            this.cmbMoveCabinetTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveCabinetTo.Enabled = false;
            this.cmbMoveCabinetTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCabinetTo.FormattingEnabled = true;
            this.cmbMoveCabinetTo.Location = new System.Drawing.Point(180, 153);
            this.cmbMoveCabinetTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCabinetTo.Name = "cmbMoveCabinetTo";
            this.cmbMoveCabinetTo.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveCabinetTo.TabIndex = 11;
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
            this.gbMoveSource.Location = new System.Drawing.Point(16, 144);
            this.gbMoveSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMoveSource.Name = "gbMoveSource";
            this.gbMoveSource.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMoveSource.Size = new System.Drawing.Size(452, 282);
            this.gbMoveSource.TabIndex = 3;
            this.gbMoveSource.TabStop = false;
            this.gbMoveSource.Text = "Source:";
            // 
            // lblMoveFromDesc
            // 
            this.lblMoveFromDesc.AutoSize = true;
            this.lblMoveFromDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveFromDesc.Location = new System.Drawing.Point(8, 47);
            this.lblMoveFromDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoveFromDesc.Name = "lblMoveFromDesc";
            this.lblMoveFromDesc.Size = new System.Drawing.Size(374, 23);
            this.lblMoveFromDesc.TabIndex = 192;
            this.lblMoveFromDesc.Text = "Select location to withdraw the item from.";
            // 
            // lblMoveRoomFrom
            // 
            this.lblMoveRoomFrom.AutoSize = true;
            this.lblMoveRoomFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveRoomFrom.Location = new System.Drawing.Point(37, 97);
            this.lblMoveRoomFrom.Name = "lblMoveRoomFrom";
            this.lblMoveRoomFrom.Size = new System.Drawing.Size(72, 24);
            this.lblMoveRoomFrom.TabIndex = 195;
            this.lblMoveRoomFrom.Text = "Room:";
            // 
            // cmbMoveRoomFrom
            // 
            this.cmbMoveRoomFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveRoomFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveRoomFrom.FormattingEnabled = true;
            this.cmbMoveRoomFrom.Location = new System.Drawing.Point(180, 94);
            this.cmbMoveRoomFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveRoomFrom.Name = "cmbMoveRoomFrom";
            this.cmbMoveRoomFrom.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveRoomFrom.TabIndex = 4;
            this.cmbMoveRoomFrom.SelectedIndexChanged += new System.EventHandler(this.cmbMoveRoomFrom_SelectedIndexChanged);
            // 
            // lblMoveNLevelFrom
            // 
            this.lblMoveNLevelFrom.AutoSize = true;
            this.lblMoveNLevelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveNLevelFrom.Location = new System.Drawing.Point(37, 215);
            this.lblMoveNLevelFrom.Name = "lblMoveNLevelFrom";
            this.lblMoveNLevelFrom.Size = new System.Drawing.Size(87, 24);
            this.lblMoveNLevelFrom.TabIndex = 196;
            this.lblMoveNLevelFrom.Text = "N Level:";
            // 
            // cmbMoveNLevelFrom
            // 
            this.cmbMoveNLevelFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveNLevelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveNLevelFrom.FormattingEnabled = true;
            this.cmbMoveNLevelFrom.Location = new System.Drawing.Point(180, 212);
            this.cmbMoveNLevelFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveNLevelFrom.Name = "cmbMoveNLevelFrom";
            this.cmbMoveNLevelFrom.Size = new System.Drawing.Size(71, 31);
            this.cmbMoveNLevelFrom.TabIndex = 6;
            this.cmbMoveNLevelFrom.SelectedIndexChanged += new System.EventHandler(this.cmbMoveNLevelFrom_SelectedIndexChanged);
            // 
            // lblMoveCabinetFrom
            // 
            this.lblMoveCabinetFrom.AutoSize = true;
            this.lblMoveCabinetFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCabinetFrom.Location = new System.Drawing.Point(37, 156);
            this.lblMoveCabinetFrom.Name = "lblMoveCabinetFrom";
            this.lblMoveCabinetFrom.Size = new System.Drawing.Size(89, 24);
            this.lblMoveCabinetFrom.TabIndex = 197;
            this.lblMoveCabinetFrom.Text = "Cabinet:";
            // 
            // cmbMoveCabinetFrom
            // 
            this.cmbMoveCabinetFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveCabinetFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCabinetFrom.FormattingEnabled = true;
            this.cmbMoveCabinetFrom.Location = new System.Drawing.Point(180, 153);
            this.cmbMoveCabinetFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCabinetFrom.Name = "cmbMoveCabinetFrom";
            this.cmbMoveCabinetFrom.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveCabinetFrom.TabIndex = 5;
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
            this.tbpDeleteItem.Location = new System.Drawing.Point(4, 27);
            this.tbpDeleteItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpDeleteItem.Name = "tbpDeleteItem";
            this.tbpDeleteItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpDeleteItem.Size = new System.Drawing.Size(1233, 497);
            this.tbpDeleteItem.TabIndex = 4;
            this.tbpDeleteItem.Text = "Delete Item";
            this.tbpDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnConfirmReset
            // 
            this.btnConfirmReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReset.Location = new System.Drawing.Point(1109, 422);
            this.btnConfirmReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmReset.Name = "btnConfirmReset";
            this.btnConfirmReset.Size = new System.Drawing.Size(103, 53);
            this.btnConfirmReset.TabIndex = 5;
            this.btnConfirmReset.Text = "Reset";
            this.btnConfirmReset.UseVisualStyleBackColor = true;
            this.btnConfirmReset.Click += new System.EventHandler(this.btnConfirmReset_Click);
            // 
            // btnDeleteConfirm
            // 
            this.btnDeleteConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConfirm.Location = new System.Drawing.Point(983, 422);
            this.btnDeleteConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteConfirm.Name = "btnDeleteConfirm";
            this.btnDeleteConfirm.Size = new System.Drawing.Size(119, 53);
            this.btnDeleteConfirm.TabIndex = 4;
            this.btnDeleteConfirm.Text = "Confirm";
            this.btnDeleteConfirm.UseVisualStyleBackColor = true;
            this.btnDeleteConfirm.Click += new System.EventHandler(this.btnDeleteConfirm_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 176);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(470, 24);
            this.label21.TabIndex = 227;
            this.label21.Text = "Change Log: These are the changes to be made.\r\n";
            // 
            // dgvDeletionDelta
            // 
            this.dgvDeletionDelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletionDelta.Location = new System.Drawing.Point(24, 202);
            this.dgvDeletionDelta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDeletionDelta.Name = "dgvDeletionDelta";
            this.dgvDeletionDelta.ReadOnly = true;
            this.dgvDeletionDelta.RowHeadersWidth = 51;
            this.dgvDeletionDelta.Size = new System.Drawing.Size(951, 273);
            this.dgvDeletionDelta.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(540, 44);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(598, 92);
            this.label20.TabIndex = 225;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 29);
            this.label12.TabIndex = 224;
            this.label12.Text = "Delete Existing Item";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 24);
            this.label18.TabIndex = 222;
            this.label18.Text = "Commodity:";
            // 
            // cmbDeleteCommodity
            // 
            this.cmbDeleteCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCommodity.FormattingEnabled = true;
            this.cmbDeleteCommodity.Location = new System.Drawing.Point(163, 101);
            this.cmbDeleteCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDeleteCommodity.Name = "cmbDeleteCommodity";
            this.cmbDeleteCommodity.Size = new System.Drawing.Size(332, 31);
            this.cmbDeleteCommodity.TabIndex = 2;
            this.cmbDeleteCommodity.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCommodity_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(20, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 24);
            this.label19.TabIndex = 223;
            this.label19.Text = "Category:";
            // 
            // cmbDeleteCategory
            // 
            this.cmbDeleteCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCategory.FormattingEnabled = true;
            this.cmbDeleteCategory.Location = new System.Drawing.Point(163, 59);
            this.cmbDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDeleteCategory.Name = "cmbDeleteCategory";
            this.cmbDeleteCategory.Size = new System.Drawing.Size(332, 31);
            this.cmbDeleteCategory.TabIndex = 1;
            this.cmbDeleteCategory.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCategory_SelectedIndexChanged);
            // 
            // frmManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 558);
            this.Controls.Add(this.tbcInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tbpMoveItem.ResumeLayout(false);
            this.tbpMoveItem.PerformLayout();
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
        private System.Windows.Forms.TabPage tbpMoveItem;
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
