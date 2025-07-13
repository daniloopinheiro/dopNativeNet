using dopNN.Api.Configurations;
using dopNN.Application.Interface;
using dopNN.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();

builder.Services.AddSwaggerDocumentation();

var app = builder.Build();

app.AddEnvironment();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
