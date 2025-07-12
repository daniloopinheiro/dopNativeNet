using dopNN.Application.Interface;
using dopNN.Application.Services;

namespace dopNN.Api.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Registrar IWeatherForecast para injeção de dependência
            services.AddScoped<IWeatherForecast, WeatherForecastService>();

            // Outros serviços (controllers, etc)
            services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            services.AddOpenApi();

            return services;
        }

        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            // Configurar SwaggerGen com nome do projeto dopNN
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "dopNN API",
                    Version = "v1",
                    Description = "API do projeto dopNN"
                });
            });
            return services;
        }

        public static WebApplication AddEnvironment(this WebApplication app)
        {
            // Configurar o pipeline HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "dopNN API V1");
                    c.RoutePrefix = string.Empty; // Swagger na raiz (opcional)
                });
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            return app;
        }
    }
}
