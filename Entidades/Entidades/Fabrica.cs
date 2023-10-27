using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public Fabrica(List<Vehiculo> vehiculos)
        {
            this.vehiculos = vehiculos;
        }
        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }


        public Fabrica (int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
    }

}
