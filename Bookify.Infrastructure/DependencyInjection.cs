using Bookify.Application.Abstrastions.Clock;
using Bookify.Application.Abstrastions.Email;
using Bookify.Infrastructure.Clock;
using Bookify.Infrastructure.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IEmailService, EmailService>();

        return services;
    }
}