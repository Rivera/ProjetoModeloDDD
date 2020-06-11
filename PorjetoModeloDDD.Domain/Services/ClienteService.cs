using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Interfaces.Repositories;
using PorjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace PorjetoModeloDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;   
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
