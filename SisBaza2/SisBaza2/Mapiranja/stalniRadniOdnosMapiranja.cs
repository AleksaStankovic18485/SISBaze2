using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class stalniRadniOdnosMapiranja : ClassMap<SisBaza2.Entiteti.stalniRadniOdnos>
    {
        public stalniRadniOdnosMapiranja()
        {
            Table("STALNIRADNIODNOS");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojRadneKnjizice, "BROJRADNEKNJIZICE");
            Map(x => x.PrethodniRadniStazGod, "PRETHODNIRADNISTAZGOD");
            Map(x => x.PrethodniRadniStazMes, "PRETHODNIRADNISTAZMES");
            Map(x => x.PrethodniRadniStazDan, "PRETHODNIRADNISTAZDAN");
            Map(x => x.ImeFirme, "IMEFIRME");
        }
    }
}
