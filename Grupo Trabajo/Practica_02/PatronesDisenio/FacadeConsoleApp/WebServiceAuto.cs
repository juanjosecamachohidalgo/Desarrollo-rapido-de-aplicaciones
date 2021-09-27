using System;
using System.Collections.Generic;

namespace FacadeConsoleApp
{
    public interface WebServiceAuto
    {
        string documento(int indice);
        IList<string> buscaVehiculos(int precioMedio, int desviacionMax);
    }
}
