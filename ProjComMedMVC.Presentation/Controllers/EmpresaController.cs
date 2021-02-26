using Microsoft.AspNetCore.Mvc;
using ProjComMedMVC.Domain.Entities;
using ProjComMedMVC.Presentation.Models;
using ProjComMedMVC.Repository.Repositories;
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
        public IActionResult Cadastro(EmpresaCadastroViewModel model,
            [FromServices] EmpresaRepository empresaRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    if (empresaRepository.ObterPorCnpj(model.Cnpj) != null)
                    {
                        throw new Exception("O CNPJ informando " +
                                            "já encontra-se cadastrado. ");
                    }

                    var empresa = new Empresa();

                    empresa.IdEmpresa = Guid.NewGuid();
                    empresa.RazaoSocial = model.RazaoSocial;
                    empresa.Cnpj = model.Cnpj;

                    empresaRepository.Inserir(empresa);

                    
                        TempData["MensagemSucesso"]
                            = $"Empresa {empresa.RazaoSocial}, cadastrado com sucesso!";
                    ModelState.Clear();
                        
                    
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
                }
            }
            return View();
        }
        
        

        public IActionResult Consulta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Consulta(EmpresaConsultaViewModel model,
             [FromServices] EmpresaRepository empresaRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if(empresaRepository.ObterPorCnpj(model.Cnpj) != null)
                    {
                        throw new Exception("O CNPJ informado" +
                            "               já encontra-se cadastrado.");
                    }
                    var empresa = new Empresa();

                    empresa.IdEmpresa = Guid.NewGuid();
                    empresa.RazaoSocial = model.RazaoSocial;
                    empresa.Cnpj = model.Cnpj;

                    empresaRepository.Inserir(empresa);

                    TempData["MensagemSucesso"] = $"Empresa" +
                        $"  {empresa.RazaoSocial}, cadastro com sucesso.";
                    ModelState.Clear();
                }catch(Exception e)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;

                }
            }

                if (ModelState.IsValid)
                {
                    try
                    {
                        if(model.Empresas.Count == 0)
                        {
                            TempData["MensagemAlerta"] = "Nenhuma empresa foi encontrada.";
                        }
                            
                    }
                    catch(Exception e)
                    {
                        TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
                    }
                }

            return View(model);
        }

        public IActionResult Edicao()
        {
            return View();
        }

    }
}
