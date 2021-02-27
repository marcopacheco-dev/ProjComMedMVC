using Dapper;
using ProjComMedMVC.Domain.Entities;
using ProjComMedMVC.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjComMedMVC.Repository.Repositories
{
   public class CompradorRepository : ICompradorRepository
    {
        private string connectionstring;

        public CompradorRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Inserir(Comprador obj)
        {
            var query = @"INSERT INTO COMPRADOR (IDCOMPRADOR, NOME, CPF, CONTATO, EMAIL)
                            VALUES(@IDCOMPRADOR, @NOME, @CPF, @CONTATO, @EMAIL)";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
        public void Alterar(Comprador obj)
        {
            var query = @"UPDATE COMPRADOR SET NOME = @NOME, CPF = @CPF,
                        CONTATO = @CONTATO, EMAIL = @EMAIL";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Comprador obj)
        {
            var query = @"DELETE FROM COMPRADOR WHERE IDCOMPRADOR = @IDCOMPRADOR";

            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
        public List<Comprador> ObterTodos()
        {
            var query = @"SELECT * FROM COMPRADOR ORDER BY NOME";

            using(var connection = new SqlConnection(connectionstring))
            {
              return connection.Query<Comprador>(query).ToList();
            }
                    
        }

        public Comprador ObterPorCpf(string Cpf)
        {
            var query = @"SELECT  * FROM COMPRADOR WHERE CPF = @CPF";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Comprador>(query, new { Cpf }).FirstOrDefault();
            }
        }

        public Comprador ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM COMPRADOR WHERE IDCOMPRADOR = @ID";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Comprador>(query, new { id }).FirstOrDefault();
            }
        }
    }
}
