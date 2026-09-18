var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // -> ENDPOINT DE UMA API (config de endpoint + action de retorno)

app.Run();
