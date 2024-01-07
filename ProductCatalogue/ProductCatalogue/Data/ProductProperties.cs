using System.ComponentModel.DataAnnotations;
namespace ProductCatalogue.Data
{
    public class ProductProperties
    {
        [Key]
        public int PropertyId { get; set; }

        public int ProductId { get; set; }

        public string PropertyName { get; set; }

        public string PropertyValue { get; set; }
    }
}
