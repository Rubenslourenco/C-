using System;
using System.Collections.Generic;
using System.Globalization;

using projetoProduto.Entities;

namespace projetoProduto
{

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write("Product" + (i + 1) + " data: ");
                Console.Write("Commo, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (ch == 'i')
                {
                    System.Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'u')
                {
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UseProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            System.Console.WriteLine();
            foreach (Product pro in list)
            {
                System.Console.WriteLine(pro.ToString());
            }
        }

    }
}