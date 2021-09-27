using System;

namespace SingletonConsoleApp
{
    public class TestComercial
    {
        static void Main(string[] args)
        {
            // inicializaci�n del comercial en el sistema
            Comercial elComercial = Comercial.Instance();
            elComercial.nombre = "Comercial Auto";
            elComercial.direccion = "Madrid";
            elComercial.email = "comercial@comerciales.com";
            // muestra el comercial del sistema
            visualiza();

            Console.ReadLine();
        }

        public static void visualiza()
        {
            Comercial elComercial = Comercial.Instance();
            elComercial.visualiza();
        }
    }
}

