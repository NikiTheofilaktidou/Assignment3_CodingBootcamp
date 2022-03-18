using Assignment3.Models;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Enums;
using Assignment3.ESHOPContext;
using Assignment3.PaymentMethodStrategy;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopNormalVariations = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
                new FabricVariationNormalStrategy()
            };

            TShirt shirt = new TShirt(Color.BLUE, Fabric.CASHMERE, Size.XS);

            var eshop = new EShop();
            eshop.SetVariation(ShopNormalVariations);

            eshop.CalculateCost(shirt);

            Console.WriteLine("Choose payment method");
            Console.WriteLine("1- Bank Transfer");
            Console.WriteLine("2- Debit Card");
            Console.WriteLine("3- Cash");
            Console.WriteLine("4- Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":eshop.SetPaymentMethod(new BankTransferStrategy()); break;
                case "2":eshop.SetPaymentMethod(new DebitCardStrategy()); break;
                case "3":eshop.SetPaymentMethod(new CashStrategy()); break;
                case "4": Console.WriteLine("User exiting application"); ; break;
                default: Console.WriteLine("Invalid input"); break;
            }
            eshop.Discount(shirt, 50m);
            eshop.PayTShirt(shirt.Price);
        }
    }
}
