using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;

namespace SVSU_Capstone_Project
{
    /* Class: BarcodeScanner
     * Member of: frmMain
     * Description: Handles when a barcode is scanned anywhere in frmMain.
     * Recognizes the scan will start with a specified character and marks
     * the boolean indicating a scan is happening as true.
     * Once the scan completes (ensures a legit scan by the scan ending with
     * the Enter key and within a total time of 50ms or so) the commodity matching
     * the read in string is given back to frmMain.
     * 
     * Global Variables
     * bool blnStartRead; Used to indicate a potential scan has been initiated.
     * string strReadCode; Holds the string read in by the scan.
     * int intBeginTime; Marks the start time of a scan in milliseconds.
     * CheckedItem checkedItem; Item found as a result of a barcode scan.
     */
    public partial class BarcodeScanner
    {
        public bool blnStartRead { get; set; }
        public string strReadCode { get; set; }
        public int intBeginTime { get; set; }
        public Commodity commodity { get; set; }

        // Constructor to create the barcode scanner object. Only called once per program session.
        public BarcodeScanner()
        {
            this.blnStartRead = false;
            this.strReadCode = "";
            this.intBeginTime = 0;
            this.commodity = null;
        }

        /* Function: isSeqStart
         * Description: Checks if a pressed key equals the required start character.
         * 
         * Local Variables
         * int intKeyValue; the KeyValue passed by the key pressed.
         */
        public bool isSeqStart( KeyEventArgs e )
        {
            if (e.KeyCode == Keys.C || e.KeyCode == Keys.E || e.KeyCode == Keys.S)
            {
                return true;
            }
            return false;
        }

        /* Function beginScan
         * Description: When the character indicating a potential scan is used, record the start time and indicate a scan.
         * 
         * No Local Variables
         */
        public void beginScan( KeyEventArgs e )
        {
            this.blnStartRead = true;
            this.intBeginTime = DateTime.Now.Millisecond;
            this.strReadCode += e.KeyCode.ToString().ToUpper();
        }

        /* Function addToCode
         * Description: Regex each key press and add it to the scanned code if it matches.
         * 
         * Local Variables
         * Regex regex; Used to compare the string value of the key press.
         */
        public void addToCode( KeyEventArgs e )
        {
            if ((e.KeyCode <= Keys.D0 && e.KeyCode >= Keys.D9)
                || (e.KeyCode <= Keys.NumPad0 && e.KeyCode >= Keys.NumPad9))
            {
                this.strReadCode += e.KeyCode.ToString().Substring(1);
            }
            else if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                this.strReadCode += e.KeyCode.ToString().ToLower();
            }
            else if (e.KeyCode == Keys.Oemtilde)
            {
                this.strReadCode += "~";
            }
        }

        public bool isLegit()
        {
            if ((strReadCode.StartsWith("C~") || strReadCode.StartsWith("E~") || strReadCode.StartsWith("S~"))
                && strReadCode.Length >= 10)
            {
                return true;
            }
            return false;
        }

        /* Function getCommodity
         * Description: If a barcode scan seems legit, find the commodity matching the item.
         * If a commodity isn't found, write to console.
         * 
         * Local Variables
         * CheckedItem checkedItem; Stores information about a CheckedItem based on barcode.
         */
        public void getCommodity()
        {
            try { this.commodity = ItemModel.Get<Commodity>(x => x.strBarCode == strReadCode); }
            catch { Console.WriteLine("Commodity not found from Barcode"); }
        } 
        
        /* Function resetValues
         * Description: Sets the barcode scanner back to its default state.
         * 
         * No Local Variables
         */
        public void resetValues()
        {
            this.blnStartRead = false;
            this.strReadCode = "";
            this.intBeginTime = 0;
            this.commodity = null;
        }
    }
}
