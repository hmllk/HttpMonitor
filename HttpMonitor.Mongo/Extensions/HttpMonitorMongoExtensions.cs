using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HttpMonitor.Mongo
{
    public static class HttpMonitorMongoExtensions
    {
        public static HttpMonitorOptions UseMongoDb(this HttpMonitorOptions options, string connectionString)
        {
            return options.UseMongoDb(x => { x.DatabaseConnection = connectionString; });
        }

        public static HttpMonitorOptions UseMongoDb(this HttpMonitorOptions options, Action<MongoDBOptions> setupoptions)
        {
            if (setupoptions == null) throw new ArgumentNullException(nameof(setupoptions));

            options.RegisterExtension(new HttpMonitorMongoOptionsExtensions(setupoptions));

            return options;
        }
    }
}
