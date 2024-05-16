using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class stalniRadniOdnos
    {
        public virtual int Id { get; protected set; }
        public virtual string BrojRadneKnjizice { get; set; }
        public virtual int PrethodniRadniStazGod { get; set; }
        public virtual int PrethodniRadniStazMes { get; set; }
        public virtual int PrethodniRadniStazDan { get; set; }
        public virtual string  ImeFirme { get; set; }

        public stalniRadniOdnos() { }   
    }
}
