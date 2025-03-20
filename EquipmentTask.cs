using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPPMReportEntities.DomainObjects;
using CPPMReportEntities.Interface;

namespace CPPMReportEntities
{
    class EquipmentTask
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Product PurposeProduct { get; set; }
        public Product FactProduct { get; set; }
        public IMeasureUnit ProductUnits { get; set; }
        public EquipmentDowntimeReason? DowntimeReason { get; set; }
    }
}
