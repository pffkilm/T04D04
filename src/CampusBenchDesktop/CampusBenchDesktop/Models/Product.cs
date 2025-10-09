using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CampusBenchDesktop.Models;

public partial class Product
{
    public int id { get; set; }
    public string name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Order> orders { get; set; } = new List<Order>();
}