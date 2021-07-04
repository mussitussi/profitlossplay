Chain of Responsibility pattern to get a flexible chain of handlers (providers?) to get the ultimo price for profit and loss.

output from running program:

```
$ dotnet run
PricePriceCaptureHandler is trying to get the price

PricePriceCaptureHandler found a price
{
  "Bid": 100,
  "Ask": 100.5
}
PricePriceCaptureHandler is trying to get the price
PriceProfitLossHandler is trying to get the price

PriceProfitLossHandler found a price
{
  "Bid": 100.5,
  "Ask": 100.5
}
PricePriceCaptureHandler is trying to get the price
PriceProfitLossHandler is trying to get the price
PriceTransactionHandler is trying to get the price
Unhandled exception. System.ArgumentException: Vi fandt desvaerre ingen ABCPriceHandler som kunne haandtere instrumentId = 'hejmor' (Parameter 'instrumentId')
   at Grr.PriceHandlers.ABCPriceHandler.GetPrice(String instrumentId) in C:\Udvikler\tmp\Grr\PriceHandlers\ABCPriceHandler.cs:line 39
   at Grr.PriceHandlers.ABCPriceHandler.GetPrice(String instrumentId) in C:\Udvikler\tmp\Grr\PriceHandlers\ABCPriceHandler.cs:line 36
   at Grr.PriceHandlers.ABCPriceHandler.GetPrice(String instrumentId) in C:\Udvikler\tmp\Grr\PriceHandlers\ABCPriceHandler.cs:line 36
   at Grr.Program.Main(String[] args) in C:\Udvikler\tmp\Grr\Program.cs:line 29

```