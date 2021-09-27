using System;

namespace BridgeConsoleApp
{
    public class FormularioMatriculacionEspania : FormularioMatriculacion
    {
        public FormularioMatriculacionEspania(FormularioImpl implementacion) : base(implementacion) { }

        protected override bool controlZona(string matricula)
        {
            return matricula.Length == 7;
        }
    }
}

