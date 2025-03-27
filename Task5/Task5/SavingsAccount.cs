using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class SavingsAccount : Account
    {
        public double InterestRata {  get; set; }

        public SavingsAccount(string name= "Basmala", double balance=0, double InterestRata = 0) : base(name, balance)
        {
            this.InterestRata = InterestRata;
        }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + (InterestRata * amount));
        }
    }
}
