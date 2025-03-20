using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPPMReportEntities.Interface;

namespace CPPMReportEntities.DomainObjects
{
    /// <summary>
    /// Справочник по стандартам мешков 
    /// </summary>
    class BagStandart
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        /// <summary>
        /// Вес мешка
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Единицы измерения веса
        /// </summary>
        public IMeasureUnit WeightUnits { get; set; }
        /// <summary>
        /// Ширина мешка 
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Единицы измерения ширины
        /// </summary>
        public IMeasureUnit WidthUnits { get; set; }
        /// <summary>
        /// Длинна мешка 
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// Единицы измерения длинны
        /// </summary>
        public IMeasureUnit LengthUnits { get; set; }
    }
}
