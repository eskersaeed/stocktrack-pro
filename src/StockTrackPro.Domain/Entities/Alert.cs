using StockTrackPro.Domain.Common;
using StockTrackPro.Domain.Enums;

namespace StockTrackPro.Domain.Entities;

public class Alert : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid StockId { get; set; }
    public decimal TargetPrice { get; set; }
    public bool IsAboveTarget { get; set; }
    public AlertStatus Status { get; set; } = AlertStatus.Active;
    public DateTime? TriggeredAt { get; set; }

    public User User { get; set; } = null!;
    public Stock Stock { get; set; } = null!;
}