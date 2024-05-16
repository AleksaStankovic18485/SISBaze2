using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class sluzbenaProstorija
    {
        public virtual int Id { get; protected set; }

        public virtual int Sprat { get; set; }
        public virtual int  BrojProstorije { get; set; }
        public sluzbenaProstorija() { }
    }
}
