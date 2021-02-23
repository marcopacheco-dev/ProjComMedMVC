using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Domain.Entities
{
   public class Produto
    {
        #region Propriedades
        public Guid IdProduto { get; set; }
        public string Nome  { get; set; }
        public string Quantidade { get; set; }
        public string Preco { get; set; }
        public Guid IdComprador { get; set; }
        public Guid IdEmpresa { get; set; }

        #endregion

        #region Relacionamentos
        Empresa empresa { get; set; }
        Comprador comprador { get; set; }

        #endregion
    }
}
