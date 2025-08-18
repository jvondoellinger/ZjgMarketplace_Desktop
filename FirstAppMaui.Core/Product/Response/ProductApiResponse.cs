using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppMaui.Core.Product.Response
{
    public class ProductApiResponse
    {
        // Temporary method do test
        public static List<ProductApiResponse> Get() {
            var list = new List<ProductApiResponse>(); // Heap
            for (int i = 0; i < 15; i++)
            {
                var p = new ProductApiResponse
                {
                    Title = i.ToString(),
                    Description = $"Description to: {i.ToString()}",
                    Amount = decimal.Parse("123"),
                    Paths = new ImagePaths()
                    {
                        Paths = new List<string> { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYzrJyo7zV_4vYQzjlgJav3ahooT54E8xTvg&s" }
                    }
                };
                list.Add(p);
            }
            return list;
        }

        // Properties 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public ImagePaths Paths { get; set; }

        // Custom class

        public class ImagePaths // Seria mais um composite, mas ok...
        {
            public List<string> Paths { get; set; }
        }

        public class ImagePath
        {
            public string CompletePath { get; set; }
        }
    }
}
