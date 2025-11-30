using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Address
    {
    public int Id { get; set; }

    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string Country { get; set; } = null!;

    public int? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public int? StationaryStoreId { get; set; }
    public StationaryStore? StationaryStore { get; set; }
    }
}