using System;
using System.Collections.Generic;

namespace FacadeConsoleApp
{
    public interface Catalogo
    {
        IList<string> buscaVehiculos(int precioMin, int precioMax);
    }
}

