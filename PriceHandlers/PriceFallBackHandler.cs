namespace Grr.PriceHandlers
{
    public class PriceFallBackHandler : ABCPriceHandler
    {
        private readonly double _fallbackValue;

        public PriceFallBackHandler(double fallbackValue)
        {
            _fallbackValue = fallbackValue;
        }

        protected override (bool HasPrice, Price Price) TryGetPrice(string instrumentId)
        {
            return (true, new Price(_fallbackValue, _fallbackValue));
        }
    }
}