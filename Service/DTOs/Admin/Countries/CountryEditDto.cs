using FluentValidation;

namespace Service.DTOs.Admin.Countries
{
    public class CountryEditDto
    {
        public string Name { get; set; }
    }

    public class CountryEditDtoValidator : AbstractValidator<CountryEditDto>
    {
        public CountryEditDtoValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(100)
                .WithMessage("Name cannot exceed 100 characters");
        }
    }
}
