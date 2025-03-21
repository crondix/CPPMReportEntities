

using DevExpress.Xpo;

namespace CPPMReportEntities
{
    public class ЕдиницаИзмерения : XPObject
    {
        public ЕдиницаИзмерения(Session сеанс) : base(сеанс) { }

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
