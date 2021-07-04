namespace Grr.PriceHandlers
{
    // get prices from the profit and loss data 
    public class PriceProfitLossHandler : ABCPriceHandler
    {
        private readonly IProfitLossRepository _profitLossRepository;

        public PriceProfitLossHandler(IProfitLossRepository profitLossRepository)
        {
            _profitLossRepository = profitLossRepository;
        }

        protected override (bool HasPrice, Price Price) TryGetPrice(string instrumentId)
        {
            double? maybePrice = _profitLossRepository.GetPrimoPrice(instrumentId);
            if (maybePrice.HasValue)
                return (true, new Price(maybePrice.Value, maybePrice.Value));

            return (false, null);
        }
    }


    public interface IProfitLossRepository
    {
        double? GetPrimoPrice(string instrumentId);
    }

    public class ProfitLossRepository : IProfitLossRepository
    {
        public double? GetPrimoPrice(string instrumentId)
        {
            if (instrumentId == "dk2")
                return 100.5;

            return null;
        }
    }
}