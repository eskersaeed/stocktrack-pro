using MediatR;
using StockTrackPro.Contracts.Auth;

namespace StockTrackPro.Application.Auth.Commands;

public record LoginCommand(
    string Email,
    string Password
) : IRequest<AuthResponse>;