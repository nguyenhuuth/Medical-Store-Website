using FluentValidation;
using MedicalStore.Utils.Validator;
using Microsoft.AspNetCore.Identity;

namespace MedicalStore.Controllers.DTO
{
    public class LoginDTO
    {
        public string Username { set; get; }
        public string Password { set; get; }

    }
    public class LoginDTOValidator : AbstractValidator<LoginDTO>
    {
        public LoginDTOValidator()
        {
            RuleFor(x => x.Username).NotEmpty().Length(UserValidator.USERNAME_MIN, UserValidator.USERNAME_MAX);
            RuleFor(x => x.Password).NotEmpty().Length(UserValidator.PASSWORD_MIN, UserValidator.PASSWORD_MAX);

        }
    }
}
