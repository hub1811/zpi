using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class User
    {
        public int IdentityUserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime RegistrationDate { get; set; }
    public ICollection<Customer> Customers { get; set; }
    }
}