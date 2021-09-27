using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderConsoleApp
{
    class ConstructorDocumentacionVehiculoRtf : ConstructorDocumentacionVehiculo
    {
        public ConstructorDocumentacionVehiculoRtf()
        {
            documentacion = new DocumentacionRtf();
        }

        public override void construyeSolicitudPedido(string nombreCliente)
        {
            string documento;
            documento = "<RTF>Solicitud de pedido Cliente: " + nombreCliente + "</RTF>";
            documentacion.agregaDocumento(documento);
        }

        public override void construyeSolicitudMatriculacion(string nombreSolicitante)
        {
            string documento;
            documento = "<RTF>Solicitud de matriculación Solicitante: " + nombreSolicitante + "</RTF>";
            documentacion.agregaDocumento(documento);
        }
    }
}
