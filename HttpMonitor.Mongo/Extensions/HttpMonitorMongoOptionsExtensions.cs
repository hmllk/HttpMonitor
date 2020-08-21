using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.Mongo
{
    public class HttpMonitorMongoOptionsExtensions : IHttpMonitorOptionsExtensions
    {
        private readonly Action<MongoDBOptions> _configure;

        public HttpMonitorMongoOptionsExtensions(Action<MongoDBOptions> configure)
        {
            _configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            services.Configure(_configure);
            services.AddSingleton<IDataStorage, MongoDBDataStorage>();
            services.TryAddSingleton<IMongoClient>(x =>
            {
                var options = x.GetService<IOptions<MongoDBOptions>>().Value;
                return new MongoClient(options.DatabaseConnection);
            });
        }
    }
}
