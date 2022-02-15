using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmManageInventory : Form
    {
        public frmManageInventory()
        {
            InitializeComponent();
            // Bind Comboboxes to the database so the user has options to select on load
            // Add Tab
            this.cmbAddCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            // Create Tab
            this.cmbCreateCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            this.cmbCreateVendor.DataSource = ItemModel.GetMany<Vendor>().OrderBy(x => x.strName).ToList();
            // Use Tab
            this.cmbUseCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            // Move Tab
            this.cmbMoveCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();

        }
    }
}
