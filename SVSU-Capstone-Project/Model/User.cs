using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

public class User
{
    [Key]
    public Guid uidTuid { get; set; }
    public string strSvsu_id { get; set; }
    public string strFirst_name { get; set; }
    public string strLast_name { get; set; }
    public string strEmail { get; set; }
    public string strPhone { get; set; }
    public string strHash { get; set; }
    public bool blnIsAdmin { get; set; }

    public virtual List<Log> lstLogs { get; set; }
}