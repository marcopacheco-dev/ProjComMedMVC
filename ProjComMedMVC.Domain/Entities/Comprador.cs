using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Domain.Entities
{
   public class Comprador
    {
        #region Propriedades

        public Guid IdComprador { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }

        #endregion

        #region Relacionamentos
        List<Empresa> empresas { get; set; }
        List<Produto> produtos { get; set; }

        #endregion
    }
}