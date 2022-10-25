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
}