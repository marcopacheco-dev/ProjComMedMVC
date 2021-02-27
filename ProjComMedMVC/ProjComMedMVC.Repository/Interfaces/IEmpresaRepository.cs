using ProjComMedMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Repository.Interfaces
{
   public interface IEmpresaRepository
        : IBaseRepository<Empresa>
    {
        Empresa ObterPorCnpj(string Cnpj);
        List<Empresa> ObterPorRazaoSocial(string razaoSocial);
    }
}