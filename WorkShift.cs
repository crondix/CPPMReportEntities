using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPMReportEntities.DomainObjects
{
    class WorkShift
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<WorkShift>? WorkShiftsTask { get; set; }

    }
}
