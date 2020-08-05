using RewardsCalculatorUI.Managers;
using RewardsCalculatorUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RewardsCalculator.Managers
{
    public class CustomerManager : ICustomerManager
    {
        public async Task<Customer> GetCustomer(int id)
        {
            return _customers().SingleOrDefault(x => x.Id == id);
        }

        public async Task<IList<Customer>> GetCustomers()
        {
            return _customers().ToList();
        }

        private IList<Customer> _customers()
        {
            var customers = new List<Customer>();
            var jon = new Customer();
            jon.Id = 1;
            jon.FirstName = "Jon";
            jon.LastName = "Snow";
            jon.Email = "JonSnow@test.com";
            customers.Add(jon);
            jon.Transactions = new List<Transaction>();
            var jonAmzonTran = new Transaction();
            jonAmzonTran.Id = 1;
            jonAmzonTran.Name = "Amzn Transaction";
            jonAmzonTran.Amount = 120;
            jonAmzonTran.Date = DateTime.Parse("07/15/2020");
            jon.Transactions.Add(jonAmzonTran);
            var jonUpsTran = new Transaction();
            jonUpsTran.Id = 2;
            jonUpsTran.Name = "Ups Tran";
            jonUpsTran.Amount = 150;
            jonUpsTran.Date = DateTime.Parse("07/25/2020");
            jon.Transactions.Add(jonUpsTran);
            var jonMacysTran = new Transaction();
            jonMacysTran.Id = 3;
            jonMacysTran.Name = "Macys Tran";
            jonMacysTran.Amount = 75;
            jonMacysTran.Date = DateTime.Parse("08/05/2020");
            jon.Transactions.Add(jonMacysTran);
            var jonUltaTran = new Transaction();
            jonUltaTran.Id = 4;
            jonUltaTran.Name = "Ulta Tran";
            jonUltaTran.Amount = 275;
            jonUltaTran.Date = DateTime.Parse("08/05/2020");
            jon.Transactions.Add(jonUltaTran);
            var jonOldTran = new Transaction();
            jonOldTran.Id = 11;
            jonOldTran.Name = "Old Tran";
            jonOldTran.Amount = 275;
            jonOldTran.Date = DateTime.Parse("01/05/2020");
            jon.Transactions.Add(jonOldTran);

            var arya = new Customer();
            arya.Id = 2;
            arya.FirstName = "Arya";
            arya.LastName = "Stark";
            arya.Email = "AryaStark@test.com";
            customers.Add(arya);
            arya.Transactions = new List<Transaction>();
            var aryaAmzonTran = new Transaction();
            aryaAmzonTran.Id = 5;
            aryaAmzonTran.Name = "Amzn Transaction";
            aryaAmzonTran.Amount = 1120;
            aryaAmzonTran.Date = DateTime.Parse("08/05/2020");
            arya.Transactions.Add(aryaAmzonTran);
            var aryaUpsTran = new Transaction();
            aryaUpsTran.Id = 6;
            aryaUpsTran.Name = "Ups Tran";
            aryaUpsTran.Amount = 1150;
            aryaUpsTran.Date = DateTime.Parse("08/05/2020");
            arya.Transactions.Add(aryaUpsTran);
            var aryaMacysTran = new Transaction();
            aryaMacysTran.Id = 7;
            aryaMacysTran.Name = "Macys Tran";
            aryaMacysTran.Amount = 750;
            aryaMacysTran.Date = DateTime.Parse("07/05/2020");
            arya.Transactions.Add(aryaMacysTran);
            var aryaOldTran = new Transaction();
            aryaOldTran.Id = 12;
            aryaOldTran.Name = "Old Tran";
            aryaOldTran.Amount = 275;
            aryaOldTran.Date = DateTime.Parse("01/05/2020");
            arya.Transactions.Add(aryaOldTran);


            var sansa = new Customer();
            sansa.Id = 3;
            sansa.FirstName = "Sansa";
            sansa.LastName = "Stark";
            sansa.Email = "SansaStark@test.com";
            customers.Add(sansa);
            sansa.Transactions = new List<Transaction>();
            var sansaAmzonTran = new Transaction();
            sansaAmzonTran.Id = 8;
            sansaAmzonTran.Name = "Amzn Transaction";
            sansaAmzonTran.Amount = 1200;
            sansaAmzonTran.Date = DateTime.Parse("07/05/2020");
            sansa.Transactions.Add(sansaAmzonTran);
            var sansaUpsTran = new Transaction();
            sansaUpsTran.Id = 9;
            sansaUpsTran.Name = "Ups Tran";
            sansaUpsTran.Amount = 150;
            sansaUpsTran.Date = DateTime.Parse("07/05/2020");
            sansa.Transactions.Add(sansaUpsTran);
            var sansaMacysTran = new Transaction();
            sansaMacysTran.Id = 10;
            sansaMacysTran.Name = "Macys Tran";
            sansaMacysTran.Amount = 75;
            sansaMacysTran.Date = DateTime.Parse("07/05/2020");
            sansa.Transactions.Add(sansaMacysTran);
            var sansaOldTran = new Transaction();
            sansaOldTran.Id = 13;
            sansaOldTran.Name = "Old Tran";
            sansaOldTran.Amount = 275;
            sansaOldTran.Date = DateTime.Parse("01/05/2020");
            sansa.Transactions.Add(sansaOldTran);

            var tyrion = new Customer();
            tyrion.Id = 4;
            tyrion.FirstName = "Tyrion";
            tyrion.LastName = "Lanister";
            tyrion.Email = "tyrionlanister@test.com";
            customers.Add(tyrion);
            tyrion.Transactions = new List<Transaction>();

            var cersei = new Customer();
            cersei.Id = 5;
            cersei.FirstName = "Cersei";
            cersei.LastName = "Lanister";
            cersei.Email = "cerseilanister@test.com";
            customers.Add(cersei);
            cersei.Transactions = new List<Transaction>();

            return customers;
        }
    }
}
