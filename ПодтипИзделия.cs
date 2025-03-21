using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Xpo;

namespace CPPMReportEntities.DomainObjects
{
    public class ПодтипИзделия : XPObject
    {
        public ПодтипИзделия(Session сеанс) : base(сеанс) { }

        private string название;
        private string? короткоеНазвание;
        private string? описание;
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
    }

}
