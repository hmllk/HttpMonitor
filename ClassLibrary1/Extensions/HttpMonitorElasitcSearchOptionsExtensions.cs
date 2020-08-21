using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.ElasticSearch
{
    public class HttpMonitorElasitcSearchOptionsExtensions : IHttpMonitorOptionsExtensions
    {
        private readonly Action<ElasticSearchOptions> _configure;

        public HttpMonitorElasitcSearchOptionsExtensions(Action<ElasticSearchOptions> configure)
        {
            _configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            services.Configure(_configure);
            services.AddSingleton<IDataStorage, ElasticSearchDataStorage>();
            services.TryAddSingleton<IElasticClient>(x =>
            {
                var options = x.GetService<IOptions<ElasticSearchOptions>>().Value;
                var uri = new Uri(options.ElasticSerachConnection);
                var setting = new ConnectionSettings(uri);
                setting.DefaultIndex(options.DefaultIndex);
                return new ElasticClient(setting);
            });
        }
    }
}
