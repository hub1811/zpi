using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class AddOrUpdateProductVm
    {
        public int? Id { get; set; } // Nullable, ponieważ może być używane zarówno do tworzenia, jak i aktualizacji.
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public byte[] ImageBytes { get; set; } = Array.Empty<byte>();
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
    }
}