using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6.CalculateInterest
{
    public class CalculateInterestPremium : ICalculateInterest
    {
        /// <summary>
        /// производим рассчет процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставк премиального аккаунта по правилам банка
            account.Interest = account.Balance * 0.6;
        }

        /// <summary>
        /// возвращаем тип аккаунта
        /// </summary>
        /// <returns></returns>
        public string AccountType()
        {
            return "Премиальный";
        }       
    }
}
