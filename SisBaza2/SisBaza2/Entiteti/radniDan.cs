using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class radniDan
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime PocetakRadnogDana { get; set; }
        public virtual DateTime KrajRadnogDana { get; set; }
        public virtual int BrojPoslanikaNaPocetku { get; set; }
        //advanced
        public virtual string JMBGNarodnogPoslanika { get; set; }
        public radniDan() { }
    }
}
