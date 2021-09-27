using System.ComponentModel.DataAnnotations;
using WPF.Notify;
using WPF.RelayCommand;
using System.Windows.Input;

namespace ValidacionWpfApplication
{
    public class UsuarioViewDataModel : NotifyingDataObject
    {

        public UsuarioViewDataModel()
        {
            this.OkCommand = new RelayCommand(p => { p = (true); }, p => (true));
        }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        /// <remarks>
        /// No es permitido una cadena vacía
        /// Número de caracteres alfabéticos entre 5 y 15.
        /// </remarks>
        [Required]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{5,15}$")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{5,15}$", ErrorMessageResourceType = typeof(Resources.MensajesErrorResources), ErrorMessageResourceName = "NombreErrorMensaje")]
        public string Nombre
        {
            get { return GetValue(() => Nombre); }
            set { SetValue(() => Nombre, value); }
        }

        /// <summary>
        /// Palabra de Paso
        /// </summary>
        /// <remarks>
        /// Al menos (1) caracter en minusculas
        /// Al menos (1) caracter en mayúsculas  
        /// Al menos (1) digito

        /// longitud entre 4 y 10 caracteres

        /// </remarks>
        [Required]
        //[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,10}$", ErrorMessage = "Tiene que tener un caracter minuscula, mayuscula y un digito, con una longitud entre (4-10)")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,10}$", ErrorMessageResourceType = typeof(Resources.MensajesErrorResources), ErrorMessageResourceName = "PalabraDePasoErrorMensaje")]
        public string PalabraDePaso
        {
            get { return GetValue(() => PalabraDePaso); }
            set { SetValue(() => PalabraDePaso, value); }
        }


        public ICommand OkCommand
        {
            get { return GetValue(() => OkCommand); }
            set { SetValue(() => OkCommand, value); }
        }


    }
}


