﻿using System;
using ProjetoAccount01.Entities;

namespace ProjetoAccount01
{
    class Program
    {
        static void Main(string[] args)
        {
            // BusinessAccount account = new BusinessAccount(8010, "Maria", 100.0, 500.0);

            // System.Console.WriteLine(account.Balance);

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcast
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ///Downcasting

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc4 = (BusinessAccount)acc3;
                acc4.Loan(200.0);
                System.Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                System.Console.WriteLine("Update!");
            }


        }
    }
}