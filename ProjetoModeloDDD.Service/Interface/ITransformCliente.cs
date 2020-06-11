using PorjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Service.Interface
{
    public interface ITransformCliente
    {
        Cliente TransformClienteToViewModel(Cliente cliente);
        IEnumerable<Cliente> TransformClientesToViewModel(IEnumerable<Cliente> clientes);
    }
}
