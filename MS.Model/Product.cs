using System.ComponentModel.DataAnnotations;

namespace MS.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;


        public static IEnumerable<Product> MockProducts()
        {
            return new List<Product>()
            {
                new Product{ Id=1,Name="Lenevo G-80", Description="Very fast Laptop",Price=32000 },
                new Product{ Id=1,Name="Lenevo G-60", Description="I V Laptop",Price=30000 }
            };
        }
    }
}