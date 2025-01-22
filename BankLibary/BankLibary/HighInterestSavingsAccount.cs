using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibary
{
    public class HighInterestSavingsAccount : SavingsAccount
    {
        public HighInterestSavingsAccount(string accountNumber, string accountName, decimal initialBalance, decimal interestRate): 
            base(accountNumber, accountName, initialBalance, interestRate) 
        {
        
        }
        public void ApplyBonusInterest(decimal bonusRate) 
        {
            decimal bonusInterestPayment = this.Balance * bonusRate;
            this.Desposit(bonusInterestPayment);
        }
    }
}
