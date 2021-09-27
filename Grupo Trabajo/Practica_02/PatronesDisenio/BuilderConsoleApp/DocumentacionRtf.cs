using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderConsoleApp
{
    class DocumentacionRtf : Documentacion

    {
        public override void agregaDocumento(string documento)
        {
            if (documento.StartsWith("<RTF>"))
                contenido.Add(documento);
        }

        public override void imprime()
        {
            Console.WriteLine("Documentación RTF");
            foreach (string s in contenido)
                Console.WriteLine(s);
        }
    }
}
