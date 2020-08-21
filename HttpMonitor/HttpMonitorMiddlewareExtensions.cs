using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace HttpMonitor
{
    public static class HttpMonitorMiddlewareExtensions
    {
        public static HttpMonitorOptions AddHttpMonitor(this IServiceCollection services, Action<HttpMonitorOptions> setupAction)
        {
            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            var options = new HttpMonitorOptions();
            setupAction(options);
            foreach (var serviceExtension in options.Extensions)
            {
                serviceExtension.AddServices(services);
            }
            services.Configure(setupAction);

            return services.AddHttpMonitorService(options);
        }

        private static HttpMonitorOptions AddHttpMonitorService(this IServiceCollection services, HttpMonitorOptions options)
        {

            return options;
        }



        public static IApplicationBuilder UseHttpMonitor(this IApplicationBuilder app)
        {
            app.UseMiddleware<DefaultHttpMonitorMiddleware>();
            return app;
        }
    }
}
