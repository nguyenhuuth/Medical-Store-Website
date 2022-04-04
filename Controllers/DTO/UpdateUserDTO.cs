using FluentValidation;
using MedicalStore.Utils.Validator;
using System.Text.RegularExpressions;

namespace MedicalStore.Controllers.DTO
{
    public class UpdateUserDTO
    {
        public string UserId { set; get; }
        public string UserName{ set; get; }
        public string Name { set; get; }

        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string Status { set; get; }
    }

    public class UpdateUserDTOValidator : AbstractValidator<UpdateUserDTO>
    {
        public UpdateUserDTOValidator()
        {

            RuleFor(x => x.Name).NotEmpty().Length(UserValidator.NAME_MIN, UserValidator.NAME_MAX);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Phone).NotEmpty().NotNull().Matches(new Regex(@"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b"));
            RuleFor(x => x.Address).NotEmpty().Length(UserValidator.ADDRESS_MIN, UserValidator.ADDRESS_MAX);
        }
    }
}