using MedicalStore.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MedicalStore.Auth
{
    public class RoleGuardAttribute : ActionFilterAttribute
    {
        private readonly string roles;
        public RoleGuardAttribute(string roles)
        {
            this.roles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.ActionArguments["roles"] = this.roles;
        }
    }
}
