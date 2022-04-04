using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Interface;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.Auth
{
    public class AuthGuard : IActionFilter
    {
        private readonly IJwtService JWTService;
        private readonly IUserRepository UserRepository;
        public AuthGuard(IJwtService jwtService, IUserRepository userRepository)
        {

            this.JWTService = jwtService;
            this.UserRepository = userRepository;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public bool GuardHandler(ActionExecutingContext context)
        {

            try
            {
                var cookies = new Dictionary<string, string>();
                var values = ((string)context.HttpContext.Request.Headers["Cookie"]).Split(',', ';');


                foreach (var parts in values)
                {
                    var cookieArray = parts.Trim().Split('=');
                    cookies.Add(cookieArray[0], cookieArray[1]);
                }

                if (!cookies.TryGetValue("auth-token", out _))
                {
                    return false;
                }
                var token = this.JWTService.VerifyToken(cookies["auth-token"]).Split(";");

                if (token[0] == null)
                {
                    return false;
                }
                var user = this.UserRepository.GetUserById(token[0]);
                if (user == null)
                {
                    return false;
                }
                Controller controller = context.Controller as Controller;
                controller.ViewData["user"] = user;

                // check user's role
                if (context.ActionArguments.TryGetValue("roles", out _))
                {
                    string roles = context.ActionArguments["roles"] as String;
                    if (!roles.Contains(user.RoleId))
                    {
                        return false;
                    }
                }


                return true;

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            bool isValid = this.GuardHandler(context);
            if (!isValid)
            {
                Controller controller = context.Controller as Controller;
                ServerResponse.SetErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_NOT_ALLOW_ACTION, controller.ViewData);
                context.Result = new ViewResult
                {
                    ViewName = Routers.Login.Page,
                };
                return;
            }
        }

    }
}
