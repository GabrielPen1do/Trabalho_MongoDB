namespace CadastroUsuarios.Models
{
	public class RegisterDatabaseSettings
	{
		public string ConnectionString { get; set; } = null!;

		public string DatabaseName { get; set; } = null!;

		public string RegisterCollectionName { get; set; } = null!;
	}
}
