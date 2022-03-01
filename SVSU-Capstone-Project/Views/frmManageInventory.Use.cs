﻿using System;
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
        private void btnUseCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Use tab
            cmbUseCabinet.SelectedIndex = -1;
            cmbUseCategory.SelectedIndex = -1;
            cmbUseCommodity.SelectedIndex = -1;
            cmbUseNLevel.SelectedIndex = -1;
            cmbUseRoom.SelectedIndex = -1;
        }


        private void cmbUseCategory_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbUseCommodity.SelectedIndex = -1;
            this.cmbUseCommodity.DataSource = (cmbUseCategory.SelectedItem as Category).lstCommodities.OrderBy(x => x.strName).ToList();
        }
        private void cmbUseCommodity_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbUseRoom.DataSource = (cmbUseCommodity.SelectedItem as Commodity).lstStorage.Select(x => x.objCabinet.objRoom).OrderBy(x => x.strName).ToList();
            this.cmbUseRoom.SelectedIndex = -1;
        }
        private void cmbUseCabinet_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbUseNLevel.DataSource = (cmbUseCabinet.SelectedItem as Cabinet).lstStorage
                .Where(x => x.objCommodity == cmbUseCommodity.SelectedItem as Commodity)
                .Select(x => x.objNLevel)
                .Distinct()
                .OrderBy(x => x.strName)
                .ToList();
        }
        private void cmbUseNLevel_SelectedValueChanged( object sender, EventArgs e )
        {
            
        }
    }
}
