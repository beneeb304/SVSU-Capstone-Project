// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class User
{
    public string tuid { get; set; }
    public string svsu_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string password { get; set; }
    public bool isAdmin { get; set; }

    public virtual List<Log> logs { get; set; }
}