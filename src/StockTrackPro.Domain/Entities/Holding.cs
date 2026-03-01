using StockTrackPro.Domain.Common;

namespace StockTrackPro.Domain.Entities;

public class Holding : BaseEntity
{
    public Guid PortfolioId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public decimal AverageCostPrice { get; set; }

    public Portfolio Portfolio { get; set; } = null!;
    public Stock Stock { get; set; } = null!;
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}