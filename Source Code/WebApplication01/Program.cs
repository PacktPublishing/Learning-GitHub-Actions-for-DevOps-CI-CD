var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello GitHub Action!!!  TechSckool is now live with latest code");

app.Run();
