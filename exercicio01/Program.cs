﻿using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Entre com o numero da conta: ");
        int numero = int.Parse(Console.ReadLine()??"0");
        Console.Write("Entre com o titular da conta: ");
        string titular = Console.ReadLine() ?? "";
        Console.Write("Havera deposito inicial (s/n)");
        char resp = char.Parse(Console.ReadLine() ?? "n");

        ContaBancaria conta;
        if (resp == 's' || resp == 'S')
        {
            Console.WriteLine("Entre com o valor de deposito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(numero, titular);
        }
        
        Console.WriteLine();
        Console.WriteLine("\nDados da conta:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com uma quantia para deposito: ");
        double quantia = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("\nDados da conta atualizados:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com uma quantia para deposito: ");
        quantia = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("\nDados da conta atualizados:");
        Console.WriteLine(conta);


        .history/
    }
    }