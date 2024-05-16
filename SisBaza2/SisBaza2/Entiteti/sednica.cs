using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class sednica
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime ZakazanoVreme { get; set; } //redovna
        public virtual DateTime ZatrazenoVreme { get; set; } //vanredna

        public virtual int BrojZasedanja { get; set; }
        public virtual int BrojSaziva { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime DatumZarvsetka { get; set; }
        public virtual string TipSednice { get; set; }

        public sednica() { }
    }
}
