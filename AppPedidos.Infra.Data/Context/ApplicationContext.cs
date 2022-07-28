using AppPedidos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPedidos.Infra.Data.Context
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Cliente> Clientes { get; set; }

		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
			MapearPropriedadesNaoConfiguradas(modelBuilder);
		}

		private void MapearPropriedadesNaoConfiguradas(ModelBuilder modelBuilder)
		{
			foreach (var entity in modelBuilder.Model.GetEntityTypes())
			{
				var properties = entity.GetProperties().Where(p => p.ClrType == typeof(string));

				foreach (var property in properties)
				{
					if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue)
					{
						//property.SetMaxLength(100);
						property.SetColumnType("VARCHAR(100)");
					}
				}
			}
		}
	}
}
