using FluentValidation;
using MedicalStore.Utils.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Controllers.DTO
{
    public class ChangePasswordDTO
    {
        public string Password { set; get; }
        public string NewPassword { set; get; }
        public string ConfirmNewPassword { set; get; }

    }
    public class ChangePasswordDTOValidator : AbstractValidator<ChangePasswordDTO>
    {
        public ChangePasswordDTOValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.NewPassword).NotEmpty().Length(UserValidator.PASSWORD_MIN, UserValidator.PASSWORD_MAX);
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().Length(UserValidator.PASSWORD_MIN, UserValidator.PASSWORD_MAX);
            

        }
    }
}
