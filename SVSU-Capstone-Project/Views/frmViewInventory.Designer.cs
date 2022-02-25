
namespace SVSU_Capstone_Project.Views
{
    partial class frmViewInventory
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
            this.lblViewInventory = new System.Windows.Forms.Label();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.grbFilterFields = new System.Windows.Forms.GroupBox();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNLevel = new System.Windows.Forms.ComboBox();
            this.lblNLevel = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvInventoryView = new System.Windows.Forms.DataGridView();
            this.grbFilterFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewInventory
            // 
            this.lblViewInventory.AutoSize = true;
            this.lblViewInventory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInventory.Location = new System.Drawing.Point(12, 13);
            this.lblViewInventory.Name = "lblViewInventory";
            this.lblViewInventory.Size = new System.Drawing.Size(147, 22);
            this.lblViewInventory.TabIndex = 43;
            this.lblViewInventory.Text = "View Inventory";
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrintBarcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBarcode.Location = new System.Drawing.Point(844, 89);
            this.btnPrintBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(98, 55);
            this.btnPrintBarcode.TabIndex = 6;
            this.btnPrintBarcode.Text = "Print Barcode";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // grbFilterFields
            // 
            this.grbFilterFields.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbFilterFields.Controls.Add(this.cmbVendor);
            this.grbFilterFields.Controls.Add(this.label3);
            this.grbFilterFields.Controls.Add(this.cmbRoom);
            this.grbFilterFields.Controls.Add(this.label2);
            this.grbFilterFields.Controls.Add(this.cmbCategory);
            this.grbFilterFields.Controls.Add(this.label1);
            this.grbFilterFields.Controls.Add(this.cmbNLevel);
            this.grbFilterFields.Controls.Add(this.lblNLevel);
            this.grbFilterFields.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilterFields.Location = new System.Drawing.Point(13, 62);
            this.grbFilterFields.Margin = new System.Windows.Forms.Padding(4);
            this.grbFilterFields.Name = "grbFilterFields";
            this.grbFilterFields.Padding = new System.Windows.Forms.Padding(4);
            this.grbFilterFields.Size = new System.Drawing.Size(823, 82);
            this.grbFilterFields.TabIndex = 41;
            this.grbFilterFields.TabStop = false;
            this.grbFilterFields.Text = "Filter Fields";
            // 
            // cmbVendor
            // 
            this.cmbVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(474, 48);
            this.cmbVendor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(189, 26);
            this.cmbVendor.TabIndex = 4;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.cmbVendor_SelectedIndexChanged);
            this.cmbVendor.Click += new System.EventHandler(this.ClickCmb);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Vendor:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(285, 48);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(106, 26);
            this.cmbRoom.TabIndex = 3;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            this.cmbRoom.Click += new System.EventHandler(this.ClickCmb);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Room:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 18;
            this.cmbCategory.Location = new System.Drawing.Point(8, 48);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(194, 26);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.Click += new System.EventHandler(this.ClickCmb);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Category:";
            // 
            // cmbNLevel
            // 
            this.cmbNLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbNLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNLevel.FormattingEnabled = true;
            this.cmbNLevel.Location = new System.Drawing.Point(731, 48);
            this.cmbNLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNLevel.Name = "cmbNLevel";
            this.cmbNLevel.Size = new System.Drawing.Size(84, 26);
            this.cmbNLevel.TabIndex = 5;
            this.cmbNLevel.SelectedIndexChanged += new System.EventHandler(this.cmbNLevel_SelectedIndexChanged);
            this.cmbNLevel.Click += new System.EventHandler(this.ClickCmb);
            // 
            // lblNLevel
            // 
            this.lblNLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNLevel.AutoSize = true;
            this.lblNLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLevel.Location = new System.Drawing.Point(727, 25);
            this.lblNLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNLevel.Name = "lblNLevel";
            this.lblNLevel.Size = new System.Drawing.Size(73, 19);
            this.lblNLevel.TabIndex = 40;
            this.lblNLevel.Text = "N-Level:";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(186, 31);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 19);
            this.lblSearch.TabIndex = 38;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(275, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvInventoryView
            // 
            this.dgvInventoryView.AllowUserToAddRows = false;
            this.dgvInventoryView.AllowUserToDeleteRows = false;
            this.dgvInventoryView.AllowUserToOrderColumns = true;
            this.dgvInventoryView.AllowUserToResizeColumns = false;
            this.dgvInventoryView.AllowUserToResizeRows = false;
            this.dgvInventoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInventoryView.Location = new System.Drawing.Point(0, 152);
            this.dgvInventoryView.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventoryView.MultiSelect = false;
            this.dgvInventoryView.Name = "dgvInventoryView";
            this.dgvInventoryView.ReadOnly = true;
            this.dgvInventoryView.RowHeadersVisible = false;
            this.dgvInventoryView.RowHeadersWidth = 51;
            this.dgvInventoryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryView.Size = new System.Drawing.Size(955, 301);
            this.dgvInventoryView.TabIndex = 7;
            this.dgvInventoryView.TabStop = false;
            // 
            // frmViewInventory
            // 
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.lblViewInventory);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.grbFilterFields);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvInventoryView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewInventory";
            this.Text = "View Inventory";
            this.Load += new System.EventHandler(this.frmViewInventory_Load);
            this.grbFilterFields.ResumeLayout(false);
            this.grbFilterFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewInventory;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Windows.Forms.GroupBox grbFilterFields;
        private System.Windows.Forms.Label lblNLevel;
        private System.Windows.Forms.ComboBox cmbNLevel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvInventoryView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        //private System.Windows.Forms.DataGridViewTextBoxColumn NLevel;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Label label3;
    }
}
