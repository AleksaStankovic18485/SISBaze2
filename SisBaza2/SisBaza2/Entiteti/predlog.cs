using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class predlog
    {
        //videcemo kako cemo ovo sa predlogom posto nam je u bazi 3 entiteta koji su razliciti predlozi
        public virtual int Id { get; protected set; }
        public virtual int IdOsobe { get; set; }
        public virtual int BrojBiraca { get; set; } //predlogBiraca
        public virtual int IdPredloga { get; set; } //predlogPoslanika  
        public predlog() { }
    }
}
