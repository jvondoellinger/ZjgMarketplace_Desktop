using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppMaui.Core.Product.Response
{
    public class ProductApiResponse
    {
        // Properties 
        public required string Title { get; set; }
        public required string Description { get; set; }
        public decimal Amount { get; set; }
        public required ImagePaths paths { get; set; }

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
