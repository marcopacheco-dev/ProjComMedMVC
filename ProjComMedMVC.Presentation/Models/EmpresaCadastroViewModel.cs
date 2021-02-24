using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjComMedMVC.Presentation.Models
{
    public class EmpresaCadastroViewModel
    {
        
        [MinLength(6, ErrorMessage ="Por favor, informe no mínimo {1} caracteres")]

        [MaxLength(150, ErrorMessage ="Por favor, informe no máximo {1} caracteres")]
        
        [Required(ErrorMessage = "Por favor, informe a razão social da empresa.")]
        public string RazaoSocial { get; set; }
        
        [RegularExpression("^[0-9]{14}$", ErrorMessage = "Por favor, " +
            "informe 14 digitos numéricos.")]
                           
        [Required(ErrorMessage = "Por favor, informe o cnpj da empresa.")]
        public string Cnpj { get; set; }
    }
}
