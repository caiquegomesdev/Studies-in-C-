using Heranca.Entities;
using System;
namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob James Marley Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0; // error
        }
    }
}