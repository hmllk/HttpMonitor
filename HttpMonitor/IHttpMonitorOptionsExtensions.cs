using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor
{
    public interface IHttpMonitorOptionsExtensions
    {
        void AddServices(IServiceCollection services);
    }
}
