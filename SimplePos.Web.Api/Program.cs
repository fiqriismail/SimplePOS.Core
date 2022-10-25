using SimplePos.Web.Api.Startups;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCommonDependencies();

var app = builder.Build();

app.ConfigureSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();