using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Infrastructure.Persistence.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Quantity).HasPrecision(18, 8);
        builder.Property(t => t.PricePerShare).HasPrecision(18, 4);
        builder.Property(t => t.TotalAmount).HasPrecision(18, 4);
        builder.Property(t => t.Type).HasConversion<string>();
    }
}