using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace DRA.jch004.Practica_01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("¿Introduce tu Nombre ? ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("¿Introduce tus Apellidos ? ");
            string apellidos = System.Console.ReadLine();
            string nombreCompuesto = nombre + " " + apellidos;
            string mensaje = "Bienvenido " + nombreCompuesto + "version1";
            System.Console.WriteLine(mensaje);
            System.Console.ReadLine();
            Class2 clase2 = new Class2();
            Class1 clase1 = new Class1();
        }
    }
}
