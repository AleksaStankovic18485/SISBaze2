using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class poslanickaGrupaMapiranja : ClassMap<SisBaza2.Entiteti.poslanickaGrupa>
    {
        public poslanickaGrupaMapiranja()
        {
            Table("POSLANICKAGRUPA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.NazivPoslanickeGrupe, "NAZIV_POSLANICKE_GRUPE");
        }
    }
}
