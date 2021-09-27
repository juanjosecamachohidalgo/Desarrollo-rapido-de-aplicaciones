using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterConsoleApp
{
    class DocumentoRtf : Documento
    {
        protected string _contenido;

        public string contenido
        {
            protected get
            {
                return _contenido;
            }
            set
            {
                _contenido = value;
            }
        }

        public void dibuja()
        {
            Console.WriteLine("Dibuja el documento RTF: " + contenido);
            Console.WriteLine("Dibuja una sonrisa: :)");
        }

        public void imprime()
        {
            Console.WriteLine("Imprime el documento RTF: " + contenido);
        }
    }
}
