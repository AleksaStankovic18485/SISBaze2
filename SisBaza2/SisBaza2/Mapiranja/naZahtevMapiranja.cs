using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class naZahtevMapiranja : ClassMap<SisBaza2.Entiteti.naZahtev>
    {
        public naZahtevMapiranja()
        {

            Table("ZAHTEV");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.IdZahteva, "IDZAHTEVA");
            Map(x => x.idPoslanika, "IDPOSLANIKA");
            Map(x => x.ZatrazenoVreme, "ZATRAZENOVREME");
        }
    }
}
