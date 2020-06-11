using PorjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace PorjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
