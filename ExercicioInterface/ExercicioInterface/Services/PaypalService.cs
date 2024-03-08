<<<<<<< HEAD
﻿using ExercicioInterface.Services;

namespace ExercicioInterface.Services
{
    class PaypalService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
=======
﻿using ExercicioInterface.Services;

namespace ExercicioInterface.Services
{
    class PaypalService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}