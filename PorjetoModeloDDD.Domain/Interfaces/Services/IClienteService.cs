using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace PorjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
