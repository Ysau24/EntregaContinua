var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "¡Hola Mundo desde ASP.NET Core! Att: Ysauri Jiménez ❤️");

app.Urls.Add("http://0.0.0.0:80");

app.Run();
