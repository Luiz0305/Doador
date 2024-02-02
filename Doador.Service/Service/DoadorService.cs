using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Service.Service
{
    public class DoadorService
    {
        private readonly IDoadorRepository  _repository;
        public DoadorService(IDoadorRepository repository)
        {
            _repository = repository;
        }
        public async Task<String> PostAsync(DoadorCommand command)
        {
            if (command == null)
                return "Todos os campos tem que ser preenchidos";
            return await _repository.PostAsync(command);
        }
    }
}
