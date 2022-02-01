
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.grbFields = new System.Windows.Forms.GroupBox();
            this.chkNLevel = new System.Windows.Forms.CheckBox();
            this.chkSupplier = new System.Windows.Forms.CheckBox();
            this.chkQuanity = new System.Windows.Forms.CheckBox();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboNlevel = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvInventoryView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewInventory
            // 
            this.lblViewInventory.AutoSize = true;
            this.lblViewInventory.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblViewInventory.Location = new System.Drawing.Point(11, 7);
            this.lblViewInventory.Name = "lblViewInventory";
            this.lblViewInventory.Size = new System.Drawing.Size(281, 46);
            this.lblViewInventory.TabIndex = 43;
            this.lblViewInventory.Text = "View Inventory";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExcel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(573, 7);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(188, 63);
            this.btnExcel.TabIndex = 42;
            this.btnExcel.Text = "Export to Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // grbFields
            // 
            this.grbFields.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbFields.Controls.Add(this.chkNLevel);
            this.grbFields.Controls.Add(this.chkSupplier);
            this.grbFields.Controls.Add(this.chkQuanity);
            this.grbFields.Controls.Add(this.chkLocation);
            this.grbFields.Controls.Add(this.chkCategory);
            this.grbFields.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFields.Location = new System.Drawing.Point(413, 75);
            this.grbFields.Margin = new System.Windows.Forms.Padding(4);
            this.grbFields.Name = "grbFields";
            this.grbFields.Padding = new System.Windows.Forms.Padding(4);
            this.grbFields.Size = new System.Drawing.Size(716, 82);
            this.grbFields.TabIndex = 41;
            this.grbFields.TabStop = false;
            this.grbFields.Text = "Fields";
            // 
            // chkNLevel
            // 
            this.chkNLevel.AutoSize = true;
            this.chkNLevel.Checked = true;
            this.chkNLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNLevel.Location = new System.Drawing.Point(553, 31);
            this.chkNLevel.Margin = new System.Windows.Forms.Padding(4);
            this.chkNLevel.Name = "chkNLevel";
            this.chkNLevel.Size = new System.Drawing.Size(105, 30);
            this.chkNLevel.TabIndex = 4;
            this.chkNLevel.Text = "N Level";
            this.chkNLevel.UseVisualStyleBackColor = true;
            // 
            // chkSupplier
            // 
            this.chkSupplier.AutoSize = true;
            this.chkSupplier.Checked = true;
            this.chkSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSupplier.Location = new System.Drawing.Point(427, 31);
            this.chkSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.chkSupplier.Name = "chkSupplier";
            this.chkSupplier.Size = new System.Drawing.Size(113, 30);
            this.chkSupplier.TabIndex = 3;
            this.chkSupplier.Text = "Supplier";
            this.chkSupplier.UseVisualStyleBackColor = true;
            // 
            // chkQuanity
            // 
            this.chkQuanity.AutoSize = true;
            this.chkQuanity.Checked = true;
            this.chkQuanity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuanity.Location = new System.Drawing.Point(296, 31);
            this.chkQuanity.Margin = new System.Windows.Forms.Padding(4);
            this.chkQuanity.Name = "chkQuanity";
            this.chkQuanity.Size = new System.Drawing.Size(116, 30);
            this.chkQuanity.TabIndex = 2;
            this.chkQuanity.Text = "Quantity";
            this.chkQuanity.UseVisualStyleBackColor = true;
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Checked = true;
            this.chkLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLocation.Location = new System.Drawing.Point(160, 31);
            this.chkLocation.Margin = new System.Windows.Forms.Padding(4);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(114, 30);
            this.chkLocation.TabIndex = 1;
            this.chkLocation.Text = "Location";
            this.chkLocation.UseVisualStyleBackColor = true;
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Checked = true;
            this.chkCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCategory.Location = new System.Drawing.Point(23, 31);
            this.chkCategory.Margin = new System.Windows.Forms.Padding(4);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(118, 30);
            this.chkCategory.TabIndex = 0;
            this.chkCategory.Text = "Category";
            this.chkCategory.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(18, 118);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(65, 26);
            this.lblFilter.TabIndex = 40;
            this.lblFilter.Text = "Filter";
            // 
            // cboNlevel
            // 
            this.cboNlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboNlevel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNlevel.FormattingEnabled = true;
            this.cboNlevel.Location = new System.Drawing.Point(103, 114);
            this.cboNlevel.Margin = new System.Windows.Forms.Padding(4);
            this.cboNlevel.Name = "cboNlevel";
            this.cboNlevel.Size = new System.Drawing.Size(219, 34);
            this.cboNlevel.TabIndex = 39;
            this.cboNlevel.Text = "N Level 3";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(13, 79);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 26);
            this.lblSearch.TabIndex = 38;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(103, 75);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 31);
            this.txtSearch.TabIndex = 37;
            // 
            // dgvInventoryView
            // 
            this.dgvInventoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Category,
            this.Location,
            this.Quantity,
            this.Supplier,
            this.NLevel});
            this.dgvInventoryView.Location = new System.Drawing.Point(0, 165);
            this.dgvInventoryView.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventoryView.MultiSelect = false;
            this.dgvInventoryView.Name = "dgvInventoryView";
            this.dgvInventoryView.RowHeadersWidth = 51;
            this.dgvInventoryView.Size = new System.Drawing.Size(1272, 386);
            this.dgvInventoryView.TabIndex = 36;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            // 
            // NLevel
            // 
            this.NLevel.HeaderText = "N Level";
            this.NLevel.MinimumWidth = 6;
            this.NLevel.Name = "NLevel";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            // 
            // NLevel
            // 
            this.NLevel.HeaderText = "N Level";
            this.NLevel.MinimumWidth = 6;
            this.NLevel.Name = "NLevel";
            // 
            this.NLevel.MinimumWidth = 6;
            this.NLevel.Name = "NLevel";
            // 
            // frmViewInventory
            this.ClientSize = new System.Drawing.Size(1273, 558);
            this.Controls.Add(this.lblViewInventory);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grbFields);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboNlevel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvInventoryView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Text = "View Inventory";
            this.Load += new System.EventHandler(this.frmViewInventory_Load);
            this.grbFields.ResumeLayout(false);
            this.grbFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewInventory;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox grbFields;
        private System.Windows.Forms.CheckBox chkNLevel;
        private System.Windows.Forms.CheckBox chkSupplier;
        private System.Windows.Forms.CheckBox chkQuanity;
        private System.Windows.Forms.CheckBox chkLocation;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboNlevel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvInventoryView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLevel;
    }
}