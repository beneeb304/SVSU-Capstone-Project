namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Log : ContextEntity
    {
        [Column("action")]
        public ItemAction enuAction { get; set; }
        [Column("timestamp"), DataType(DataType.DateTime)]
        public DateTime dtTimestamp { get; set; }
        [Column("notes")]
        public string strNotes { get; set; }
        [Column("quantityChange")]
        public int intQuantityChange { get; set; }

        public virtual User objUser { get; set; }
        public virtual Storage objStorage { get; set; }
    }
    public enum ItemAction{
        Added,
        Moved,
        Used,
        CheckedIn,
        CheckedOut,
        UserLogin,
        Deleted
    }
}
