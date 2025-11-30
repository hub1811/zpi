using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Supplier
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}