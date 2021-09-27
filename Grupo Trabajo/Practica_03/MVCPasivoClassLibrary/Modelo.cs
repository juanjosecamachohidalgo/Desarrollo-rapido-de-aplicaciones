using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPasivoClassLibrary
{
    public class Modelo:IModelo
    {
        private double _cantidad;
        public double Cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                this._cantidad = value;
            }
        }
    }
}
