using System;
using ProjetoAccount01.Entities;

namespace ProjetoAccount01
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Maria", 100.0, 500.0);

            System.Console.WriteLine(account.Balance);


        }
    }
}