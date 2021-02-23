using ProjComMedMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Repository.Interfaces
{
   public interface ICompradorRepository
        : IBaseRepository<Comprador>
    {
        Comprador ObterPorCpf(string Cpf);
        
    }
}
