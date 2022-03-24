using SearchProductList.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SearchProductList.Tool
{
    public class Service
    {
        private readonly IMongoCollection<MongoModel> mongoCollection;
        public Service(
            IOptions<DatabaseSettingsModel> settings)
        {
            var mongoClient = new MongoClient(settings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(settings.Value.DatabaseName);
            mongoCollection = mongoDatabase.GetCollection<MongoModel>(settings.Value.CollectionName);
        }

        public async Task CreateAsync(MongoModel _model) =>
            await mongoCollection.InsertOneAsync(_model);
    }
}
