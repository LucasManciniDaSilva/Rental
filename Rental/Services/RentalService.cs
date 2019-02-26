using System;
using Rental.Entities;
namespace Rental.Services
{
    public class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }



        BrazilTaxService _brazilTaxService = new BrazilTaxService();



        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice (CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }

            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invo = new Invoice(basicPayment, tax);

        }
    }
}
