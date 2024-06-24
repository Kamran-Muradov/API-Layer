using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Service.DTOs.Admin.Countries;
using Service.Services;
using Service.Services.Interfaces;

namespace Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(config =>
            {
                config.DisableDataAnnotationsValidation = true;
            });

            services.AddScoped<IValidator<CountryCreateDto>, CountryCreateDtoValidator>();
            services.AddScoped<IValidator<CountryEditDto>, CountryEditDtoValidator>();
            services.AddScoped<ICountryService, CountryService>();

            return services;
        }
    }
}
