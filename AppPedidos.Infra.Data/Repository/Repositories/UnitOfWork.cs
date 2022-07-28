using AppPedidos.Infra.Data.Context;
using AppPedidos.Infra.Data.Repository.Interfaces;

namespace AppPedidos.Infra.Data.Repository.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		#region Fields
		private readonly ApplicationContext _context;
		private readonly IClienteRepository _cliente;
		private readonly IPedidoRepository _pedido;
		private readonly IProdutoRepository _produto;
		#endregion

		#region Properties
		public IClienteRepository Cliente { get { return _cliente; } }
		public IPedidoRepository Pedido { get { return _pedido; } }
		public IProdutoRepository Produto { get { return _produto; } }
		#endregion

		public UnitOfWork(ApplicationContext context)
		{
			_context = context;
			_cliente = new ClienteRepository(context);
			_pedido = new PedidoRepository(context);
			_produto = new ProdutoRepository(context);
		}

		public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}

		public int Save()
		{
			return _context.SaveChanges();
		}
	}
}
