using Microsoft.Extensions.DependencyInjection;
using StockTrackPro.Application.Auth.Commands;

namespace StockTrackPro.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(RegisterCommand).Assembly));

        return services;
    }
}