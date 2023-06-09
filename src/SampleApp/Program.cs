using SampleApp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApp();
builder.Services.AddAppInfrastructure();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(e => e.MapControllers());

app.Run();
