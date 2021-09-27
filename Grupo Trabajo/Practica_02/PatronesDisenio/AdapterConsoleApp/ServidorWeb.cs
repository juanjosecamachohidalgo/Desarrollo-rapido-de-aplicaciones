using System;

namespace AdapterConsoleApp
{
    public class ServidorWeb
    {
        static void Main(string[] args)
        {
            Documento documento1, documento2, documento3;
            documento1 = new DocumentoHtml();
            documento1.contenido = "Hola";
            documento1.dibuja();
            documento1.imprime();
            Console.WriteLine();
            documento2 = new DocumentoPdf();
            documento2.contenido = "Hola";
            documento2.dibuja();
            documento2.imprime();
            documento3 = new DocumentoRtf();
            documento3.contenido = "Hola";
            documento3.dibuja();
            documento3.imprime();

            Console.ReadLine();
        }
    }
}

