using System.ComponentModel.DataAnnotations;
namespace ProductCatalogue.Data
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public int CategoryID { get; set; }

        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public int Quantity { get; set; }

        public ICollection<ProductProperties> PropertyDetails { get; set; }

    }
}
