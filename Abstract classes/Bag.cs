using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPPMReportEntities.Interface;

namespace CPPMReportEntities.DomainObjects
{
  public abstract class Bag
    {
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
