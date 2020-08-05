using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RewardsCalculatorUI.Managers;
using RewardsCalculatorUI.Models;

namespace RewardsCalculatorUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerManager _customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        // GET: api/Customer
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _customerManager.GetCustomers();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Customer> Get(int id)
        {
            return await _customerManager.GetCustomer(id);
        }
    }
}
