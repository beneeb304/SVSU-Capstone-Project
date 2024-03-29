﻿using System;
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
using System.IO;
using System.Net.NetworkInformation;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            
            //Check if the user somehow closed the login form
            if (Authentication.ActiveUser != null)
                populateTables();
        }

        private void frmHome_Load( object sender, EventArgs e )
        {

        }

        private void btnUserGuide_Click( object sender, EventArgs e )
        {
            try
            {
                var projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
                string filePath = Path.Combine(projectPath, "Resources\\User_Guide.pdf");
                System.Diagnostics.Process.Start(filePath);
            }
            catch
            {
                MessageBox.Show("Could not open User Guide PDF! Please make sure:\r\r" +
                    "The file isn't already opened.\r" +
                    "The file exists in the resource folder.\r" +
                    "A default PDF viewer is set and installed.", "Alert");
            }
        }

        public void populateTables()
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

    }
}
