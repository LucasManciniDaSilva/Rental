using System;
namespace Rental.Entities
{
    public class Invoice
    {

        //DEFINED THE VARIABLES
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
       
        //CREATED A CONSTRUCTOR WITH ARGUMENTS
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
         
        }

        //CREATED A CALCULATED PROPERTY
        public double TotalPayment
        {
            get { return BasicPayment + Tax; } 
        }


        //CONVERT THE CLASS INTO A STRING
        public override string ToString()
        {
            return 
                    "Basic Payment: "
                    + BasicPayment.ToString("F2")
                    + "\nTax: " 
                    + Tax.ToString("F2")
                    + "\nTotal Payment: " 
                    + TotalPayment.ToString("F2");
           
        }


    }
}
