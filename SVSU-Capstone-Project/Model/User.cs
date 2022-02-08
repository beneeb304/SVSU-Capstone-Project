namespace SVSU_Capstone_Project.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using System;

    public class User: ContextEntity
    {
        [Column("svsu_id")]
        public string strSvsu_id { get; set; }
        [Column("first_name")]
        public string strFirst_name { get; set; }
        [Column("last_name")]
        public string strLast_name { get; set; }
        [Column("email")]
        public string strEmail { get; set; }
        [Column("phone")]
        public string strPhone { get; set; }
        [Column("hash")]
        public string strHash { get; set; }
        [Column("isAdmin")]
        public bool blnIsAdmin { get; set; }

        public virtual List<Log> lstLogs { get; set; }
    }
}