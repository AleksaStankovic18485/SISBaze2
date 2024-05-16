using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class deklaracijaMapiranja : ClassMap<SisBaza2.Entiteti.deklaracija>
    {
        public deklaracijaMapiranja()
        {
            Table("DEKLARACIJA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumIzdavanja, "DATUMIZDAVANJA");
        }
    }
}
