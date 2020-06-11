using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Application.Interface;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspecias()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
