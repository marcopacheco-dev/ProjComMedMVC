using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjComMedMVC.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Consulta()
        {
            return View();
        }
        public IActionResult Edicao()
        {
            return View();
        }
    }
}
