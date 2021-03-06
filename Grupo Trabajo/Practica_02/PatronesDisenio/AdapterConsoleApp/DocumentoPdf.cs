using System;

namespace AdapterConsoleApp
{
    public class DocumentoPdf : Documento
    {
        protected ComponentePdf herramientaPdf = new ComponentePdf();

        public string contenido
        {
            set
            {
                herramientaPdf.pdfFijaContenido(value);
            }
        }

        public void dibuja()
        {
            herramientaPdf.pdfPreparaVisualizacion();
            herramientaPdf.pdfRefresca();
            herramientaPdf.pdfFinalizaVisualizacion();
        }

        public void imprime()
        {
            herramientaPdf.pdfEnviaImpresora();
        }
    }
}

