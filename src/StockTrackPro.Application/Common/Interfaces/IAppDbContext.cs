using Microsoft.EntityFrameworkCore;
using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<User> Users { get; }
    DbSet<Portfolio> Portfolios { get; }
    DbSet<Stock> Stocks { get; }
    DbSet<Holding> Holdings { get; }
    DbSet<Transaction> Transactions { get; }
    DbSet<Alert> Alerts { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}