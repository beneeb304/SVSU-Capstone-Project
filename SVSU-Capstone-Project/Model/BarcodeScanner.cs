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
        public string strReadCode;
        private DateTime dteStartTime;
        private Commodity commodity;

        // Constructor to create the barcode scanner object. Only called once per program session.
        public BarcodeScanner()
        {
            this.blnStartRead = false;
            this.strReadCode = "";
            this.dteStartTime = DateTime.Now;
            this.commodity = null;
        }

        /* isStartRead returns the value of btlnStartRead */
        public bool isStartRead() { return this.blnStartRead; }

        /* getStartTime returns the value of intBeginTime */
        public DateTime getStartTime() { return dteStartTime; }

        /* Function: isSeqStart
         * Description: Checks if a pressed key equals the required start character.
         * 
         * Local Variables
         * int intKeyValue; the KeyValue passed by the key pressed.
         */
        public bool isSeqStart( KeyEventArgs e )
        {
            if (e.KeyData == (Keys.C | Keys.Shift) || e.KeyData == (Keys.E | Keys.Shift) || e.KeyData == (Keys.S | Keys.Shift))
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
            this.dteStartTime = DateTime.Now;
            this.strReadCode += e.KeyCode.ToString().ToUpper();
            Console.WriteLine("Entered Key: " + e.KeyCode.ToString() + " at " + dteStartTime);
        }

        /* Function addToCode
         * Description: Regex each key press and add it to the scanned code if it matches.
         * 
         * Local Variables
         * Regex regex; Used to compare the string value of the key press.
         */
        public void addToCode( KeyEventArgs e )
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57)
                || (e.KeyValue >= 96 && e.KeyValue <= 105))
            {
                this.strReadCode += e.KeyCode.ToString().Substring(1);
            }
            else if (e.KeyData >= Keys.A && e.KeyData <= Keys.Z)
            {
                this.strReadCode += e.KeyCode.ToString().ToLower();
            }
            else if (e.KeyData == (Keys.Oem3 | Keys.Shift))
            {
                this.strReadCode += "~";
            }
            Console.WriteLine(e.KeyCode.ToString() + " should be added, strReadCode is: " + strReadCode + " at time: " + DateTime.Now.ToString()); 
        }

        /* Function isLegit
         * Description: Check if a completed barcode scan is legit by checking for specific starting characters and overall length.
         * 
         * No Local Variables
         */
        public bool isLegit( KeyEventArgs e )
        {
            if (strReadCode.StartsWith("C~") || strReadCode.StartsWith("E~") || strReadCode.StartsWith("S~"))
            {
                Console.WriteLine(DateTime.Now.Subtract(getStartTime()).TotalMilliseconds);
                if (DateTime.Now.Subtract(dteStartTime).TotalMilliseconds < 100)
                {
                    Console.WriteLine("IsLegit. True. ");
                    return true;
                }
            }
            Console.WriteLine("IsNotLegit. False. ");
            return false;
        }

        /* Function getCommodity
         * Description: If a barcode scan seems legit, find the commodity matching the item.
         * If a commodity isn't found, write to console.
         * 
         * No Local Variables
         */
        public Commodity getCommodity()
        {
            try 
            {
                this.commodity = ItemModel.Get<Commodity>(x => x.strBarCode == strReadCode);
                Console.WriteLine("Commodity found: " + commodity.strName);
                return this.commodity;
            }
            catch { Console.WriteLine("Commodity not found from Barcode"); }
            return null;
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
            this.dteStartTime = DateTime.Now;
            this.commodity = null;
            Console.WriteLine("Barcode Scanner Reset");
        }
    }
}
