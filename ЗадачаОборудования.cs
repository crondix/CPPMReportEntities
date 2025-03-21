using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPPMReportEntities.DomainObjects;


using DevExpress.Xpo;

namespace CPPMReportEntities
{
    public class ЗадачаОборудования : XPObject
    {
        public ЗадачаОборудования(Session сеанс) : base(сеанс) { }

        private DateTime времяНачала;
        private DateTime времяОкончания;
        private Изделие целевоеИзделие;
        private Изделие фактическоеИзделие;
        private bool естьПростой;
        private Guid oid;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(OID), ref oid, value);
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

        public bool ЕстьПростой
        {
            get => естьПростой;
            set => SetPropertyValue(nameof(ЕстьПростой), ref естьПростой, value);
        }

        [Association("ЗадачаОборудования-ПростоиОборудования")]
        public XPCollection<ПростойОборудования> Простои => GetCollection<ПростойОборудования>(nameof(Простои));
    }


}
