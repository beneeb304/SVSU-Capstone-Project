using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVSU_Capstone_Project.Model;

namespace SVSU_Capstone_Project.ViewModel
{
    static class ItemModel
    {
        private static InvDb db = new InvDb();

        public static List<T> GetMany<T>( Func<T, bool> predicate, params string[] includes ) where T : ContextEntity
        {
            var dbSet = db.Set<T>();
            foreach( string include in includes )
                dbSet.Include(include);
            return dbSet.Where(predicate).ToList();
        }
        public static List<T> GetMany<T>() where T : ContextEntity
        {
            return db.Set<T>().ToList();
        }

        public static T Get<T>( params Func<T, bool>[] predicates) where T : ContextEntity
        {
            var dbSet = db.Set<T>();
            foreach( var predicate in predicates )
                dbSet.Where(predicate);
            return dbSet.FirstOrDefault();
        }

        public static T Include<T>( this T parent, params string[] propname ) where T : ContextEntity
        {
            // return prop of type R from T with property name = propname
            foreach (string prop in propname)
            {
                if (parent.GetType().GetProperty(prop) != null)
                {
                    parent = db.Entry(parent).Entity.Include(prop);
                }
            }
            return parent;
        }

        public static Guid Add<T>( T obj ) where T : ContextEntity
        {
            T objAdded = db.Set<T>().Add(obj);
            db.SaveChanges();
            // return the tuid of the newly added object
            return objAdded.uidTuid;
        }

        public static void Update<T>( T obj ) where T : ContextEntity
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private static void Delete<T>( T obj ) where T : ContextEntity
        {
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }

        public static void UseItem( Quantity objUsedFrom, User objUser, uint intQuantityChange, string strNotes )
        {
            if (objUsedFrom.objCommodity.enuCommodityType == ItemType.Consumable && objUsedFrom.intQuantity < intQuantityChange)
            {
                throw new Exception("Not enough quantity in stock to use");
            }
            // create new log entry
            Log objLog = new Log();
            objLog.dtTimestamp = DateTime.Now;
            objLog.enuAction = ItemAction.Used;
            objLog.intQuantityChange = objUsedFrom.objCommodity.enuCommodityType == ItemType.Consumable ? -(int)intQuantityChange : (int)intQuantityChange;
            objLog.objCommodity = objUsedFrom.objCommodity;
            objLog.objUser = objUser;
            objLog.strNotes = strNotes;
            // update quantity in cabinet
            objUsedFrom.intQuantity += objLog.intQuantityChange;
        }

        public static void RestockItem( Quantity objUsedFrom, User objUser, uint intQuantityChange, string notes )
        {
            // if item is not consumable, throw exception
            if (objUsedFrom.objCommodity.enuCommodityType != ItemType.Consumable)
            {
                throw new Exception("Item is not restockable");
            }
            // create new log
            Log objLog = new Log();
            objLog.dtTimestamp = DateTime.Now;
            objLog.enuAction = ItemAction.Added;
            objLog.intQuantityChange = (int)intQuantityChange;
            objLog.objCommodity = objUsedFrom.objCommodity;
            objLog.objUser = objUser;
            objLog.strNotes = notes;
            // update quantity in cabinet
            objUsedFrom.intQuantity += objLog.intQuantityChange;

            Add(objLog);
            Update(objUsedFrom);
        }

        public static void MoveItem( Quantity objMoveFrom, Quantity objMoveTo, User objUser, uint intQuantityChange, string notes )
        {
            // check quantity available
            if (objMoveFrom.objCommodity.enuCommodityType == ItemType.Consumable && objMoveFrom.intQuantity < intQuantityChange)
            {
                throw new Exception("Not enough quantity in stock to move");
            }

            // log for location quantity taken
            Log objLogFrom = new Log();
            objLogFrom.dtTimestamp = DateTime.Now;
            objLogFrom.enuAction = ItemAction.Moved;
            objLogFrom.intQuantityChange = -(int)intQuantityChange;
            objLogFrom.objCommodity = objMoveFrom.objCommodity;
            objLogFrom.strNotes = $"Relocated Materials from {objMoveFrom.objCabinet.objRoom.strName}.{objMoveFrom.objCabinet.strName}"
            + $" to {objMoveTo.objCabinet.objRoom.strName}.{objMoveTo.objCabinet.strName} : "
            + notes;
            objLogFrom.objUser = objUser;

            // log for location quantity given
            Log objLogTo = new Log();
            objLogTo.dtTimestamp = DateTime.Now;
            objLogTo.enuAction = ItemAction.Moved;
            objLogTo.intQuantityChange = (int)intQuantityChange;
            objLogTo.objCommodity = objMoveFrom.objCommodity;
            objLogTo.strNotes = $"Relocated Materials from {objMoveFrom.objCabinet.objRoom.strName}.{objMoveFrom.objCabinet.strName}"
            + $" to {objMoveTo.objCabinet.objRoom.strName}.{objMoveTo.objCabinet.strName} : "
            + notes;
            objLogTo.objUser = objUser;

            // update quantity in cabinet
            objMoveFrom.intQuantity += objLogFrom.intQuantityChange;
            objMoveTo.intQuantity += objLogTo.intQuantityChange;

            // add logs and update quantities
            Add(objLogFrom);
            Add(objLogTo);
            Update(objMoveTo);
            if (objMoveFrom.intQuantity == 0) Delete(objMoveFrom);
            else Update(objMoveFrom);
        }
    }
}
