using AppPedidos.Domain.Models;
using AppPedidos.Infra.Data.Context;
using AppPedidos.Infra.Data.Repository.Interfaces;

namespace AppPedidos.Infra.Data.Repository.Repositories
{
	public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
	{
		public PedidoRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
