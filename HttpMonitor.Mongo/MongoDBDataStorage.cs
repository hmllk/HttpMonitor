using HttpMonitor.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HttpMonitor.Mongo
{
    public class MongoDBDataStorage : IDataStorage
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IOptions<MongoDBOptions> _mongoOptions;

        public MongoDBDataStorage(IOptions<MongoDBOptions> mongoOptions, IMongoClient client)
        {
            _mongoOptions = mongoOptions;
            _client = client;
            _database = _client.GetDatabase(_mongoOptions.Value.DatabaseName);
        }

        public async Task<MonitorModel> InsertMessage(MonitorModel monitorModel)
        {
            var collection = _database.GetCollection<MonitorModel>(_mongoOptions.Value.DefaultCollection);
            await collection.InsertOneAsync(monitorModel);
            return monitorModel;
        }
    }
}
