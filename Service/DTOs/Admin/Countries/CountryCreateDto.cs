using FluentValidation;

namespace Service.DTOs.Admin.Countries
{
    public class CountryCreateDto
    {
        public string Name { get; set; }
    }

    public class CountryCreateDtoValidator : AbstractValidator<CountryCreateDto>
    {
        public CountryCreateDtoValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(100)
                .WithMessage("Name cannot exceed 100 characters");
        }
    }
}
