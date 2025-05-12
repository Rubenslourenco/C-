﻿using System;
using System.Globalization;
using projetoVehicleInterface.Entities;
using projetoVehicleInterface.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] agrs)
        {
            System.Console.WriteLine("Enter Rental data:");
            System.Console.Write("Car model:");
            string model = Console.ReadLine();
            System.Console.Write("Pickup (dd/MM/yyyy hh:mm):");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            System.Console.Write("Return (dd/MM/yyyy hh:mm):");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.Write("Enter price per hour:");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Enter price per day:");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalservice = new RentalService(hour, day);

            rentalservice.ProcessInvoice(carRental);

            System.Console.WriteLine("INVOICE:");
            System.Console.WriteLine(carRental.Invoices);
        }
    }
}