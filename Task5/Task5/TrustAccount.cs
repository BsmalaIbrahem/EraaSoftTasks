using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class TrustAccount : SavingsAccount
    {
        private const double Bouns = 50;
        private Dictionary<int, int> WithdrawalsPerYear {  get; set; }
        
        public TrustAccount(string name= "Basmala", double balance=0, double InterestRata = 0) : base(name, balance, InterestRata)
        {
            WithdrawalsPerYear = new Dictionary<int, int>();
        }

        public new bool Deposit(double amount)
        {
            double bouns = 0;
            if (amount >= 5000.00) 
            {
                bouns = Bouns;
            }

            return base.Deposit(amount + bouns);
        }

        public new bool Withdraw(double amount) 
        {
            if(CheckWithdrawalsPerYear() && AmountIsAvailable(amount))
            {
                AddWithdrawalsPerYear();
                return base.Withdraw(amount);
            }

            return false;
            
        }

        private bool CheckWithdrawalsPerYear()
        {
            int currentYear = DateTime.Now.Year;

            if(WithdrawalsPerYear.ContainsKey(currentYear))
            {
                if (WithdrawalsPerYear[currentYear] >= 3)
                    return false;
            }
            return true;
        }

        private bool AmountIsAvailable(double amount) 
        {
            return amount <= Balance * .2;
        }

        private void AddWithdrawalsPerYear()
        {
            int currentYear = DateTime.Now.Year;
            if(WithdrawalsPerYear.ContainsKey(currentYear))
            {
                for(int i=0; i < WithdrawalsPerYear.Count; i++)
                {
                    var item = WithdrawalsPerYear.ElementAt(i);
                    if (WithdrawalsPerYear.ContainsKey(currentYear))
                        WithdrawalsPerYear[currentYear] = item.Value + 1;
                }
            }
                
            else
                WithdrawalsPerYear.Add(currentYear, 1);


        }


    }
}
