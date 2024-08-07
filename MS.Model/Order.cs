using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Model
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public Order()
        {
            Products = new List<Product>();
        }
        public IEnumerable<Order> MockOrders()
        {
            return new List<Order>() {
                new Order() { Id = Id,
                Products = Product.MockProducts().ToList()
                }
            };
        }
    }
}
