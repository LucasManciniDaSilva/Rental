using System;
namespace Rental.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Model { get; set; }
        public Invoice Invo { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle model)
        {
            Start = start;
            Finish = finish;
            Model = model;
            Invo = null;
        }
    }
}
