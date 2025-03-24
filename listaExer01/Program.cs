using System.Globalization;
using System.Collections.Generic;
using System;
namespace listaExer01
{

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("How many employees will be registered? ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        List<Employee> list = new List<Employee>();

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Employee #{i + 1}:");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            list.Add(new Employee(id, name, salary));
        }   

        Console.Write("Enter the employee id  that will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine() ?? "0");

        Employee emp = list.Find(x => x.Id == searchId); //busca o id no vetor
        if(emp != null) {
            Console.Write("Enter the percentage: ");
            double porcentage = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            emp.increaseSalary(porcentage);
        }


        System.Console.WriteLine("Update list of employees: ");
        foreach (Employee e in list) {
            Console.WriteLine(e);
        }




    }

}}