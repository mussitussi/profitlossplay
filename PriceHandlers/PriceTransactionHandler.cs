namespace Grr.PriceHandlers
{
    // get prices from transactions
    public class PriceTransactionHandler : ABCPriceHandler
    {
        protected override (bool HasPrice, Price Price) TryGetPrice(string instrumentId)
        {
            return (false, null);
        }
    }
}