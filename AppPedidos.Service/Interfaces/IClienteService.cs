﻿using AppPedidos.Domain.Models;

namespace AppPedidos.Service.Interfaces
{
	public interface IClienteService : IDisposable
	{
		Cliente GetById(int id);
		IEnumerable<Cliente> GetAll();
	}
}
