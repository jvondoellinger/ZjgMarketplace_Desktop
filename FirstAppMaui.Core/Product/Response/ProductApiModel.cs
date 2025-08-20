using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppMaui.Core.Product.Response
{
    public class ProductApiModel
    {
        // Properties 
        public string Id { get; set; }
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
