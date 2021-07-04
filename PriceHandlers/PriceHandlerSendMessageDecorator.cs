namespace Grr.PriceHandlers     
{
    public class PriceHandlerSendMessageDecorator : ABCPriceHandler
    {
        private readonly ABCPriceHandler _wrapped;

        public PriceHandlerSendMessageDecorator(ABCPriceHandler wrapped)
        {
            _wrapped = wrapped;
        }

        protected override (bool HasPrice, Price Price) TryGetPrice(string instrumentId)
        {
            return (false, null);
        }
    }
}