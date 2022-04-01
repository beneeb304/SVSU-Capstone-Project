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
        private bool blnStartRead;
        private string strReadCode;
        private int intBeginTime;
        public Commodity commodity;

        // Constructor to create the barcode scanner object. Only called once per program session.
        public BarcodeScanner()
        {
            this.blnStartRead = false;
            this.strReadCode = "";
            this.intBeginTime = 0;
            this.commodity = null;
        }

        /* Function: isSeqStart
         * Description: checks if a pressed key equals the required start character.
         * 
         * Local Variables
         * int intKeyValue; the KeyValue passed by the key pressed.
         */
        public bool isSeqStart(string s) 
        {
            if (s == "C" || s == "S" || s == "E")
            {
                return true;
            }
            return false;
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

        /* Function beginScan
         * Description: When the character indicating a potential scan is used, record the start time and indicate a scan.
         * 
         * No Local Variables
         */
        public void beginScan(string s)
        {
            this.blnStartRead = true;
            this.intBeginTime = DateTime.Now.Millisecond;
            strReadCode += s;
        }

        /* isStartRead returns whether a potential scan is happening or not */
        public bool isStartRead() { return blnStartRead; }

        /* getBeginTime returns the recorded start time in milliseconds of a potential scan */
        public int getBeginTime() { return intBeginTime; }

        /* Function addToCode
         * Description: Regex each key press and add it to the scanned code if it matches.
         * 
         * Local Variables
         * Regex regex; Used to compare the string value of the key press.
         */
        public void addToCode(string s) 
        {
            Regex regex = new Regex("^[a-zA-Z0-9~]+$");
            if (regex.IsMatch(strReadCode))
            {
                this.strReadCode += s;
            }
        }
 
        /* Function getCommodity
         * Description: If a barcode scan seems legit, find the commodity matching the item.
         * If a commodity isn't found, write to console.
         * 
         * Local Variables
         * CheckedItem checkedItem; Stores information about a CheckedItem based on barcode.
         */
        public Commodity getCommodity()
        {
            MessageBox.Show(strReadCode);
            try { commodity = ItemModel.Get<Commodity>(x => x.strBarCode == strReadCode); } 
            catch{ Console.WriteLine("Commodity not found from Barcode"); }
            //resetValues(); // Values are now reset by the receiving function.
            return commodity;
        }
    }
}
