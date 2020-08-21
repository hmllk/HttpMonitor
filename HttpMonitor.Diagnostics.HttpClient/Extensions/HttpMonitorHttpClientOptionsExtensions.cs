using System;
using System.Collections.Generic;
using System.Text;
using HttpMonitor;
using Microsoft.Extensions.DependencyInjection;

namespace HttpMonitor.Diagnostics.HttpClient
{
    public class HttpMonitorHttpClientOptionsExtensions : IHttpMonitorOptionsExtensions
    {
        public void AddServices(IServiceCollection services)
        {
            //services.AddSingleton<IRequestDiagnosticHandler, DefaultRequestDiagnosticHandler>();
        }
    }
}
