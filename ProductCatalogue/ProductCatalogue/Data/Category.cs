using System.ComponentModel.DataAnnotations;

namespace ProductCatalogue.Data
{
	public class Category
	{
		[Key]
		public int Category_Id { get; set; }

		public string CategoryName { get; set; }

		public string CategoryDescription { get; set; }

		public ICollection<Products> ProductDetails { get; set;}
	}
}
