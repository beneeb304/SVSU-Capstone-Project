
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.grbFilterFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
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
            this.btnPrintBarcode.Location = new System.Drawing.Point(844, 69);
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
            this.grbFilterFields.Controls.Add(this.cmbCategory);
            this.grbFilterFields.Controls.Add(this.label1);
            this.grbFilterFields.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilterFields.Location = new System.Drawing.Point(13, 62);
            this.grbFilterFields.Margin = new System.Windows.Forms.Padding(4);
            this.grbFilterFields.Name = "grbFilterFields";
            this.grbFilterFields.Padding = new System.Windows.Forms.Padding(4);
            this.grbFilterFields.Size = new System.Drawing.Size(253, 82);
            this.grbFilterFields.TabIndex = 41;
            this.grbFilterFields.TabStop = false;
            this.grbFilterFields.Text = "Filter Fields";
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
            // dgvCommodity
            // 
            this.dgvCommodity.AllowUserToAddRows = false;
            this.dgvCommodity.AllowUserToDeleteRows = false;
            this.dgvCommodity.AllowUserToOrderColumns = true;
            this.dgvCommodity.AllowUserToResizeColumns = false;
            this.dgvCommodity.AllowUserToResizeRows = false;
            this.dgvCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Location = new System.Drawing.Point(13, 152);
            this.dgvCommodity.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCommodity.MultiSelect = false;
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.ReadOnly = true;
            this.dgvCommodity.RowHeadersVisible = false;
            this.dgvCommodity.RowHeadersWidth = 51;
            this.dgvCommodity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommodity.Size = new System.Drawing.Size(441, 288);
            this.dgvCommodity.TabIndex = 7;
            this.dgvCommodity.TabStop = false;
            this.dgvCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommodity_CellContentClick);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToOrderColumns = true;
            this.dgvDetails.AllowUserToResizeColumns = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(462, 152);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(480, 288);
            this.dgvDetails.TabIndex = 44;
            this.dgvDetails.TabStop = false;
            // 
            // frmViewInventory
            // 
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lblViewInventory);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.grbFilterFields);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvCommodity);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewInventory";
            this.Text = "View Inventory";
            this.Load += new System.EventHandler(this.frmViewInventory_Load);
            this.grbFilterFields.ResumeLayout(false);
            this.grbFilterFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewInventory;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Windows.Forms.GroupBox grbFilterFields;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCommodity;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        //private System.Windows.Forms.DataGridViewTextBoxColumn NLevel;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}
