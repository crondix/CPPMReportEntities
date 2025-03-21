using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Xpo;

using static System.Collections.Specialized.BitVector32;

namespace CPPMReportEntities
{


    public class Оборудование : XPObject
    {
        public Оборудование(Session сеанс) : base(сеанс) { }

        private string название;
        private string? описание;
        private string? короткоеНазвание;
        private Guid oid;

        [DevExpress.Xpo.Key]
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

        [DevExpress.Xpo.Association("Оборудование-ЗадачиОборудования")]
        public XPCollection<ЗадачаОборудования> Задачи => GetCollection<ЗадачаОборудования>(nameof(Задачи));
    }

}
