using Microsoft.AspNetCore.Mvc;
using ProjComMedMVC.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjComMedMVC.Presentation.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(EmpresaCadastroViewModel model)
        {
            TempData["MensagemSucesso"]
                = "Empresa cadastrado com sucesso";
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
