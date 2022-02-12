namespace SVSU_Capstone_Project.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using System;

    public class User : ContextEntity
    {
        [Column("svsu_id"), Index(IsUnique = true), MaxLength(8), Required]
        public string strSvsu_id { get; set; }
        [Column("first_name"), Required]
        public string strFirst_name { get; set; }
        [Column("last_name"), Required]
        public string strLast_name { get; set; }
        [Column("email"), Index(IsUnique = true), MaxLength(25), Required]
        public string strEmail { get; set; }
        [Column("phone")]
        public string strPhone { get; set; }
        [Column("hash"), Required]
        public string strHash { get; set; }
        [Column("isAdmin"), Required]
        public bool blnIsAdmin { get; set; }

        public virtual List<Log> lstLogs { get; set; }
        public virtual List<CheckedItem> lstCheckedItems { get; set; }

        // override tostring with name
        public override string ToString()
        {
            return $"{strLast_name}, {strFirst_name}";
        }
    }
}