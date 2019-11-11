using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace roletop.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"]="Login";
            try
            {
                System.Console.WriteLine("***********************************************");
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine("***********************************************");
                return View("sucesso");

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("erro");

            }

        }
    }
}
