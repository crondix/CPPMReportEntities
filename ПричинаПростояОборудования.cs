using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Xpo;

namespace CPPMReportEntities
{
    public class ПричинаПростояОборудования : XPObject
    {
        public ПричинаПростояОборудования(Session сеанс) : base(сеанс) { }

        private string причина;
        private Guid oid;

        [Key]
        public Guid OID
        {
            get => oid;
            set => SetPropertyValue(nameof(OID), ref oid, value);
        }
        [Size(255)]
        public string Причина
        {
            get => причина;
            set => SetPropertyValue(nameof(Причина), ref причина, value);
        }
    }


}
