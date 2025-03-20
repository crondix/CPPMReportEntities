using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPMReportEntities
{
    class EquipmentStatus
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsWork { get; set; }
        public DowntimeReason? DowntimeReason { get; set; }

    }
}
