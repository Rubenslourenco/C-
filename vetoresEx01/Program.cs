using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()??"0");

            Produto[] vect =  new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine() ?? "";
                double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                vect[i] = new Produto(nome = nome,preco = preco);
                
            }

            double sum = 0.0;
            for  (int i = 0; i <n; i++) {
                sum += vect[i].preco;
            }

            double avg = sum / n;


            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        }