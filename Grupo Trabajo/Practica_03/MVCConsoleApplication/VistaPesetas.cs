using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPasivoClassLibrary;

namespace MVCConsoleApplication
{
    class VistaPesetas: IVista
    {
        private Controlador _controlador;
        public Controlador Controlador
        {
            get
            {
                return this._controlador;
            }
            set
            {
               this._controlador = value;
            }
        }

        public string Cantidad
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                MensajeCambio = value;
            }
        }

        public string MensajeCambio
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                Console.Write("Son {0}",  value);
                Console.ReadLine();
            }
        }

        public string MensajeIntro
        {
            get
            {
                Console.Write("Introduzca la cantidad inicial: ");
                _controlador.ConvertirCantidadAPesetas(Console.ReadLine());
                return "";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
