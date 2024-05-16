using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class sednicaMapiranja : ClassMap<SisBaza2.Entiteti.sednica>
    {
        public sednicaMapiranja()
        {
            Table("SEDNICA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojZasedanja, "BROJZASEDANJA");
            Map(x => x.BrojSaziva, "BROJSAZIVA");
            Map(x => x.DatumPocetka, "DATUMPOCETKA");
            Map(x => x.DatumZarvsetka, "DATUMZAVRSETKA");
            Map(x => x.TipSednice, "TIPSEDNICE");
            Map(x => x.ZatrazenoVreme, "ZATRAZENOVREME");
            Map(x => x.ZakazanoVreme, "ZAKAZANOVREME");
        }
    }
}
