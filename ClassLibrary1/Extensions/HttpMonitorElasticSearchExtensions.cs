using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.ElasticSearch
{
    public static class HttpMonitorElasticSearchExtensions
    {
        public static HttpMonitorOptions UseElastic(this HttpMonitorOptions options, string connectionString)
        {
            return options.UseElastic(x => { x.ElasticSerachConnection = connectionString; });
        }

        public static HttpMonitorOptions UseElastic(this HttpMonitorOptions options, Action<ElasticSearchOptions> setupoptions)
        {
            if (setupoptions == null) throw new ArgumentNullException(nameof(setupoptions));
            options.RegisterExtension(new HttpMonitorElasitcSearchOptionsExtensions(setupoptions));
            return options;
        }
    }
}
