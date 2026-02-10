using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6.CalculateInterest
{
    // тип счета "Обычный"
    public class CalculateInterestRegular : ICalculateInterest
    {
        /// <summary>
        /// производим рассчет процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }

        /// <summary>
        /// возвращаем тип аккаунта
        /// </summary>
        /// <returns></returns>
        public string AccountType()
        {
            return "Обычный";
        }
    }
}
