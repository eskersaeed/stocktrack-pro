using StockTrackPro.Domain.Common;

namespace StockTrackPro.Domain.Entities;

public class Stock : BaseEntity
{
    public string Ticker { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Exchange { get; set; } = string.Empty;
    public string Sector { get; set; } = string.Empty;
    public string Currency { get; set; } = "USD";
    public decimal CurrentPrice { get; set; }
    public DateTime LastPriceUpdate { get; set; }

    public ICollection<Holding> Holdings { get; set; } = new List<Holding>();
    public ICollection<Alert> Alerts { get; set; } = new List<Alert>();
}