using AppPedidos.Domain.Models;
using AppPedidos.Infra.Data.Repository.Interfaces;
using AppPedidos.Service.Interfaces;

namespace AppPedidos.Service.Services
{
	public class ClienteService : IClienteService
	{
		private readonly IUnitOfWork _context;

		public ClienteService(IUnitOfWork context)
		{
			_context = context;
		}

		public Cliente GetById(int id) => _context.Cliente.GetById(id);

		public IEnumerable<Cliente> GetAll() => _context.Cliente.GetAll();

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
