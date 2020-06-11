using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Interfaces.Repositories;
using PorjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PorjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarProdutoPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
