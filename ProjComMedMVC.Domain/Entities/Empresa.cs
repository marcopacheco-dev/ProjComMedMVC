using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Domain.Entities
{
   public class Empresa
    {
        #region Propriedades
        public Guid IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }

        #endregion

        #region Relacionamentos

        List<Comprador> compradores { get; set; }
        List<Produto> produtos { get; set; }

        #endregion
    }
}
