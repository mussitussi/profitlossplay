using System;
namespace Grr.PriceHandlers
{
    // chain of responsibility pattern
    // ABC: Abstract Base Class
    public abstract class ABCPriceHandler
    {
        protected ABCPriceHandler Next;

        abstract protected (bool HasPrice, Price Price) TryGetPrice(string instrumentId);

        public ABCPriceHandler Append(ABCPriceHandler next)
        {
            ABCPriceHandler last = this;

            while (last.Next != null)
                last = last.Next;

            last.Next = next;
            return this;
        }

        public Price GetPrice(string instrumentId)
        {
            var name = this.GetType().Name;
            Console.WriteLine(name + " is trying to get the price");

            var (hasPrice, price) = TryGetPrice(instrumentId);

            switch ((hasPrice, price, Next))
            {
                case (true, Price p, _):
                    Console.WriteLine(Environment.NewLine + name + " found a price");
                    return p;

                case (false, _, ABCPriceHandler next):
                    return next.GetPrice(instrumentId);

                default:
                    throw new ArgumentException($"Vi fandt desvaerre ingen {nameof(ABCPriceHandler)} som kunne haandtere {nameof(instrumentId)} = '{instrumentId}'", nameof(instrumentId));
            }
        }
    }
}
