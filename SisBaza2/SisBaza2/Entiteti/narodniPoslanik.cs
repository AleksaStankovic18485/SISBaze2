using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class narodniPoslanik
    {
        public virtual int Id { get; protected set; }
        public virtual string JMBG { get; set; }
        public virtual int IdentifikacioniBroj { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeJednogRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        /*public virtual string IzbornaLista { get; set; } ??*/
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string MestoRodjenja { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string BrojMobilnog { get; set; }
        /*public virtual int IdPrisutnogGradjana { get; set; }
         ADVANCED*/

        public narodniPoslanik()
        {

        }
    }
    
}
