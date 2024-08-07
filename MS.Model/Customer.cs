using System.ComponentModel.DataAnnotations;

namespace MS.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public string ContctNumber { get; set; } = string.Empty;
        public string ContctNumber2 { get; set; } = string.Empty;
    }
}
