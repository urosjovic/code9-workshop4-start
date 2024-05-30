using Code9WebAPI.Models;
using FluentValidation;

namespace Code9WebAPI.Validators
{
    public class AddMovieValidator : AbstractValidator<AddMovieRequest>
    {
        public AddMovieValidator()
        {
            RuleFor(m => m.Title)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(100);

            RuleFor(m => m.ReleaseYear)
               .NotEmpty()
               .Length(4)
               .Matches("^[0-9]*$").WithMessage("ReleaseYear must contain only digits");

            RuleFor(m => m.Rating)
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(5);
        }
    }
}
