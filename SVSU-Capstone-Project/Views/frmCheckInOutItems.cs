﻿using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmCheckInOutItems : Form
    {
        public frmCheckInOutItems()
        {
            InitializeComponent();
            tbcCheckInOut_SelectedIndexChanged(null, null);
        }

        //private void txtQuantity_Display( object sender = null, EventArgs e = null )
        //{
        //    var quantity = ItemModel.Get<Storage>(
        //       x => x.objCabinet == this.objSelectedCabinet
        //       && x.objCommodity == this.objSelectedCommodity
        //       );
        //    this.txtCurrentQty.Text = quantity != null ? quantity.intQuantity.ToString() : "0";
        //}

        private void ListBoxClicked( object sender, EventArgs e )
        {
            if ((sender as ListBox).Name.ToString() == "lstIn")
            {
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;
            }
            else if ((sender as ListBox).Name.ToString() == "lstOut")
            {
                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
            }
        }

        private void tbcCheckInOut_SelectedIndexChanged(object sender,EventArgs e)
        {
            switch (tbcCheckInOut.SelectedTab.Name)
            {
                case "tbpAssets":
                    //populate checked in assets listbox
                    lstCheckedIn.DataSource = ItemModel.GetMany<Commodity>(x => x.objCategory.strName == "Asset").OrderBy(x => x.strName).ToList();
                    break;
                case "tbpConsumables":
                    //populate category dropdown
                    cmbCategory.DataSource = ItemModel.GetMany<Category>(x => x.strName == "Consumable").OrderBy(x => x.strName).ToList();
                    cmbCommodity.DataSource = (cmbCategory.SelectedValue as Category).lstCommodities;
                    break;
            }
        }

        private void cmbCommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            cmbRoom.DataSource = objSelectedCommodity.lstStorage.Select(x => x.objCabinet.objRoom).Distinct().OrderBy(x => x.strName).ToList();
        }

        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            var objSelectedRoom = cmbRoom.SelectedValue as Room;
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            cmbCabinet.DataSource = objSelectedCommodity.lstStorage
            .Where(x => x.objCabinet.objRoom.uidTuid == objSelectedRoom.uidTuid)
            .Select(x => x.objCabinet).Distinct()
            .OrderBy(x => x.strName).ToList();
        }

        private void cmbCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            var quantity = ItemModel.Get<Storage>(
                 x => x.objCabinet == (cmbCabinet.SelectedValue as Cabinet)
                 && x.objCommodity == (cmbCommodity.SelectedValue as Commodity)
               );

            
            this.txtCurrentQty.Text = quantity != null ? quantity.intQuantity.ToString() : "0";

            //Populate N-Level dropdown
            cmbNLevel.DataSource = objSelectedCommodity.lstStorage.Select(x => x.objNLevel.strName).Distinct().ToList();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            cmbCategory.SelectedIndex = -0;
            cmbCommodity.SelectedIndex = -0;
            txtConsumableSvsuID.Text = "";
            txtConsumableNotes.Text = "";
        }
    }
}
