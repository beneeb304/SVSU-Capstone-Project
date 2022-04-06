using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SVSU_Capstone_Project.Model;

namespace SVSU_Capstone_Project.ViewModel
{
    static class ItemModel
    {
        private static readonly InvDb db = new InvDb();
        private static bool blnCommitHold = false;

        public static List<T> GetMany<T>( Func<T, bool> predicate, params string[] includes ) where T : ContextEntity
        {
            var dbSet = db.Set<T>();
            foreach (string include in includes)
            {
                dbSet.Include(include);
            }
            return predicate != null ? dbSet.Where(predicate).ToList() : dbSet.ToList();
        }

        public static List<T> GetMany<T>() where T : ContextEntity
        {
            //check to make sure we are connected to db
            string conSring = "Data Source=127.0.0.1, 1433; Initial Catalog=CIS022; User ID=CIS022; Password=CIS!@022ComputerInformationSystemsWI022;";
            SqlConnection conn = new SqlConnection(conSring);
            try
            {
                conn.Open();
                //MessageBox.Show("successfull connection", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! No connection to databse!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please check your internet connection and try again. You can also restart the application and try agian.", "Alert");
            }
            return db.Set<T>().ToList();
        }

        public static T Get<T>( Func<T, bool> predicate ) where T : ContextEntity
        {
            //check to make sure we are connected to db
            string conSring = "Data Source=127.0.0.1, 1433; Initial Catalog=CIS022; Persist Security Info=True; User ID=CIS022; Password=CIS!@022ComputerInformationSystemsWI022";
            SqlConnection conn = new SqlConnection(conSring);
            try
            {
                conn.Open();
                //MessageBox.Show("successfull connection", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! No connection to databse!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please check your internet connection and try again. You can also restart the application and try agian.", "Alert");
            }
            return db.Set<T>().FirstOrDefault(predicate);
        }

        public static Guid Add<T>( T obj, out T item ) where T : ContextEntity
        {
            
            //Set tuid
            obj.uidTuid = Guid.NewGuid();

            //Look for duplicate tuid
            while (Get<T>(x => x.uidTuid == obj.uidTuid) != null)
            {
                //Reset new tuid
                obj.uidTuid = Guid.NewGuid();
            }

            item = db.Set<T>().Add(obj);
            if (!blnCommitHold) db.SaveChanges();

            // return the tuid of the newly added object
            return item.uidTuid;
        }

        public static Guid Add<T>( T obj ) where T : ContextEntity
        {
            //check to make sure we are connected to db
            string conSring = "Data Source=127.0.0.1, 1433; Initial Catalog=CIS022; User ID=CIS022; Password=CIS!@022ComputerInformationSystemsWI022;";
            SqlConnection conn = new SqlConnection(conSring);
            try
            {
                conn.Open();
                //MessageBox.Show("successfull connection", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! No connection to databse!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please check your internet connection and try again. You can also restart the application and try agian.", "Alert");
            }

            return Add(obj, out T item);
        }


        public static void Update<T>( T obj ) where T : ContextEntity
        {
            //check to make sure we are connected to db
            string conSring = "Data Source=127.0.0.1, 1433; Initial Catalog=CIS022; User ID=CIS022; Password=CIS!@022ComputerInformationSystemsWI022;";
            SqlConnection conn = new SqlConnection(conSring);
            try
            {
                conn.Open();
                //MessageBox.Show("successfull connection", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! No connection to databse!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please check your internet connection and try again. You can also restart the application and try agian.", "Alert");
            }

            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            if (!blnCommitHold) db.SaveChanges();
        }

        public static void Delete<T>( T obj ) where T : ContextEntity
        {
            //check to make sure we are connected to db
            string conSring = "Data Source=127.0.0.1, 1433; Initial Catalog=CIS022; User ID=CIS022; Password=CIS!@022ComputerInformationSystemsWI022;";
            SqlConnection conn = new SqlConnection(conSring);
            try
            {
                conn.Open();
                //MessageBox.Show("successfull connection", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! No connection to databse!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please check your internet connection and try again. You can also restart the application and try agian.", "Alert");
            }

            db.Set<T>().Remove(obj);
            if (!blnCommitHold) db.SaveChanges();
        }

