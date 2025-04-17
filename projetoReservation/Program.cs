using System;
using System.Collections.Generic;
using projetoReservation.Entities;
using projetoReservation.Entities.Exceptions;
namespace projetoReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                System.Console.WriteLine();



                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.Write("Reservation: " + reservation);


                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                System.Console.WriteLine("Error in reservation: " + e.Message);

            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }
            finally
            {
                System.Console.WriteLine("Thank you for using our reservation system!");
            }



        }
    }
}