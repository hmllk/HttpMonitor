using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.Mongo
{
    public class MongoDBOptions
    {
        public string DatabaseName { get; set; } = "httpmonitor";

        public string DatabaseConnection { get; set; } = "mongodb://localhost:27017";

        public string DefaultCollection { get; set; } = "httpmonitor";
    }
}
