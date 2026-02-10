using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task17._6._6.CalculateInterest;

namespace Task17._6._6
{
    public class AccountUser
    {
        ICalculateInterest calculateInterest;
        public AccountUser(ICalculateInterest calcInterest)
        {
            calculateInterest = calcInterest;
        }

        /// <summary>
        /// производим рассчет процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public void CalculateInterest(Account account)
        {
            calculateInterest.CalculateInterest(account);
        }

        /// <summary>
        /// возвращаем тип аккаунта
        /// </summary>
        /// <returns></returns>
        public string AccountType()
        {
            return calculateInterest.AccountType();
        }
    }
}
