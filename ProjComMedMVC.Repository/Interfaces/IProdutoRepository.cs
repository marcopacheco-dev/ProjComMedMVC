using ProjComMedMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Repository.Interfaces
{
   public interface IProdutoRepository
        : IBaseRepository<Produto>
    {
        Produto ObterPorNome(string Nome);

    }
}
