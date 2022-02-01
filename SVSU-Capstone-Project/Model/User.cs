using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

public class User
{
    [Key]
    public Guid tuid { get; set; }
    public string svsu_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string password { get; set; }
    public bool isAdmin { get; set; }

    public virtual List<Log> logs { get; set; }
}