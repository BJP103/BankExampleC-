using BankLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankServices
{
    public class InterestService
    {
        public void ApplyInterestToAccount(List<Account> accounts)
        {
            foreach (var account in accounts) {
                if (account is SavingsAccount savingsAccount) {
                    savingsAccount.ApplyInterest();
                    Console.WriteLine($"Interest applies to Saving Account ({savingsAccount.AccountNumber}) New Balance {savingsAccount.Balance:C}");

                }

                if (account is HighInterestSavingsAccount highInterestSavingsAccount) { 
                    highInterestSavingsAccount.ApplyInterest();
                    highInterestSavingsAccount.ApplyBonusInterest(0.1m);
                    Console.WriteLine($"Bonus Interest applied to SavingAcount ({highInterestSavingsAccount}) New Balance {{savingsAccount.Balance:C}}\")");
                }
            }
        }
    }
}
