namespace SimplePos.Web.Api.Startups;

public static class StartupConfig
{
    public static WebApplication ConfigureSwagger(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment()) return app;
        
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
}