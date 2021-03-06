using System;

namespace InterpreterConsoleApp
{
    public class PalabraClave : Expresion
    {
        protected string palabraClave;

        public PalabraClave(string palabraClave)
        {
            this.palabraClave = palabraClave;
        }

        public override bool evalua(string descripcion)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }

        // parte análisis sintáctico
        public static new Expresion parsea()
        {
            Expresion resultado;
            resultado = new PalabraClave(pieza);
            siguientePieza();
            return resultado;
        }
    }
}
