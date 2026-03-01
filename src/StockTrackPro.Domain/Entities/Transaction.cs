using StockTrackPro.Domain.Common;
using StockTrackPro.Domain.Enums;

namespace StockTrackPro.Domain.Entities;

public class Transaction : BaseEntity
{
    public Guid HoldingId { get; set; }
    public TransactionType Type { get; set; }
    public decimal Quantity { get; set; }
    public decimal PricePerShare { get; set; }
    public decimal TotalAmount { get; set; }
    public string? Notes { get; set; }

    public Holding Holding { get; set; } = null!;
}