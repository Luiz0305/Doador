using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public async Task<String> PostAsync(ProdutoCommand command)
        {
            if (command == null)
                return "Todos os campos tem que ser preenchidos";

                return await _repository.PostAsync(command);
        }

        public Task<string> PostAsync(DoadorCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
