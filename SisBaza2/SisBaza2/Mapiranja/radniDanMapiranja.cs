using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class radniDanMapiranja : ClassMap<SisBaza2.Entiteti.radniDan>
    {
        public radniDanMapiranja()
        {
            Table("RADNIDAN");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.PocetakRadnogDana, "POCETAKRADNOGDANA");
            Map(x => x.KrajRadnogDana, "KRAJRADNOGDANA");
            Map(x => x.BrojPoslanikaNaPocetku, "BROJPOSLANIKANAPOCETKU");
            //advanced
            Map(x => x.JMBGNarodnogPoslanika, "JMBGNARODNOGPOSLANIKA");
        }
    }
}
