using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        private string stringconnection = "";
        string Conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(DoadorCommand command)
        {
            string queryInsert = @"DoadorTabela ( NomeDoador, CidadeDoador, EstadoDoador, CEPDoador, EmailDoador, TelefoneDoador)
            values ('@NomeDoador', '@CidadeDoador', '@EstadoDoador', '@CEPDoador', '@EmailDoador', '@TelefoneDoador')";
            
            using (SqlConnection conn = new SqlConnection(stringconnection))
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
        public void PostAsync()
        {

        }
        
    }
}
