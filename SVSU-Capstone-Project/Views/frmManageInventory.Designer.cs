
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
            this.tbcInventory = new System.Windows.Forms.TabControl();
            this.tbpUseItem = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbUseCabinet = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbUseNLevel = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUseRoom = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbUseCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUseLocation = new System.Windows.Forms.Label();
            this.cmbUseCommodity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUseReset = new System.Windows.Forms.Button();
            this.btnUseAccept = new System.Windows.Forms.Button();
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
            this.tbpCreateItem = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.mtxCreateCost = new System.Windows.Forms.MaskedTextBox();
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
            this.tbcInventory.SuspendLayout();
            this.tbpUseItem.SuspendLayout();
            this.tbpAddItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).BeginInit();
            this.tbcMoveItem.SuspendLayout();
            this.gbMoveDestination.SuspendLayout();
            this.gbMoveSource.SuspendLayout();
            this.tbpCreateItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateAlertQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcInventory
            // 
            this.tbcInventory.Controls.Add(this.tbpUseItem);
            this.tbcInventory.Controls.Add(this.tbpAddItems);
            this.tbcInventory.Controls.Add(this.tbcMoveItem);
            this.tbcInventory.Controls.Add(this.tbpCreateItem);
            this.tbcInventory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcInventory.Location = new System.Drawing.Point(16, 15);
            this.tbcInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcInventory.Name = "tbcInventory";
            this.tbcInventory.SelectedIndex = 0;
            this.tbcInventory.Size = new System.Drawing.Size(1241, 528);
            this.tbcInventory.TabIndex = 0;
            // 
            // tbpUseItem
            // 
            this.tbpUseItem.Controls.Add(this.label17);
            this.tbpUseItem.Controls.Add(this.cmbUseCabinet);
            this.tbpUseItem.Controls.Add(this.label13);
            this.tbpUseItem.Controls.Add(this.cmbUseNLevel);
            this.tbpUseItem.Controls.Add(this.label14);
            this.tbpUseItem.Controls.Add(this.cmbUseRoom);
            this.tbpUseItem.Controls.Add(this.label15);
            this.tbpUseItem.Controls.Add(this.cmbUseCategory);
            this.tbpUseItem.Controls.Add(this.label8);
            this.tbpUseItem.Controls.Add(this.lblUseLocation);
            this.tbpUseItem.Controls.Add(this.cmbUseCommodity);
            this.tbpUseItem.Controls.Add(this.label11);
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
            // cmbUseCabinet
            // 
            this.cmbUseCabinet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUseCabinet.FormattingEnabled = true;
            this.cmbUseCabinet.Location = new System.Drawing.Point(196, 294);
            this.cmbUseCabinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUseCabinet.Name = "cmbUseCabinet";
            this.cmbUseCabinet.Size = new System.Drawing.Size(211, 31);
            this.cmbUseCabinet.TabIndex = 4;
            this.cmbUseCabinet.SelectedValueChanged += new System.EventHandler(this.cmbUseCabinet_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 24);
            this.label13.TabIndex = 184;
            this.label13.Text = "Cabinet:";
            // 
            // cmbUseNLevel
            // 
            this.cmbUseNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUseNLevel.FormattingEnabled = true;
            this.cmbUseNLevel.Location = new System.Drawing.Point(196, 353);
            this.cmbUseNLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUseNLevel.Name = "cmbUseNLevel";
            this.cmbUseNLevel.Size = new System.Drawing.Size(71, 31);
            this.cmbUseNLevel.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 24);
            this.label14.TabIndex = 182;
            this.label14.Text = "N Level:";
            // 
            // cmbUseRoom
            // 
            this.cmbUseRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUseRoom.FormattingEnabled = true;
            this.cmbUseRoom.Location = new System.Drawing.Point(196, 235);
            this.cmbUseRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUseRoom.Name = "cmbUseRoom";
            this.cmbUseRoom.Size = new System.Drawing.Size(211, 31);
            this.cmbUseRoom.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 24);
            this.label15.TabIndex = 180;
            this.label15.Text = "Room:";
            // 
            // cmbUseCategory
            // 
            this.cmbUseCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUseCategory.FormattingEnabled = true;
            this.cmbUseCategory.Location = new System.Drawing.Point(196, 73);
            this.cmbUseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUseCategory.Name = "cmbUseCategory";
            this.cmbUseCategory.Size = new System.Drawing.Size(211, 31);
            this.cmbUseCategory.TabIndex = 1;
            this.cmbUseCategory.SelectedValueChanged += new System.EventHandler(this.cmbUseCategory_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 176;
            this.label8.Text = "Category:";
            // 
            // lblUseLocation
            // 
            this.lblUseLocation.AutoSize = true;
            this.lblUseLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseLocation.Location = new System.Drawing.Point(24, 188);
            this.lblUseLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUseLocation.Name = "lblUseLocation";
            this.lblUseLocation.Size = new System.Drawing.Size(374, 23);
            this.lblUseLocation.TabIndex = 167;
            this.lblUseLocation.Text = "Select location to withdraw the item from.";
            // 
            // cmbUseCommodity
            // 
            this.cmbUseCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUseCommodity.FormattingEnabled = true;
            this.cmbUseCommodity.Location = new System.Drawing.Point(196, 124);
            this.cmbUseCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUseCommodity.Name = "cmbUseCommodity";
            this.cmbUseCommodity.Size = new System.Drawing.Size(211, 31);
            this.cmbUseCommodity.TabIndex = 2;
            this.cmbUseCommodity.SelectedValueChanged += new System.EventHandler(this.cmbUseCommodity_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 24);
            this.label11.TabIndex = 174;
            this.label11.Text = "Commodity:";
            // 
            // btnUseReset
            // 
            this.btnUseReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseReset.Location = new System.Drawing.Point(1103, 416);
            this.btnUseReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUseReset.Name = "btnUseReset";
            this.btnUseReset.Size = new System.Drawing.Size(103, 53);
            this.btnUseReset.TabIndex = 7;
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
            this.btnUseAccept.TabIndex = 8;
            this.btnUseAccept.Text = "Use";
            this.btnUseAccept.UseVisualStyleBackColor = true;
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
            this.btnAddCancel.TabIndex = 8;
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
            this.btnAdd.TabIndex = 9;
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
            // tbcMoveItem
            // 
            this.tbcMoveItem.Controls.Add(this.lblMoveTitle);
            this.tbcMoveItem.Controls.Add(this.btnMoveReset);
            this.tbcMoveItem.Controls.Add(this.btnMoveAccept);
            this.tbcMoveItem.Controls.Add(this.lblMoveCommodity);
            this.tbcMoveItem.Controls.Add(this.cmbMoveCommodity);
            this.tbcMoveItem.Controls.Add(this.lblMoveCategory);
            this.tbcMoveItem.Controls.Add(this.cmbMoveCategory);
            this.tbcMoveItem.Controls.Add(this.gbMoveDestination);
            this.tbcMoveItem.Controls.Add(this.gbMoveSource);
            this.tbcMoveItem.Location = new System.Drawing.Point(4, 27);
            this.tbcMoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcMoveItem.Name = "tbcMoveItem";
            this.tbcMoveItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcMoveItem.Size = new System.Drawing.Size(1233, 497);
            this.tbcMoveItem.TabIndex = 3;
            this.tbcMoveItem.Text = "Move Stock";
            this.tbcMoveItem.UseVisualStyleBackColor = true;
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
            this.btnMoveReset.TabIndex = 217;
            this.btnMoveReset.Text = "Reset";
            this.btnMoveReset.UseVisualStyleBackColor = true;
            // 
            // btnMoveAccept
            // 
            this.btnMoveAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAccept.Location = new System.Drawing.Point(988, 432);
            this.btnMoveAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveAccept.Name = "btnMoveAccept";
            this.btnMoveAccept.Size = new System.Drawing.Size(103, 53);
            this.btnMoveAccept.TabIndex = 218;
            this.btnMoveAccept.Text = "Move";
            this.btnMoveAccept.UseVisualStyleBackColor = true;
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
            this.cmbMoveCommodity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCommodity.FormattingEnabled = true;
            this.cmbMoveCommodity.Location = new System.Drawing.Point(165, 97);
            this.cmbMoveCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCommodity.Name = "cmbMoveCommodity";
            this.cmbMoveCommodity.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveCommodity.TabIndex = 214;
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
            this.cmbMoveCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCategory.FormattingEnabled = true;
            this.cmbMoveCategory.Location = new System.Drawing.Point(165, 55);
            this.cmbMoveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCategory.Name = "cmbMoveCategory";
            this.cmbMoveCategory.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveCategory.TabIndex = 213;
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
            this.gbMoveDestination.Location = new System.Drawing.Point(613, 144);
            this.gbMoveDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMoveDestination.Name = "gbMoveDestination";
            this.gbMoveDestination.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMoveDestination.Size = new System.Drawing.Size(589, 282);
            this.gbMoveDestination.TabIndex = 212;
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
            this.cmbMoveRoomTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveRoomTo.FormattingEnabled = true;
            this.cmbMoveRoomTo.Location = new System.Drawing.Point(180, 94);
            this.cmbMoveRoomTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveRoomTo.Name = "cmbMoveRoomTo";
            this.cmbMoveRoomTo.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveRoomTo.TabIndex = 189;
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
            this.cmbMoveNLevelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveNLevelTo.FormattingEnabled = true;
            this.cmbMoveNLevelTo.Location = new System.Drawing.Point(180, 212);
            this.cmbMoveNLevelTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveNLevelTo.Name = "cmbMoveNLevelTo";
            this.cmbMoveNLevelTo.Size = new System.Drawing.Size(71, 31);
            this.cmbMoveNLevelTo.TabIndex = 191;
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
            this.cmbMoveCabinetTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCabinetTo.FormattingEnabled = true;
            this.cmbMoveCabinetTo.Location = new System.Drawing.Point(180, 153);
            this.cmbMoveCabinetTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCabinetTo.Name = "cmbMoveCabinetTo";
            this.cmbMoveCabinetTo.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveCabinetTo.TabIndex = 190;
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
            this.gbMoveSource.Size = new System.Drawing.Size(589, 282);
            this.gbMoveSource.TabIndex = 211;
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
            this.cmbMoveRoomFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveRoomFrom.FormattingEnabled = true;
            this.cmbMoveRoomFrom.Location = new System.Drawing.Point(180, 94);
            this.cmbMoveRoomFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveRoomFrom.Name = "cmbMoveRoomFrom";
            this.cmbMoveRoomFrom.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveRoomFrom.TabIndex = 189;
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
            this.cmbMoveNLevelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveNLevelFrom.FormattingEnabled = true;
            this.cmbMoveNLevelFrom.Location = new System.Drawing.Point(180, 212);
            this.cmbMoveNLevelFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveNLevelFrom.Name = "cmbMoveNLevelFrom";
            this.cmbMoveNLevelFrom.Size = new System.Drawing.Size(71, 31);
            this.cmbMoveNLevelFrom.TabIndex = 191;
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
            this.cmbMoveCabinetFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveCabinetFrom.FormattingEnabled = true;
            this.cmbMoveCabinetFrom.Location = new System.Drawing.Point(180, 153);
            this.cmbMoveCabinetFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMoveCabinetFrom.Name = "cmbMoveCabinetFrom";
            this.cmbMoveCabinetFrom.Size = new System.Drawing.Size(211, 31);
            this.cmbMoveCabinetFrom.TabIndex = 190;
            // 
            // tbpCreateItem
            // 
            this.tbpCreateItem.Controls.Add(this.label16);
            this.tbpCreateItem.Controls.Add(this.mtxCreateCost);
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
            this.tbpCreateItem.Text = "Create New Item";
            this.tbpCreateItem.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 29);
            this.label16.TabIndex = 155;
            this.label16.Text = "Create New Item";
            // 
            // mtxCreateCost
            // 
            this.mtxCreateCost.Location = new System.Drawing.Point(813, 129);
            this.mtxCreateCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxCreateCost.Mask = "$9999999.00";
            this.mtxCreateCost.Name = "mtxCreateCost";
            this.mtxCreateCost.Size = new System.Drawing.Size(132, 26);
            this.mtxCreateCost.TabIndex = 5;
            this.mtxCreateCost.ValidatingType = typeof(int);
            // 
            // nudCreateAlertQty
            // 
            this.nudCreateAlertQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCreateAlertQty.Location = new System.Drawing.Point(813, 229);
            this.nudCreateAlertQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCreateAlertQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreateAlertQty.Name = "nudCreateAlertQty";
            this.nudCreateAlertQty.Size = new System.Drawing.Size(160, 30);
            this.nudCreateAlertQty.TabIndex = 7;
            // 
            // txtCreateFeatures
            // 
            this.txtCreateFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateFeatures.Location = new System.Drawing.Point(813, 281);
            this.txtCreateFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateFeatures.Name = "txtCreateFeatures";
            this.txtCreateFeatures.Size = new System.Drawing.Size(211, 30);
            this.txtCreateFeatures.TabIndex = 8;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCancel.Location = new System.Drawing.Point(1100, 416);
            this.btnCreateCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(103, 53);
            this.btnCreateCancel.TabIndex = 9;
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
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateDescription.Location = new System.Drawing.Point(197, 181);
            this.txtCreateDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(337, 227);
            this.txtCreateDescription.TabIndex = 3;
            this.txtCreateDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(53, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 24);
            this.lblDescription.TabIndex = 131;
            this.lblDescription.Text = "Description:";
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(625, 284);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(100, 24);
            this.lblFeatures.TabIndex = 129;
            this.lblFeatures.Text = "Features:";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(625, 231);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(148, 24);
            this.lblLowStock.TabIndex = 127;
            this.lblLowStock.Text = "Alert Quantity:";
            // 
            // txtCreateUrl
            // 
            this.txtCreateUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUrl.Location = new System.Drawing.Point(813, 177);
            this.txtCreateUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUrl.Name = "txtCreateUrl";
            this.txtCreateUrl.Size = new System.Drawing.Size(211, 30);
            this.txtCreateUrl.TabIndex = 6;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(625, 181);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(103, 24);
            this.lblLink.TabIndex = 125;
            this.lblLink.Text = "Item URL:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(625, 130);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(61, 24);
            this.lblCost.TabIndex = 124;
            this.lblCost.Text = "Cost:";
            // 
            // cmbCreateCategory
            // 
            this.cmbCreateCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCategory.FormattingEnabled = true;
            this.cmbCreateCategory.Location = new System.Drawing.Point(197, 127);
            this.cmbCreateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateCategory.Name = "cmbCreateCategory";
            this.cmbCreateCategory.Size = new System.Drawing.Size(211, 31);
            this.cmbCreateCategory.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(625, 76);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(84, 24);
            this.lblSupplier.TabIndex = 122;
            this.lblSupplier.Text = "Vendor:";
            // 
            // cmbCreateVendor
            // 
            this.cmbCreateVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateVendor.FormattingEnabled = true;
            this.cmbCreateVendor.Location = new System.Drawing.Point(813, 73);
            this.cmbCreateVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCreateVendor.Name = "cmbCreateVendor";
            this.cmbCreateVendor.Size = new System.Drawing.Size(211, 31);
            this.cmbCreateVendor.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(53, 130);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 24);
            this.lblCategory.TabIndex = 114;
            this.lblCategory.Text = "Category:";
            // 
            // txtCreateItemName
            // 
            this.txtCreateItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateItemName.Location = new System.Drawing.Point(197, 73);
            this.txtCreateItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateItemName.Name = "txtCreateItemName";
            this.txtCreateItemName.Size = new System.Drawing.Size(337, 30);
            this.txtCreateItemName.TabIndex = 1;
            this.txtCreateItemName.TextChanged += new System.EventHandler(this.txtCreateItemName_TextChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(53, 76);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(116, 24);
            this.lblItemName.TabIndex = 112;
            this.lblItemName.Text = "Item Name:";
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
            this.tbpAddItems.ResumeLayout(false);
            this.tbpAddItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).EndInit();
            this.tbcMoveItem.ResumeLayout(false);
            this.tbcMoveItem.PerformLayout();
            this.gbMoveDestination.ResumeLayout(false);
            this.gbMoveDestination.PerformLayout();
            this.gbMoveSource.ResumeLayout(false);
            this.gbMoveSource.PerformLayout();
            this.tbpCreateItem.ResumeLayout(false);
            this.tbpCreateItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateAlertQty)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox mtxCreateCost;
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
        internal System.Windows.Forms.ComboBox cmbUseCategory;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUseLocation;
        internal System.Windows.Forms.ComboBox cmbUseCommodity;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cmbUseCabinet;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cmbUseNLevel;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.ComboBox cmbUseRoom;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
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
    }
}
