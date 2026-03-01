using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Infrastructure.Persistence.Configurations;

public class PortfolioConfiguration : IEntityTypeConfiguration<Portfolio>
{
    public void Configure(EntityTypeBuilder<Portfolio> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Currency).IsRequired().HasMaxLength(3);

        builder.HasMany(p => p.Holdings)
            .WithOne(h => h.Portfolio)
            .HasForeignKey(h => h.PortfolioId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}