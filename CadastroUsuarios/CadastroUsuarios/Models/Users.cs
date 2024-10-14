using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CadastroUsuarios.Models
{
	public class Users
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; } = String.Empty;
		public string Nome { get; set; } = String.Empty;
		public string Email { get; set; } = String.Empty;
		public string Telefone { get; set; } = String.Empty;
	}
}
