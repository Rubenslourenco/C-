using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {

        ContaBancaria conta;    
        Console.Write("Entre com o numero da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o titular da conta");
        string titular = Console.ReadLine();
        Console.write("Havera deposito inicial (s/n)?");
        char resp = char.Parse(Console.ReadLine());

        ContaBancaria conta;
        if (resp == "s" || resp == "S")
        {
            Console.WriteLine("Entre com o valor de deposito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaBancaria(numero, titular, depositoInicial)
        }
        else
        {
            conta = new ContaBancaria(numero, titular);
        }






    }
    }