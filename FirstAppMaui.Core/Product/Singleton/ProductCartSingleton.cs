using FirstAppMaui.Core.Product.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppMaui.Core.Product.Singleton
{
    public class ProductCartSingleton
    {
        private ProductCartSingleton() { }

        public static ProductCartSingleton Instance { get; private set; } = new ProductCartSingleton();

        public List<string> ProductIds { get; private set; } = new List<string>();

        public void AddProductId(string productId) {
            ProductIds.Add(productId);
            Console.WriteLine(productId);
        }
        public void Clear() => ProductIds.Clear();
    }
}
