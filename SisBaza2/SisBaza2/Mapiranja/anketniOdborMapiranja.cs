using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class anketniOdborMapiranja : ClassMap<SisBaza2.Entiteti.anketniOdbori>
    {
        public anketniOdborMapiranja()
        {
            Table("ANKETNI_ODBORI");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
           /* Map(x => x.PredsednikJMBG, "PREDSEDNIKJMBG");
            Map(x => x.ZamenikPredsednikJMBG, "ZAMENIKPREDSEDNIKJMBG");
            Map(x => x.SluzbenaProstorija, "SLUZBENAPROSTORIJA");*/
        }
    }
}
