namespace CampusBenchApi.Models;

//I can't understand when I placed the order!?!?!??!
public partial class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateTime { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}