using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibary
{
    public class PremiumOverdraftCheckingAccount : CheckingAccount
    {
        public decimal CashbackRate { get; private set; }
        public PremiumOverdraftCheckingAccount(string accountName, string accountHolder, decimal initialBalance, decimal overdraftLimit, decimal cashbackRate) :
            base(accountName, accountHolder, initialBalance, overdraftLimit){ 
                CashbackRate = cashbackRate;

        }

        public void ApplyCashBack(decimal purchaseAmount)
        {
            if (purchaseAmount <= 0) throw new ArgumentException("Purchase amount must be greater than 0");
            var cashback = purchaseAmount * CashbackRate;
            this.Desposit(cashback);
        }
    }
}
