<<<<<<< HEAD
﻿using System.Globalization;

namespace SolucaoInterface.Entities
{
    class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
=======
﻿using System.Globalization;

namespace SolucaoInterface.Entities
{
    class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}