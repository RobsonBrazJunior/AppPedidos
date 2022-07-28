using AppPedidos.Domain.ValueObjects;

namespace AppPedidos.Domain.Models
{
	public class Produto
	{
		private string _codigoBarras;
		private string _descricao;

		public int Id { get; set; }
		public string CodigoBarras
		{
			get => string.IsNullOrEmpty(_codigoBarras) ? string.Empty : _codigoBarras;
			set => _codigoBarras = value;
		}
		public string Descricao
		{
			get => string.IsNullOrEmpty(_descricao) ? string.Empty : _descricao;
			set => _descricao = value;
		}
		public decimal Valor { get; set; }
		public TipoProduto TipoProduto { get; set; }
		public bool Ativo { get; set; }
	}
}
