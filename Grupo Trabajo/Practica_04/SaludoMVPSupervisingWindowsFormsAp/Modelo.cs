using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoMVPSupervisingWindowsFormsAp
{
    public class Modelo : IModelo
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnSaludo(_nombre);
                }
            }
        }
        public event SaludoEventHandler Saludo;
        public void OnSaludo(string mensaje)
        {
            if (Saludo != null)
            {
                Saludo(this, new SaludoEventArgs(Nombre));
            }
        }
    }
}
