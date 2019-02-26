using System;
using Rental.Entities;
using Rental.Services;
using System.Globalization;


namespace Rental
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the rental data:");
            Console.Write("Enter the car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter the price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.Write("Enter the price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine());


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invo);



        }
    }
}

