using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository: IProdutoRepository
    {
        private string stringconnection = "";
        string Conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryInsert = @"insert into Produto (NomeProduto, DescriçãoProduto, ECategoriaProduto, DisponibilidadeProduto)
            values (@NomeProduto, @DescriçãoProduto, @ECategoriaProduto, @DisponibilidadeProduto)";
            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                conn.Execute(queryInsert, new
                {
                    NomeProduto = command.NomeProduto,
                    DescriçãoProduto = command.DescriçãoProduto,
                    ECategoriaProduto = command.ECategoriaProduto,
                    DisponibilidadeProduto = command.DisponibilidadeProduto
                });
            }
            return "Cadastro feito com sucesso";
        }
    }
}
