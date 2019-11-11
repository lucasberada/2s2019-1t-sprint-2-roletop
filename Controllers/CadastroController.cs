using System;
using roletop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace roletop.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"]="Cadastro";
            try
            {
                Cliente cliente=new Cliente(form ["nome"],form["endereço"],form["telefone"],form["senha"],form["email"],DateTime.parse(form["data-nascimento"]));
                return View("sucesso");
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");

            }
                
        }
    }
}