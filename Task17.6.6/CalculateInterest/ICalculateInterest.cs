using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6.CalculateInterest
{
    public interface ICalculateInterest
    {
        void CalculateInterest(Account account);
        string AccountType();
    }
}
