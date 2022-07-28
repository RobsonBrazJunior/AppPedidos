using AppPedidos.Domain.Models;
using AppPedidos.Infra.Data.Context;
using AppPedidos.Infra.Data.Repository.Interfaces;

namespace AppPedidos.Infra.Data.Repository.Repositories
{
	public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
	{
		public ProdutoRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
