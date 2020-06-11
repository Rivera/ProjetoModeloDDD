using PorjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Application.Model;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Transformation
{
    public class ProdutoTransformation
    {
        public ProdutoModel TransformarProdutoEmProdutoModel(Produto produto)
        {
            var produtoModel = new ProdutoModel();
            produtoModel.ProdutoId = produto.ProdutoId;
            produtoModel.Nome = produto.Nome;
            produtoModel.Valor = produto.Valor;
            produtoModel.Disponivel = produto.Disponivel ? "Sim" : "Não";
            produtoModel.ClienteId = produto.ClienteId;
            return produtoModel;
        }

        public IEnumerable<ProdutoModel> TransformarProdutoEmProdutoModel(IEnumerable<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                yield return TransformarProdutoEmProdutoModel(produto);
            }
        }

        public Produto TransformarProdutoModelEmProduto(ProdutoModel produtoModel)
        {
            var produto = new Produto();
            produto.ProdutoId = produtoModel.ProdutoId;
            produto.Nome = produtoModel.Nome;
            produto.Valor = produtoModel.Valor;
            produto.Disponivel = produtoModel.Disponivel == "Sim" ? true : false;
            produto.ClienteId = produtoModel.ClienteId;
            return produto;
        }

        public IEnumerable<Produto> TransformarProdutoModelEmProduto(IEnumerable<ProdutoModel> produtosModel)
        {
            foreach (var produtoModel in produtosModel)
            {
                yield return TransformarProdutoModelEmProduto(produtoModel);
            }
        }
    }
}
