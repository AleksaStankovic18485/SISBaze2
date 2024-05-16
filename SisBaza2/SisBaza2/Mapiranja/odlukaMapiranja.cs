using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class odlukaMapiranja : ClassMap<SisBaza2.Entiteti.odluka>
    {
        public odlukaMapiranja()
        {
            Table("ODLUKA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            
        }
    }
}
