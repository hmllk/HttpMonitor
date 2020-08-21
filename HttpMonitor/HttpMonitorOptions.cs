using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor
{
    public class HttpMonitorOptions 
    {
        public HttpMonitorOptions()
        {
            Extensions= new List<IHttpMonitorOptionsExtensions>();
        }

        public string ServiceName { get; set; } = "default";

        internal IList<IHttpMonitorOptionsExtensions> Extensions { get; }

        public void RegisterExtension(IHttpMonitorOptionsExtensions extension)
        {
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            Extensions.Add(extension);
        }
    }
}
