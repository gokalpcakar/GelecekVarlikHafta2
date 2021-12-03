using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hafta2_Extensions_MVC.CustomAttributes
{
    public class LoginFilter : Attribute, IActionFilter
    {
        // kullanıcı listesi oluşturuluyor.
        private static List<User> users = new List<User>()
        {
            new User()
            {
                UserId = 1,
                Name = "LeBron",
                Surname = "James",
                Email = "lebronjames@gmail.com",
                Password = "123",
                isAuthorized = true
            },
            new User()
            {
                UserId = 2,
                Name = "Stephen",
                Surname = "Curry",
                Email = "chefcurry@gmail.com",
                Password = "456",
                isAuthorized = true
            },
            new User()
            {
                UserId = 3,
                Name = "Nikola",
                Surname = "Jokic",
                Email = "jokerjokic@gmail.com",
                Password = "789",
                isAuthorized = false
            }
        };

        private string email;
        private string password;

        // attribute parametre kullansın diye bu metodu yazıyoruz.
        public LoginFilter(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // İlgili action metodu bittiğinde kullanıcı hakkındaki bilgileri değişkenlere alıyoruz.
            string remoteIpAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
            string remotePort = context.HttpContext.Connection.RemotePort.ToString();
            string protocol = context.HttpContext.Request.Protocol.ToString();

            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            // kullanıcının yetkisi, email ve şifre bilgileri geçerli değilse error sayfasına yönlendiriliyor.
            if (!users.Any(x => x.isAuthorized == true && x.Email == email && x.Password == password))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Error" }));
            }

            return;
        }
    }
}
