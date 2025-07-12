using dopNN.Application.DTOs;
using dopNN.Domain.Enums;
using FluentValidation;

namespace dopNN.Application.Validators
{
    public class WeatherForecastValidator : AbstractValidator<WeatherForecastDto>
    {
        public WeatherForecastValidator()
        {
            RuleFor(x => x.Date)
            .NotEmpty()
            .WithMessage("A data é obrigatória.");

            RuleFor(x => x.TemperatureCelsius)
                .InclusiveBetween(-50, 60)
                .WithMessage("A temperatura deve estar entre -50°C e 60°C.");

            RuleFor(x => x.Summary)
                .MaximumLength(250)
                .WithMessage("O resumo pode ter no máximo 250 caracteres.");

            RuleFor(x => x.Condition)
                .Must(value => Enum.IsDefined(typeof(WeatherCondition), value))
                .WithMessage("A condição climática informada não é válida.");
        }
    }
}
