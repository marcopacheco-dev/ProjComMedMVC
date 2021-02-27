using System;
using System.Collections.Generic;
using System.Text;

namespace ProjComMedMVC.Repository.Interfaces
{
   public interface IBaseRepository<T>
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
        List<T> ObterTodos();
        T ObterPorId(Guid id);

    }
}
