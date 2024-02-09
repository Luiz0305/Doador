using Doador.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Commands
{
    public class ProdutoCommand
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescriçãoProduto { get; set; }
        public ECategoriaProduto ECategoriaProduto { get; set; }
        public bool DisponibilidadeProduto { get; set; }
    }
}
