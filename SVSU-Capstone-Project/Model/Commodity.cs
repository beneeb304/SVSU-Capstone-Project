using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Commodity
{
    //properties
    [Key]
    public Guid uidTuid { get; set; }
    public string strName { get; set; }
    public string strDescription { get; set; }
    public string strFeatures { get; set; }
    public int intAlert_quantity { get; set; }


    //foreign keys
    public virtual Category objCategory { get; set; }
    public List<Quantity> lstQuantities { get; set; }
    public List<VendorItem> lstVendorItems { get; set; }




}