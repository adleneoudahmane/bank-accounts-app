using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{

    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }


        public BankAccount(string owner) {
            this.Owner = owner;
            this.AccountNumber = Guid.NewGuid();
            this.Balance = 0;
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0) { return "You Cannot Deposit $ " + amount; }


            else if (amount > 20000) { return "Deposit Limit Reached"; }

            Balance += amount;
            return "Deposit Completed Successfully";
            
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0) { return "You Cannot Withdraw $ " + amount; }


            else if (amount > Balance) { return "You Don't Have Enough Money"; }

            Balance -= amount;
            return "Withdraw Completed Successfully";

        }

    }

}
