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
        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            Category_SelectedValueChanged(cmbMoveCategory, cmbMoveCommodity);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveCommodity_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (blnEventBlock) return;
            Commodity_SelectedValueChanged(cmbMoveCommodity, cmbMoveRoomFrom);
            if (cmbMoveCommodity.SelectedIndex != -1)
            {
                nonTriggeringCall(() => cmbMoveRoomTo.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).ToList());
                cmbMoveCabinetTo.Enabled = true;
                cmbMoveRoomTo.Enabled = true;
                cmbMoveNLevelTo.Enabled = true;
                cmbMoveRoomTo.SelectedIndex = -1;

            }
                

        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveRoomFrom_SelectedIndexChanged( object sender, EventArgs e )
        {
            Room_SelectedValueChanged(cmbMoveRoomFrom, cmbMoveCabinetFrom, cmbMoveCommodity);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveCabinetFrom_SelectedIndexChanged( object sender, EventArgs e )
        {
            Cabinet_SelectedValueChanged(cmbMoveCabinetFrom, cmbMoveCommodity, cmbMoveNLevelFrom);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveNLevelFrom_SelectedIndexChanged( object sender, EventArgs e )
        {
            NLevel_SelectedValueChanged(cmbMoveCommodity, cmbMoveCabinetFrom, cmbMoveNLevelFrom, txtMoveAvailable, nudMoveQuantity);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveRoomTo_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (blnEventBlock) return;
            if (cmbMoveRoomTo.SelectedIndex != -1)                
                nonTriggeringCall(() => cmbMoveCabinetTo.DataSource = (cmbMoveRoomTo.SelectedItem as Room).lstCabinets.OrderBy(x => x.strName).ToList());
            else
                cmbMoveCabinetTo.DataSource = null;
            cmbMoveCabinetTo.SelectedIndex = -1;

        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbMoveCabinetTo_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (blnEventBlock) return;
            if (cmbMoveCabinetTo.SelectedIndex != -1)
                nonTriggeringCall(() => cmbMoveNLevelTo.DataSource = ItemModel.GetMany<NLevel>().OrderBy(x => x.strName).ToList());
            else
                cmbMoveNLevelTo.DataSource = null;
            cmbMoveNLevelTo.SelectedIndex = -1;
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnMoveReset_Click( object sender, EventArgs e )
        {
            cmbMoveCategory.SelectedIndex = -1;
            cmbMoveRoomTo.SelectedIndex = -1;
            txtMoveAvailable.Text = "";
            nudMoveQuantity.Value = 1;
            cmbMoveCabinetTo.Enabled = false;
            cmbMoveRoomTo.Enabled = false;
            cmbMoveNLevelTo.Enabled = false;

        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnMove_Click( object sender, EventArgs e )
        {
            //Check if all fields are filled out
            if (cmbMoveCategory.SelectedIndex == -1 ||
                cmbMoveCommodity.SelectedIndex == -1 ||
                cmbMoveRoomFrom.SelectedIndex == -1 ||
                cmbMoveCabinetFrom.SelectedIndex == -1 ||
                cmbMoveNLevelFrom.SelectedIndex == -1 ||
                cmbMoveRoomTo.SelectedIndex == -1 ||
                cmbMoveCabinetTo.SelectedIndex == -1 ||
                cmbMoveNLevelTo.SelectedIndex == -1
            )
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMoveRoomFrom.SelectedItem == cmbMoveRoomTo.SelectedItem &&
                cmbMoveCabinetFrom.SelectedItem == cmbMoveCabinetTo.SelectedItem &&
                cmbMoveNLevelFrom.SelectedItem == cmbMoveNLevelTo.SelectedItem)
            {
                MessageBox.Show("Cannot move inventory to the same location.", "Alert");
            }
            else
            {
                //Double check for positive quantity?
                if (int.Parse(txtMoveAvailable.Text) < 1)
                {
                    MessageBox.Show("Must have positive inventory to move!", "Alert");
                }
                else
                {
                    var storageSource = ItemModel.Get<Storage>(x => x.objCommodity == (cmbMoveCommodity.SelectedItem as Commodity) && x.objCabinet == (cmbMoveCabinetFrom.SelectedItem as Cabinet) && x.objNLevel == (cmbMoveNLevelFrom.SelectedItem as NLevel));
                    var storageDestination = ItemModel.Get<Storage>(x => x.objCommodity == (cmbMoveCommodity.SelectedItem as Commodity) && x.objCabinet == (cmbMoveCabinetTo.SelectedItem as Cabinet) && x.objNLevel == (cmbMoveNLevelTo.SelectedItem as NLevel));
                    if (storageDestination == null)
                    {
                        // create new storage
                        ItemModel.Add<Storage>(new Storage()
                        {
                            objCommodity = (cmbMoveCommodity.SelectedItem as Commodity),
                            objCabinet = (cmbMoveCabinetTo.SelectedItem as Cabinet),
                            objNLevel = (cmbMoveNLevelTo.SelectedItem as NLevel),
                            intQuantity = 0
                        }, out storageDestination);
                    }
                    ItemModel.MoveItem(
                        storageSource,
                        storageDestination,
                        Authentication.ActiveUser,
                        (uint)nudMoveQuantity.Value,
                        ""
                    );
                    MessageBox.Show("Item(s) moved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnMoveReset_Click(null, null);
                }
            }
        }
    }
}
