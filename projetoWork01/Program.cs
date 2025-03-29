using projetoWork01.Entities;
using projetoWork01.Entities.Enums;
using System;
using System.Globalization;

namespace projetoWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter department's name: ");
            string deptname = Console.ReadLine() ?? "";
            System.Console.WriteLine("Enter worker data: ");
            System.Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";
            System.Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine() ?? "");
            System.Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptname);
            Worker worker = new Worker(name, level, baseSalary, dept);

            System.Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data: ");
                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }

            System.Console.WriteLine();
            System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            System.Console.WriteLine("Name: " + worker.Name);
            System.Console.WriteLine("Department: " + worker.Department.Name);
            System.Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToSring("F2", CultureInfo.InvariantCulture));


        }
    }
}