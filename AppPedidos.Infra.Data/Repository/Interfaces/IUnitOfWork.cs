namespace AppPedidos.Infra.Data.Repository.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IClienteRepository Cliente { get; }
		IPedidoRepository Pedido { get; }
		IProdutoRepository Produto { get; }
		int Save();
	}
}
