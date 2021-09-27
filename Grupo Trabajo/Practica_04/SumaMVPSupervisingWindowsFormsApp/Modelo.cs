using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMVPSupervisingWindowsFormsApp
{
    public class Modelo : IModelo
    {
        private string _numeroA;
        private string _numeroB;
        public string NumeroA
        {
            get { return _numeroA; }
            set
            {
                if (_numeroA != value)
                {
                    _numeroA = value;                    
                    OnSuma(_numeroA, _numeroB);
                }
            }
        }
        public string NumeroB
        {
            get { return _numeroB; }
            set
            {
                if (_numeroB != value)
                {
                    _numeroB = value;
                    OnSuma(_numeroA, _numeroB);
                }
            }
        }
        public event SumaEventHandler Suma;

        public void OnSuma(string numeroA, string numeroB)
        {
            if (Suma != null)
            {
                Suma(this, new SumaEventArgs(numeroA, numeroB));
            }
        } 
    }
}
