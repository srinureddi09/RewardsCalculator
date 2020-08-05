using RewardsCalculatorUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RewardsCalculatorUI.Managers
{
    public interface ICustomerManager
    {
        public Task<Customer> GetCustomer(int id);
        public Task<IList<Customer>> GetCustomers();
    }
}
