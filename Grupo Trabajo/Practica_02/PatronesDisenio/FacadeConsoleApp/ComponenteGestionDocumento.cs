using System;

namespace FacadeConsoleApp
{
    public class ComponenteGestionDocumento : GestionDocumento
    {

        public string documento(int indice)
        {
            return "Documento n�mero " + indice;
        }
    }
}

