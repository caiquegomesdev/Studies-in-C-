using System;
using ExcecoesPersonalizadas01.Entities;

public class ProcessFile
{
    public static void Main()
    {
        Console.WriteLine("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn) {
            Console.WriteLine("Error in reservation: Check-Out date msut be after check-in date");
        }
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation; " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter dataa to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
            }
            else
            {
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Resevation: " + reservation);
            }
        }
        
    }
}