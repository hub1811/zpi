using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class StationaryStoreEmployee
    {
        public int StationaryStoreEmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public StationaryStore Store { get; set; }
    }
}