using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class sluzbenaProstorijaMapiranja : ClassMap<SisBaza2.Entiteti.sluzbenaProstorija>
    {
        public sluzbenaProstorijaMapiranja()
        {
            Table("SLUZBENAPROSTORIJA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Sprat, "SPRAT");
            Map(x => x.BrojProstorije, "BROJPROSTORIJE");
        }
    }
}
