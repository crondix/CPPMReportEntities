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
        public double PurposeProduct { get; set; }
        public double FactProduct { get; set; }
        public IMeasureUnit ProductUnits { get; set; }
    }
}
