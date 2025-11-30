using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime DateIssued { get; set; }
        public Order Order { get; set; }
    }
}