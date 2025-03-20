using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPPMReportEntities.Interface;

namespace CPPMReportEntities.DomainObjects
{
    class Product
    {
        public Guid Id { get; set; }
        public ProductType ProductType { get; set; }
        public ProductSubType? ProductSubType { get; set; }
        public double ProducedQuantity { get; set; } = 0;
        public IMeasureUnit ProducedQuantityUnits { get; set; }
    }
}
