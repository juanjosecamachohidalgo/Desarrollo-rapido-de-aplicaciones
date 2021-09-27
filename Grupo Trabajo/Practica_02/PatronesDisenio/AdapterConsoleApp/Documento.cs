using System;

namespace AdapterConsoleApp
{
    public interface Documento
    {
        string contenido { set; }
        void dibuja();
        void imprime();
    }
}

