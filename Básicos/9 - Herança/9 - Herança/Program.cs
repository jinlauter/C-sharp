using System;
using _9___Herança.Entities;

namespace _9___Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Account acc = new Account(1001, "Alex", 0.0);
             BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

             Account acc1 = bacc;
             Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
             Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

             BusinessAccount acc4 = (BusinessAccount)acc2;*/

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0,0.01);


        }
    }
}
