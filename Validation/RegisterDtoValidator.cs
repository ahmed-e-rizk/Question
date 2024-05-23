using FluentValidation;
using Question.Models;

namespace Question.Validation
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {

            RuleFor(x => x.UserName).NotEmpty().NotNull().MaximumLength(30).WithErrorCode("Inv");


            RuleFor(x => x.Email)
                .NotNull().NotEmpty().EmailAddress().WithErrorCode("Email");
            RuleFor(x => x.Password).NotEmpty().NotNull().MinimumLength(5).MaximumLength(20).Matches(
                @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\/\+\*\!\@\#\$\%\^\&\(\)\_])[A-Za-z0-9\/\+\*\!\@\#\$\%\^\&\(\)\_]");
            RuleFor(x => x.Name).MinimumLength(10).MaximumLength(50).WithErrorCode("invalid name");
        }
        
    }
}
