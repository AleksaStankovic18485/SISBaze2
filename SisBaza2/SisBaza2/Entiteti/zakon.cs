﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBaza2.Entiteti
{
    public class zakon
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public zakon() { }
    }
}
