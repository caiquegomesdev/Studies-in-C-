<<<<<<< HEAD
﻿namespace SolucaoSEMInterface.Services
{
    class BrazilTaxService : ITaxService
    {

        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
=======
﻿namespace SolucaoSEMInterface.Services
{
    class BrazilTaxService : ITaxService
    {

        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}