using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal IntrestRate { get; set; }

        public SavingsAccount(string owner, decimal intrestRate) : base(owner + " (" + intrestRate + "%)")
        {
            this.IntrestRate = intrestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0) { return "You Cannot Deposit $ " + amount; }


            else if (amount > 20000) { return "Deposit Limit Reached"; }

            Balance += amount + ((IntrestRate / 100) * amount);
            return "Deposit Completed Successfully";

        }
    }
}
