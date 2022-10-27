using SimplePos.Web.Api.Brokers.Loggings;

namespace SimplePos.Web.Api.Startups;

public static class StartupDependency
{
    public static IServiceCollection AddCommonDependencies(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static IServiceCollection AddAppDepedencies(this IServiceCollection services)
    {
        services.AddTransient<ILoggingBroker, LoggingBroker>();

        return services;
    }
}