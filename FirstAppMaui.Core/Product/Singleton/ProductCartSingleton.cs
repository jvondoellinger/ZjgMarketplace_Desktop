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

        public List<ProductApiModel> ProductModel { get; init; } = new List<ProductApiModel>();

        public void Add(ProductApiModel item) => ProductModel.Add(item);
        public void Remove(ProductApiModel item) => ProductModel.Remove(item);

    }
}
