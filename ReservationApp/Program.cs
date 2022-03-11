using System;
using static System.Console;
using ReservationApp.Entities;
using ReservationApp.Entities.Exceptions;

namespace ReservationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                WriteLine("Reservation: " + reservation);

                WriteLine();
                WriteLine("Enter date to update the reservation:");
                Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
