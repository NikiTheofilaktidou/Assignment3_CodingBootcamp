using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategy
{
    public class BankTransferStrategy : IPaymentMethodStrategy
    {
        public void Discount(TShirt shirt, decimal? percentage)
        {
            if (percentage == null) 
            {
                shirt.Price = shirt.Price - shirt.Price * 0.01m;
            }
            else
            {
                shirt.Price = shirt.Price - shirt.Price * (decimal)percentage;
            }

        }

        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount >10000)
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer got declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer got accepted");
                return true;
            }
        }
    }
}
