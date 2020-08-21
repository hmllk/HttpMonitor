using System;
using System.Collections.Generic;
using System.Text;

namespace HttpMonitor.Model
{
    public class MonitorModel
    {
        public string Id { get; set; }

        public string ServiceName { get; set; }

        public string Host { get; set; }
        public string IP { get; set; }

        public string Method { get; set; }

        public string Url { get; set; }

        public string QueryString { get; set; }
        public int StatusCode { get; set; }
        public long Milliseconds { get; set; }

        public DateTime CreateTime { get; set; }

        public string LocalIP { get; set; }
        public int LocalPort { get; set; }
    }
}
