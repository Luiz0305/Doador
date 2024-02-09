using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        private string stringconnection = "";
        string Conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(DoadorCommand command)
        {
            string queryInsert = @"insert into DoadorTabela ( NomeDoador, CidadeDoador, EstadoDoador, CEPDoador, EmailDoador, TelefoneDoador)
            values (@NomeDoador, @CidadeDoador, @EstadoDoador, @CEPDoador, @EmailDoador, @TelefoneDoador)";
            
            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                conn.Execute(queryInsert, new
                {
                    NomeDoador = command.NomeDoador,
                    CidadeDoador = command.CidadeDoador,
                    EstadoDoador = command.EstadoDoador,
                    CEPDoador = command.CEPDoador,
                    EmailDoador = command.EmailDoador,
                    TelefoneDoador = command.TelefoneDoador
                });
            }
            return "cadastro realizado com sucesso";
        }  
    }
}
