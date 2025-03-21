using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Xpo;

namespace CPPMReportEntities.DomainObjects
{
    public class ТипИзделия : XPCustomObject
    {
        public ТипИзделия(Session сеанс) : base(сеанс) { }

        private Guid oid;
        private string название;
        private string? короткоеНазвание;
        private string? описание;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(oid), ref oid, value);
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

        [Size(1000)]
        public string? Описание
        {
            get => описание;
            set => SetPropertyValue(nameof(Описание), ref описание, value);
        }

        [Association("ТипИзделия-ПодтипыИзделия")]
        public XPCollection<ПодтипИзделия> Подтипы
        {
            get => GetCollection<ПодтипИзделия>(nameof(Подтипы));
        }
    }

}
