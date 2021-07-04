using System.Collections.Generic;

namespace Grr.PriceHandlers
{
    // Get price from pricecapture
    public class PricePriceCaptureHandler : ABCPriceHandler
    {
        private readonly Dictionary<string, (double bid, double ask)> _pcPrices = new Dictionary<string, (double bid, double ask)>
        {
            ["dk1"] = (100.0, 100.5)
        };

        protected override (bool HasPrice, Price Price) TryGetPrice(string instrumentId)
        {
            if (_pcPrices.TryGetValue(instrumentId, out (double bid, double ask) p))
                return (true, new Price(p.bid, p.ask));
            else
                return (false, null);
        }
    }
}
