using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class predlogMapiranja : ClassMap<SisBaza2.Entiteti.predlog>
    {
        public predlogMapiranja()
        {
            //treba da vidimo da li cemo ova nasa 3 entitea u bazi sto su predlozi da svrstamo u samo jedan predlog ili ne
            /*Table("PREDLOG");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.NazivPoslanickeGrupe, "NAZIV_POSLANICKE_GRUPE");*/
        }
    }
}
