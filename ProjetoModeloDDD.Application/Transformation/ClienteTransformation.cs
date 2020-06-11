using PorjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Transformation
{
    public class ClienteTransformation
    {
        public ClienteModel TransformarClienteEmClienteModel(Cliente cliente)
        {
        var clienteModel = new ClienteModel();
            clienteModel.ClienteId = cliente.ClienteId;
            clienteModel.Nome = cliente.Nome;
            clienteModel.Sobrenome = cliente.Sobrenome;
            clienteModel.Email = cliente.Email;
            clienteModel.DataCadastro = cliente.DataCadastro;
            clienteModel.Ativo = cliente.Ativo;
            clienteModel.Produtos = new ProdutoTransformation().TransformarProdutoEmProdutoModel(cliente.Produtos);

            return clienteModel;
        }

        public IEnumerable<ClienteModel> TransformarClienteEmClienteModel(IEnumerable<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                yield return TransformarClienteEmClienteModel(cliente);
            }
        }

        public Cliente TransformarClienteModelEmCliente(ClienteModel clienteModel)
        {
            var cliente = new Cliente();
            cliente.ClienteId = clienteModel.ClienteId;
            cliente.Nome = clienteModel.Nome;
            cliente.Sobrenome = clienteModel.Sobrenome;
            cliente.Email = clienteModel.Email;
            cliente.DataCadastro = clienteModel.DataCadastro;
            cliente.Ativo = clienteModel.Ativo;
            cliente.Produtos = new ProdutoTransformation().TransformarProdutoModelEmProduto(clienteModel.Produtos);
            return cliente;
        }

        public IEnumerable<Cliente> TransformarClienteModelEmCliente(IEnumerable<ClienteModel> clientesModel)
        {
            foreach (var clienteModel in clientesModel)
            {
                yield return TransformarClienteModelEmCliente(clienteModel);
            }
        }
    }
}
