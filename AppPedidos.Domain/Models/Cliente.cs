namespace AppPedidos.Domain.Models
{
	public class Cliente
	{
		private string _nome;
		private string _telefone;
		private string _cep;
		private string _estado;
		private string _cidade;

		public int Id { get; set; }
		public string Nome
		{
			get => string.IsNullOrEmpty(_nome) ? string.Empty : _nome;
			set => _nome = value;
		}
		public string Telefone
		{
			get => string.IsNullOrEmpty(_telefone) ? string.Empty : _telefone;
			set => _telefone = value;
		}
		public string CEP
		{
			get => string.IsNullOrEmpty(_cep) ? string.Empty : _cep;
			set => _cep = value;
		}
		public string Estado
		{
			get => string.IsNullOrEmpty(_estado) ? string.Empty : _estado;
			set => _estado = value;
		}
		public string Cidade
		{
			get => string.IsNullOrEmpty(_cidade) ? string.Empty : _cidade;
			set => _cidade = value;
		}
	}
}
