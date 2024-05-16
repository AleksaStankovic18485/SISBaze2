using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class pravniAktMapiranja : ClassMap<SisBaza2.Entiteti.pravniAkt>
    {
        public pravniAktMapiranja()
        {
            Table("PRAVNIAKT");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            //verovatno advanced
            Map(x => x.IdSednica, "IDSEDNICA");
        }
    }
}
