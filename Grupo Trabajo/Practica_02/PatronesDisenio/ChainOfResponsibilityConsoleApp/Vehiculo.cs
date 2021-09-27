using System;

namespace ChainOfResponsibilityConsoleApp
{
    public class Vehiculo : ObjetoBasico
    {
        protected string laDescripcion;

        public Vehiculo(string descripcion)
        {
            this.laDescripcion = descripcion;
        }

        protected override string descripcion
        {
            get
            {
                return laDescripcion;
            }
        }
    }
}
