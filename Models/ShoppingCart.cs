using System.Collections;

namespace LanguageFeatures.Models
{
    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new();

        public ShoppingCart(params Product[] products)
        {
            this.products.AddRange(products);
        }
        public IEnumerable<Product>? Products { get => products; }
    }
}
