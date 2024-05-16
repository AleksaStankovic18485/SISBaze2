using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class pravniAkt
    {
        public virtual int Id { get; protected set; }

        //verovatno advanced
        public virtual int IdSednica { get; set; }
        public pravniAkt() { }
    }
}
