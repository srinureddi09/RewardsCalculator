using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RewardsCalculatorUI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
