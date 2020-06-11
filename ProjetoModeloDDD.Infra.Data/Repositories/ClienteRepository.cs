using PorjetoModeloDDD.Domain.Entities;
using PorjetoModeloDDD.Domain.Interfaces;
using PorjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
