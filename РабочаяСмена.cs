using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Xpo;

namespace CPPMReportEntities.DomainObjects
{
    public class РабочаяСмена : XPCustomObject
    {
        public РабочаяСмена(Session сеанс) : base(сеанс) { }

        private Guid oid;
        private string название;
        private string? короткоеНазвание;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(OID), ref oid, value);
        }


        [Size(50)]
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

        [Association("РабочаяСмена-ЗадачаСмены")]
        public XPCollection<ЗадачаСмены> ЗадачиСмены
        {
            get => GetCollection<ЗадачаСмены>(nameof(ЗадачиСмены));
        }
    }

}
