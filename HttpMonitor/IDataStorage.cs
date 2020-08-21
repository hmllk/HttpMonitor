using HttpMonitor.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HttpMonitor
{
    public interface IDataStorage
    {
        Task<MonitorModel> InsertMessage(MonitorModel monitorModel);
    }
}
