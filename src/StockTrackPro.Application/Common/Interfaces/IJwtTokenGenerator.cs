using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Application.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateAccessToken(User user);
    string GenerateRefreshToken();
}