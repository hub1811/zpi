using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class StationaryStore
    {
         public int StationaryStoreId { get; set; }
        public string Name { get; set; }
        public ICollection<StationaryStoreEmployee> Employees { get; set; }
    }
}