using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



using DevExpress.Xpo;

namespace CPPMReportEntities.DomainObjects
{
    public class Изделие : XPObject
    {
        public Изделие(Session сеанс) : base(сеанс) { }

        private ТипИзделия типИзделия;
        private double выпущенноеКоличество = 0;
        private ЕдиницаИзмерения единицыИзмеренияВыпущенногоКоличество;
        private Guid oid;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(OID), ref oid, value);
        }
        public ТипИзделия ТипИзделия
        {
            get => типИзделия;
            set => SetPropertyValue(nameof(ТипИзделия), ref типИзделия, value);
        }

        public double ВыпущенноеКоличество
        {
            get => выпущенноеКоличество;
            set => SetPropertyValue(nameof(ВыпущенноеКоличество), ref выпущенноеКоличество, value);
        }

        public ЕдиницаИзмерения ЕдиницыИзмеренияВыпущенногоКоличество
        {
            get => единицыИзмеренияВыпущенногоКоличество;
            set => SetPropertyValue(nameof(ЕдиницыИзмеренияВыпущенногоКоличество), ref единицыИзмеренияВыпущенногоКоличество, value);
        }
    }


}
