var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection(); // -> ENTENDE A EXISTÊNCIA DE "HTTPS" ALÉM DE "HTTP"
app.MapControllers();

app.Run();
