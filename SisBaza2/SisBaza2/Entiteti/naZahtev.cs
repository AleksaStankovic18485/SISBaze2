using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class naZahtev
    {
        //ista prica kao predlog mzd uzmemo da spojimo nasa 2 entitea za zahteve u jedan jer ovk ima smisla al videcemo
        public virtual int Id { get; protected set; }
        public virtual int IdZahteva { get; set; } //Zposlanika
        public virtual int idPoslanika { get; set; } //Zposlanika
        //samo datum
        public virtual DateTime ZatrazenoVreme { get; set; } //Zvlada
        public naZahtev() { }
    }
}
