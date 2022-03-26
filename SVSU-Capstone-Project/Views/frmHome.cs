using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVSU_Capstone_Project.ViewModel;
using SVSU_Capstone_Project.Model;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'invDbDataSet.CheckedItemsTable' table. You can move, or remove it, as needed.
            this.checkedItemsTableAdapter1.Fill(this.invDbDataSet.CheckedItemsTable);
            // TODO: This line of code loads data into the 'invDbDataSet.LowStock' table. You can move, or remove it, as needed.
            this.lowStockTableAdapter.Fill(this.invDbDataSet.LowStock);
           
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnDocumentation_Click( object sender, EventArgs e )
        {
            MessageBox.Show("This will pop up a PDF of the instruction manual from Doc team");
        }
    }
}
