using System;
using Grr.PriceHandlers;

namespace Grr
{
    class Program
    {
        static void Main(string[] args)
        {
            ABCPriceHandler handler1 = new PricePriceCaptureHandler();
            ABCPriceHandler handler2 = new PriceProfitLossHandler(new ProfitLossRepository());
            ABCPriceHandler handler3 = new PriceTransactionHandler();
            // ABCPriceHandler handler4 = new PriceFallBackHandler(0.0);

            var handler = 
                handler1
                .Append(handler2)
                .Append(handler3);
                // .Append(handler4);

            var price = handler.GetPrice("dk1");
            Console.WriteLine(price.ToJson());
            
            price = handler.GetPrice("dk2");
            Console.WriteLine(price.ToJson());

            price = handler.GetPrice("hejmor");
            Console.WriteLine(price.ToJson());
        }
    }
}
