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
   public class ProdutoRepository : IProdutoRepository
    {
        private string connectionstring;

        public ProdutoRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Inserir(Produto obj)
        {
            var query = @"INSERT INTO PRODUTO(IDPRODUTO, NOME, QUANTIDADE, PRECO)
                                    VALUES(@IDPRODUTO, @NOME, @QUANTIDADE, @PRECO)";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Produto obj)
        {
            var query = @"UPDATE PRODUTO SET NOME = @NOME, 
                   QUANTIDADE = @QUANTIDADE, PRECO = @PRECO";

            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Produto obj)
        {
            var query = @"DELETE FROM PRODUTO
                        WHERE IDPRODUTO = @IDPRODUTO";

            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
        public List<Produto> ObterTodos()
        {
            var query = @"SELECT * FROM PRODUTO ORDER BY NOME";

            using(var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Produto>(query).ToList();
            }
        }
        public Produto ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM PRODUTO WHERE IDPRODUTO = @ID";

            using(var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Produto>(query, new { id }).FirstOrDefault();
            }
        }

        public Produto ObterPorNome(string Nome)
        {
            var query = @"SELECT * FROM PRODUTO WHERE ORDER BY NOME = @NOME";

            using(var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Produto>(query, new { Nome }).FirstOrDefault();
            }
        }
    }
}