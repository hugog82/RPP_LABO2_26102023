namespace Entidades

{
    public enum EPropulsion
    {
        Combustion,
        Hibrida,
        Electrica
    }
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.numeroDeChasis = Guid.NewGuid();
            this.esAWD = false;
        }

        protected Vehiculo (EPropulsion propulsion, bool esAWD) :this (propulsion)
        {
            this.esAWD = esAWD;
        }
        
        public EPropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }

        public abstract string Tipo { get; }

        protected string GetInfo()
        {
            string esAWDString = this.esAWD ? "SI" : "NO";
            return string.Format("{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}.", Tipo, Propulsion, esAWDString, numeroDeChasis);
        }
        public override string ToString()
        {
            return GetInfo();
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
    
}