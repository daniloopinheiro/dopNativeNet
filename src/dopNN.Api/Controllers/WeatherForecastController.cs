using dopNN.Application.DTOs;
using dopNN.Application.Extensions;
using dopNN.Application.Interface;
using dopNN.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dopNN.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecast _weatherService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherForecast weatherForecast
            )
        {
            _weatherService = weatherForecast;
            _logger = logger;
        }

        [HttpGet("first")]
        public async Task<ActionResult<IEnumerable<WeatherForecastDto>>> GetFirst()
        {
            await _weatherService.SeedMockDataAsync();
            var forecasts = await _weatherService.GetAll();
            var dtos = forecasts.Select(f => f.ToDto());
            return Ok(dtos);
        }

        [HttpGet("seconds")]
        public async Task<IEnumerable<WeatherForecastDto>> GetSecunds()
        {
            await _weatherService.SeedMockDataAsync();
            var forecasts = await _weatherService.GetAll();
            var dtos = forecasts.Select(f => f.ToDto());
            return dtos;
        }
    }
}
