using System;

namespace BridgeConsoleApp
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            FormularioMatriculacionPortugal formulario1 = new FormularioMatriculacionPortugal(new FormHtmlImpl());
            formulario1.visualiza();
            if (formulario1.administraZona())
                formulario1.generaDocumento();
            Console.WriteLine();
            FormularioMatriculacionEspania formulario2 = new FormularioMatriculacionEspania(new FormAppletImpl());
            formulario2.visualiza();
            if (formulario2.administraZona())
                formulario2.generaDocumento();
            FormularioMatriculacionAlemania formulario3 = new FormularioMatriculacionAlemania(new FormRtfImpl());
            formulario3.visualiza();
            if (formulario3.administraZona())
                formulario3.generaDocumento();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

