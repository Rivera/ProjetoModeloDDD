using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace PorjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarProdutoPorNome(string nome);
    }
}
