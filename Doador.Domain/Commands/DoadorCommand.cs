using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public int IdDoador { get; set; }
        public string NomeDoador { get; set; }
        public string CidadeDoador {  get; set; }
        public string EstadoDoador { get; set; }
        public int CEPDoador { get; set; }
        public string EmailDoador { get; set; }
        public int TelefoneDoador { get; set; }
    }
}
