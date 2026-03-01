using StockTrackPro.Domain.Common;

namespace StockTrackPro.Domain.Entities;

public class Portfolio : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Currency { get; set; } = "GBP";
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;
    public ICollection<Holding> Holdings { get; set; } = new List<Holding>();
}