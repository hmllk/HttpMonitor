using HttpMonitor.Model;
using Microsoft.Extensions.Options;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HttpMonitor.ElasticSearch
{
    public class ElasticSearchDataStorage : IDataStorage
    {
        private readonly IElasticClient _elasticClient;
        private readonly IOptions<ElasticSearchOptions> _options;

        public ElasticSearchDataStorage(IOptions<ElasticSearchOptions> options, IElasticClient elasticClient)
        {
            _options = options;
            _elasticClient = elasticClient;
        }

        public async Task<MonitorModel> InsertMessage(MonitorModel monitorModel)
        {
            var result =await _elasticClient.IndexDocumentAsync<MonitorModel>(monitorModel);
            return monitorModel;
        }
    }
}
