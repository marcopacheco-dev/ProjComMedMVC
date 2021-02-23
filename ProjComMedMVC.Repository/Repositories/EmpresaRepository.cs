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
    public class EmpresaRepository : IEmpresaRepository
    {
        private string connectionstring;

        public void Inserir(Empresa obj)
        {
            var query = @"INSERT INTO EMPRESA(IDEMPRESA, RAZAOSOCIAL, CNPJ)
                          VALUES(@IDEMPRESA, @RAZAOSOCIAL, @CNPJ)";
            {
                using(var connection = new SqlConnection(connectionstring))
                {
                    connection.Execute(query, obj);
                }
            }
        }
        public void Alterar(Empresa obj)
        {
            var query = @"UPDATE EMPRESA SET RAZAOSOCIAL = @RAZAOSOCIAL
                        WHERE IDEMPRESA = @IDEMPRESA";
            {
                using(var connection = new SqlConnection(connectionstring))
                {
                    connection.Execute(query, obj);
                }
            }   
        }

        public void Excluir(Empresa obj)
        {
            var query = @"DELETE FROM EMPRESA WHERE EMPRESA = @IDEMPRESA";
            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Empresa> ObterTodos()
        {
            var query = @"SELECT * FROM EMPRESA ORDER BY RAZAOSOCIAL";

            using(var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query).ToList();
            }
        }

        public Empresa ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM EMPRESA WHERE IDEMPRESA = @ID";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query, new { id }).FirstOrDefault();
            }
        }
        public Empresa ObterPorCnpj(string Cnpj)
        {
            var query = @"SELECT * FROM EMPRESA WHERE IDEMPRESA = @CNPJ";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query, new { Cnpj }).FirstOrDefault();
            }
        }
    }
}
