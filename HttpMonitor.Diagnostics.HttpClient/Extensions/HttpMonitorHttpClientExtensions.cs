using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.Diagnostics.HttpClient
{
    public static class HttpMonitorHttpClientExtensions
    {
        public static HttpMonitorOptions AddHttpClient(this HttpMonitorOptions options)
        {
            options.RegisterExtension(new HttpMonitorHttpClientOptionsExtensions());
            return options;
        }
    }
}
