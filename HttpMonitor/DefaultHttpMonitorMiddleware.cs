using HttpMonitor.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMonitor
{
    public class DefaultHttpMonitorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDataStorage _dataStorage;
        private readonly IOptions<HttpMonitorOptions> _options;

        public DefaultHttpMonitorMiddleware(IOptions<HttpMonitorOptions> options, IDataStorage dataStorage, RequestDelegate next)
        {
            _options = options;
            _dataStorage = dataStorage;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await InvokeHttpAsync(context);
        }

        private async Task InvokeHttpAsync(HttpContext context)
        {
            await _next(context);
        }
    }
}
