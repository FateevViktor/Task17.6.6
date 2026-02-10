using Task17._6._6.CalculateInterest;

namespace Task17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            List<Account> accounts = new List<Account>();
            // обычный человек открыл вклад
            AccountUser accountUser1 = new AccountUser(new CalculateInterestRegular());
            account1.Type = accountUser1.AccountType();
            // внес деньги
            account1.Balance = 500;
            // посчитали доход
            accountUser1.CalculateInterest(account1);
            accounts.Add(account1);

            Account account2 = new Account();
            // обычный человек открыл вклад
            AccountUser accountUser2 = new AccountUser(new CalculateInterestRegular());
            account2.Type = accountUser2.AccountType();
            // внес деньги
            account2.Balance = 1000;
            // посчитали доход
            accountUser2.CalculateInterest(account2);
            accounts.Add(account2);

            Account account3 = new Account();
            // человек с зарплатным счетом открыл вклад
            AccountUser accountUser3 = new AccountUser(new CalculateInterestSalary());
            account3.Type = accountUser3.AccountType();
            // внес деньги
            account3.Balance = 100;
            // посчитали доход
            accountUser3.CalculateInterest(account3);
            accounts.Add(account3);

            Account account4 = new Account();
            // человек с премиальным счетом открыл вклад
            AccountUser accountUser4 = new AccountUser(new CalculateInterestPremium());
            account4.Type = accountUser4.AccountType();
            // внес деньги
            account4.Balance = 5000;
            // посчитали доход
            accountUser4.CalculateInterest(account4);
            accounts.Add(account4);

            Console.WriteLine("Список открытых счетов"+"\n");
            foreach (var acc in accounts)
            {
                // вывели информацию
                Console.WriteLine("Тип счета: " + acc.Type +
                                    ". Баланс: " + acc.Balance.ToString() +
                                    ". Начисленный процент: " + acc.Interest.ToString() + "\n");
            }
            

        }
    }
}
