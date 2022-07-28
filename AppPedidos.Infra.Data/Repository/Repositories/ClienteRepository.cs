using AppPedidos.Domain.Models;
using AppPedidos.Infra.Data.Context;
using AppPedidos.Infra.Data.Repository.Interfaces;

namespace AppPedidos.Infra.Data.Repository.Repositories
{
	public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
	{
		public ClienteRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
