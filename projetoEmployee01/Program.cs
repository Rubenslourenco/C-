using System;
using System.Collections.Generic;
using System.Globalization;
using projetoEmployee01.Entities;
namespace projetoEmployee01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>();

            System.Console.WriteLine("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Employee #{i} data: ");
                System.Console.WriteLine("OutSourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value Per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employee.Add(new Employee(name, hours, valuePerHour));
                }

            }


            System.Console.WriteLine();
            System.Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in employee)
            {
                System.Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

