using ProjComMedMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjComMedMVC.Presentation.Models
{
    public class EmpresaConsultaViewModel
    {
        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo" +
                                     "  {1}caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a razão social desejada.")]
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public List<Empresa> Empresas { get; set; }

    }
}
