using System.Text.Json;

public class Price
{
    public double Bid { get; }
    public double Ask { get; }

    public Price(double bid, double ask)
    {
        Bid = bid;
        Ask = ask;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
}
