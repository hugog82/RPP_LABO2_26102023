﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto(EPropulsion ePropulsion) : base(ePropulsion)
        {

        }

        public override string Tipo
        {
            get
            {
                return "Moto";
            }
        }
    }
}
