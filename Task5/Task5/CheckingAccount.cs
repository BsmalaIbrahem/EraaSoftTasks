using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckingAccount : Account
    {
        private const double Fee = 1.5d; 

        public CheckingAccount(string name="Basmala", double balance=0) : base(name, balance) 
        {

        }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
    }
}
