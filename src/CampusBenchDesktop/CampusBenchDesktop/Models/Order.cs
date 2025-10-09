using System;
using System.Collections.Generic;

namespace CampusBenchDesktop.Models;

//I can't understand when I placed the order!?!?!??!
public partial class Order
{
    public int id { get; set; }
    public string name { get; set; }
    public DateTime dateTime { get; set; }
    public virtual ICollection<Product> products { get; set; } = new List<Product>();
}