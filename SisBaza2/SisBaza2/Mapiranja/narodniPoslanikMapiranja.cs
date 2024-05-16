using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SisBaza2.Entiteti;

namespace SisBaza2.Mapiranja
{
    class narodniPoslanikMapiranja : ClassMap<SisBaza2.Entiteti.narodniPoslanik>
    {
        public narodniPoslanikMapiranja()
        {
            Table("NARODNIPOSLANIK");

            /*kljucevi???*/
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.JMBG, "JMBG");
            Map(x => x.IdentifikacioniBroj, "IDENTIFIKACIONIBROJ");
            Map(x => x.Ime, "IME");
            Map(x => x.ImeJednogRoditelja, "IMEJEDNOGRODITELJA");
            Map(x => x.Prezime, "PREZIME");
            /*Map(x => x.IzbornaLista, "IZBORNALISTA");*/
            Map(x => x.DatumRodjenja, "DATUMRODENJA");
            Map(x => x.MestoRodjenja, "MESTORODENJA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojTelefona, "BROJTELEFONA");
            Map(x => x.BrojMobilnog, "BROJMOBILNOG");
            /*Map(x=>x.IdPrisutnogGradnjana)*/




        }

    }
}
