using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.Diagnostics.HttpClient
{
   public class HttpClientTracingDiagnosticProcessor: ITracingDiagnosticProcessor
    {
        public string ListenerName { get; } = "HttpHandlerDiagnosticListener";

        public HttpClientTracingDiagnosticProcessor()
        { 
        
        }
    }
}
