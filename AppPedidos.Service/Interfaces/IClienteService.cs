using AppPedidos.Domain.Models;

namespace AppPedidos.Service.Interfaces
{
	public interface IClienteService : IDisposable
	{
		IEnumerable<Cliente> GetAll();
	}
}
