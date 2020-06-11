using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Application.Interface;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarProdutoPorNome(nome);
        }
    }
}
