using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class radnoTelo
    {
        public virtual int Id { get; protected set; }

        //treba i inf o clanovima
        public virtual string Naziv { get; set; }
        /*public virtual string PredesdnikJMBG { get; set; }*/
        /*public virtual string  ZamenikPredsednikaJMBG { get; set; }*/
        /*public virtual int SluzbenaProstorija { get; set; }*/
        public radnoTelo() { }
    }
}
