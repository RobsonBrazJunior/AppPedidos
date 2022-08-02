using AppPedidos.Domain.Models;
using AppPedidos.Service.Interfaces;
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

		[HttpPost("Add")]
		public IActionResult Add([FromBody] Cliente cliente)
		{
			if (!ModelState.IsValid)
				return BadRequest(cliente);

			_clienteService.Add(cliente);

			return Ok();
		}

		[HttpPut("Update")]
		public IActionResult Update([FromBody] Cliente cliente)
		{
			if (!ModelState.IsValid)
				return BadRequest(cliente);

			_clienteService.Update(cliente);

			return Ok();
		}

		[HttpDelete("Remove")]
		public IActionResult Remove([FromBody] Cliente cliente)
		{
			if (!ModelState.IsValid)
				return BadRequest(cliente);

			_clienteService.Remove(cliente);

			return Ok();
		}
	}
}
