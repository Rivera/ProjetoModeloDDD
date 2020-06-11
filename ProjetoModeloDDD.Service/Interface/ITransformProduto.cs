using PorjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Service.Interface
{
    public interface ITransformProduto
    {
        Produto TransformProdutoToViewModel(Produto produto);
        IEnumerable<Produto> TransformProdutosToViewModel(IEnumerable<Produto> produto);
    }
}
