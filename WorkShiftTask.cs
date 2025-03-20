using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPMReportEntities.DomainObjects
{
    class WorkShiftTask
    {
        public Guid Id { get; set; }
        public Product PurposeProduct { get; set; }
        public Product FactProduct { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
