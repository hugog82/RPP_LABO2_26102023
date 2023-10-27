using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        public Camioneta (EPropulsion propulsion, bool cabinaSimple) : base (propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetInfo());
            sb.Append("con cabina:");
            sb.Append(cabinaSimple ? "true" : "false");
            return sb.ToString();
        }

        public override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

    }
}
