using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor
{
    public interface ITracingDiagnosticProcessor
    {
        string ListenerName { get; }
    }
}