        public static void StartTransaction()
        {
            blnCommitHold = true;
        }

        public static int CommitTransaction()
        {
            blnCommitHold = false;
            return db.SaveChanges();
        }

        public static bool UseItem( Storage objUsedFrom, User objUser, uint intQuantityChange, string strNotes, Action onDeleted = null )
        {
            if (objUsedFrom.objCommodity.enuCommodityType == ItemType.Consumable && objUsedFrom.intQuantity < intQuantityChange)
            {
                throw new Exception("Not enough quantity in stock to use");
            }
            // create new log entry
            Log objLog = new Log
            {
                dtTimestamp = DateTime.Now,
                enuAction = ItemAction.Used,
                intQuantityChange = objUsedFrom.objCommodity.enuCommodityType == ItemType.Consumable ? -(int)intQuantityChange : (int)intQuantityChange,
                objStorage = objUsedFrom,
                objUser = objUser,
                strNotes = strNotes
            };
            // update quantity in cabinet
            objUsedFrom.intQuantity += objLog.intQuantityChange;

            StartTransaction();
            Add(objLog);
            if (objUsedFrom.intQuantity == 0)
            {
                Delete(objUsedFrom);
                if (onDeleted != null) onDeleted();
            }
            else Update(objUsedFrom);
            return CommitTransaction() > 0;
        }

        public static bool RestockItem( Storage objUsedFrom, User objUser, uint intQuantityChange, string notes )
        {
            // if item is not consumable, throw exception

            //if (objUsedFrom.objCommodity.enuCommodityType != ItemType.Consumable)
            //{
            //    throw new Exception("Item is not restockable");
            //}

            // create new log
            Log objLog = new Log
            {
                dtTimestamp = DateTime.Now,
                enuAction = ItemAction.Added,
                intQuantityChange = (int)intQuantityChange,
                objStorage = objUsedFrom,
                objUser = objUser,
                strNotes = notes
            };
            // update quantity in cabinet
            objUsedFrom.intQuantity += objLog.intQuantityChange;

            StartTransaction();
            Add(objLog);
            Update(objUsedFrom);
            return CommitTransaction() > 0;
        }

        public static bool MoveItem( Storage objMoveFrom, Storage objMoveTo, User objUser, uint intQuantityChange, string notes )
        {
            // check quantity available
            if (objMoveFrom.objCommodity.enuCommodityType == ItemType.Consumable && objMoveFrom.intQuantity < intQuantityChange)
            {
                throw new Exception("Not enough quantity in stock to move");
            }

            // log for location quantity taken
            Log objLogFrom = new Log
            {
                dtTimestamp = DateTime.Now,
                enuAction = ItemAction.Moved,
                intQuantityChange = -(int)intQuantityChange,
                objStorage = objMoveFrom,
                strNotes = $"Relocated Materials from {objMoveFrom.objCabinet.objRoom.strName}.{objMoveFrom.objCabinet.strName}"
            + $" to {objMoveTo.objCabinet.objRoom.strName}.{objMoveTo.objCabinet.strName} : "
            + notes,
                objUser = objUser
            };

            // log for location quantity given
            Log objLogTo = new Log
            {
                dtTimestamp = DateTime.Now,
                enuAction = ItemAction.Moved,
                intQuantityChange = (int)intQuantityChange,
                objStorage = objMoveFrom,
                strNotes = $"Relocated Materials from {objMoveFrom.objCabinet.objRoom.strName}.{objMoveFrom.objCabinet.strName}"
            + $" to {objMoveTo.objCabinet.objRoom.strName}.{objMoveTo.objCabinet.strName} : "
            + notes,
                objUser = objUser
            };

            // update quantity in cabinet
            objMoveFrom.intQuantity += objLogFrom.intQuantityChange;
            objMoveTo.intQuantity += objLogTo.intQuantityChange;

            // add logs and update quantities
            StartTransaction();
            Add(objLogFrom);
            Add(objLogTo);
            Update(objMoveTo);
            if (objMoveFrom.intQuantity == 0) Delete(objMoveFrom);
            else Update(objMoveFrom);
            return CommitTransaction() > 0;
        }
    }
}
