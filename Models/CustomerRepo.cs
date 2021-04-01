using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementProject.Models
{
    public class CustomerRepo : IRepo<Customer>
    {
        public List<Customer> customers { get; set; }

        public CustomerRepo()
        {
            customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Ramesh", Age = 25},
                new Customer() { Id = 2, Name = "Suresh", Age = 30}
            };

        }

        public void AddItem(Customer item)
        {
            customers.Add(item);
        }

        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}
