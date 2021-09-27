using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConsoleApp
{
    class FormularioMatriculacionAlemania : FormularioMatriculacion
    {
        public FormularioMatriculacionAlemania(FormularioImpl implementacion) : base(implementacion) { }

        protected override bool controlZona(string matricula)
        {
            return matricula.Length == 8;
        }
    }
}
