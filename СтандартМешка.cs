using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DevExpress.Xpo;

namespace CPPMReportEntities.DomainObjects
{
    /// <summary>
    /// Справочник по стандартам мешков 
    /// </summary>
    public class СтандартМешка : XPObject
    {
        public СтандартМешка(Session session) : base(session) { }

        private string название;
        private string? короткоеНазвание;
        private string? описание;
        private double вес;
        private ЕдиницаИзмерения единицыИзмеренияВеса;
        private double ширина;
        private ЕдиницаИзмерения единицыИзмеренияШирины;
        private double длина;
        private ЕдиницаИзмерения единицыИзмеренияДлины;
        private Guid oid;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(OID), ref oid, value);
        }
        [Size(255)]
        public string Название
        {
            get => название;
            set => SetPropertyValue(nameof(Название), ref название, value);
        }

        [Size(100)]
        public string? КороткоеНазвание
        {
            get => короткоеНазвание;
            set => SetPropertyValue(nameof(КороткоеНазвание), ref короткоеНазвание, value);
        }

        [Size(1024)]
        public string? Описание
        {
            get => описание;
            set => SetPropertyValue(nameof(Описание), ref описание, value);
        }

        /// <summary>
        /// Вес мешка
        /// </summary>
        public double Вес
        {
            get => вес;
            set => SetPropertyValue(nameof(Вес), ref вес, value);
        }

        /// <summary>
        /// Единицы измерения веса
        /// </summary>
        public ЕдиницаИзмерения ЕдиницыИзмеренияВеса
        {
            get => единицыИзмеренияВеса;
            set => SetPropertyValue(nameof(ЕдиницыИзмеренияВеса), ref единицыИзмеренияВеса, value);
        }

        /// <summary>
        /// Ширина мешка
        /// </summary>
        public double Ширина
        {
            get => ширина;
            set => SetPropertyValue(nameof(Ширина), ref ширина, value);
        }

        /// <summary>
        /// Единицы измерения ширины
        /// </summary>
        public ЕдиницаИзмерения ЕдиницыИзмеренияШирины
        {
            get => единицыИзмеренияШирины;
            set => SetPropertyValue(nameof(ЕдиницыИзмеренияШирины), ref единицыИзмеренияШирины, value);
        }

        /// <summary>
        /// Длина мешка
        /// </summary>
        public double Длина
        {
            get => длина;
            set => SetPropertyValue(nameof(Длина), ref длина, value);
        }

        /// <summary>
        /// Единицы измерения длины
        /// </summary>
        public ЕдиницаИзмерения ЕдиницыИзмеренияДлины
        {
            get => единицыИзмеренияДлины;
            set => SetPropertyValue(nameof(ЕдиницыИзмеренияДлины), ref единицыИзмеренияДлины, value);
        }
    }

}
