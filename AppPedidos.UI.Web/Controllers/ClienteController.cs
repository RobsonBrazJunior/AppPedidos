using AppPedidos.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidos.UI.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClienteController : ControllerBase
	{
		private readonly IClienteService _clienteService;

		public ClienteController(IClienteService clienteService)
		{
			_clienteService = clienteService;
		}

		[HttpGet("GetAll")]
		public IActionResult GetAll()
		{
			var result = _clienteService.GetAll();
			return result == null ? NotFound() : new JsonResult(new { result });
		}

		[HttpGet("Get/{id:int}")]
		public IActionResult Get(int id)
		{
			if (id == 0)
				return NotFound();

			var result = _clienteService.GetById(id);

			if (result == null)
				return NotFound();

			return new JsonResult(new { result });
		}
	}
}
