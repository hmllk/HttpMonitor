using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.ElasticSearch
{
    public class ElasticSearchOptions
    {
        public string ElasticSerachConnection { get; set; } = "http://localhost:9200";
        public string DefaultIndex { get; set; } = "httpmonitor";
    }
}
