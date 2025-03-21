using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Xpo;

namespace CPPMReportEntities.DomainObjects
{
    public class ЗадачаСмены : XPCustomObject
    {
        public ЗадачаСмены(Session сеанс) : base(сеанс) { }

        private Guid oid;
        private Изделие целевоеИзделие;
        private Изделие фактическоеИзделие;
        private DateTime времяНачала;
        private DateTime времяОкончания;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(OID), ref oid, value);
        }

        public Изделие ЦелевоеИзделие
        {
            get => целевоеИзделие;
            set => SetPropertyValue(nameof(ЦелевоеИзделие), ref целевоеИзделие, value);
        }

        public Изделие ФактическоеИзделие
        {
            get => фактическоеИзделие;
            set => SetPropertyValue(nameof(ФактическоеИзделие), ref фактическоеИзделие, value);
        }

        public DateTime ВремяНачала
        {
            get => времяНачала;
            set => SetPropertyValue(nameof(ВремяНачала), ref времяНачала, value);
        }

        public DateTime ВремяОкончания
        {
            get => времяОкончания;
            set => SetPropertyValue(nameof(ВремяОкончания), ref времяОкончания, value);
        }
    }

}
