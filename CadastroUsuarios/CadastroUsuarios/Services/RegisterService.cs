using CadastroUsuarios.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CadastroUsuarios.Services
{
	public class RegisterService
	{
		private readonly IMongoCollection<Users> _userCollection;

		public RegisterService(
		   IOptions<RegisterDatabaseSettings> registerDatabaseSettings)
		{
			var mongoClient = new MongoClient(
				registerDatabaseSettings.Value.ConnectionString);

			var mongoDatabase = mongoClient.GetDatabase(
				registerDatabaseSettings.Value.DatabaseName);

			_userCollection = mongoDatabase.GetCollection<Users>(
				registerDatabaseSettings.Value.RegisterCollectionName);
		}

		public async Task<int> GetTotalUsersCountAsync()
		{
			return (int)await _userCollection.CountDocumentsAsync(new BsonDocument());
		}

		public async Task<long> CountTotalUsersAsync() =>
		await _userCollection.CountDocumentsAsync(_ => true);

		public async Task CreateAsync(Users user) =>

			await _userCollection.InsertOneAsync(user);

		public async Task<List<Users>> GetAsync() =>
		 await _userCollection.Find(_ => true).ToListAsync();


		public async Task<Users?> GetAsync(string id) =>

		 await _userCollection.Find(x => x.Id == id).FirstOrDefaultAsync();


		public async Task RemoveAsync(string id) =>

		   await _userCollection.DeleteOneAsync(x => x.Id == id);


		public async Task UpdateAsync(string id, Users user)
		{
			await _userCollection.ReplaceOneAsync(x => x.Id == id, user);
		}

	}
}
