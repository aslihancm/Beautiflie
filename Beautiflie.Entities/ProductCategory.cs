using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiflie.Entities
{
    public class ProductCategory
    {

        public int ProductId { get; set; }
        public Product ProductId { get; set; }
        public int CategoryId { get; set; }

        public Category CategoryId { get; set; }


    }
}
