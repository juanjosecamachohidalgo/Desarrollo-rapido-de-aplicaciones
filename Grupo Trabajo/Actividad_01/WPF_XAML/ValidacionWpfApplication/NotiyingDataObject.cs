using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Reflection;


namespace WPF.Notify
{
    /// <summary>
    /// Clase abstracta de la cual deben derivar todos los objetos del ViewModel (la diferencia es que implementa INotifyDataErrorInfo en lugar de IDataErrorInfo)
    /// </summary>
    public abstract class NotifyingDataObject : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region Fields
        private readonly Dictionary<string, object> _values = new Dictionary<string, object>();
        private Dictionary<String, List<String>> _errorMessages =  new Dictionary<string, List<string>>();
        #endregion

        #region Protected

        /// <summary>
        /// Establece el valor de una propiedad.
        /// </summary>
        /// <typeparam name="T">El tipo del valor de la propiedad.</typeparam>
        /// <param name="propertySelector">Arbol de expresión que contiene la definición de la propiedad.</param>
        /// <param name="value">El valor de la propiedad.</param>
        protected void SetValue<T>(Expression<Func<T>> propertySelector, T value)
        {
            string propertyName = GetPropertyName(propertySelector);

            SetValue<T>(propertyName, value);
        }

        /// <summary>
        /// Establece el valor de una propiedad.
        /// </summary>
        /// <param name="propertySelector">Nombre de la propiedad.</param>
        /// <param name="value">El valor de la propiedad.</param>
        protected void SetValue<T>(string propertyName, T value)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("Invalid property name", propertyName);
            }

            _values[propertyName] = value;
            NotifyPropertyChanged(propertyName);
            
        }

        /// <summary>
        /// Obtiene el valor de una propiedad.
        /// </summary>
        /// <typeparam name="T">El tipo del valor de la propiedad.</typeparam>
        /// <param name="propertySelector">Arbol de expresión que contiene la definición de la propiedad.</param>
        /// <returns> El valor de la propiedad o el valor por defecto si no existe. </returns>
        protected T GetValue<T>(Expression<Func<T>> propertySelector)
        {
            string propertyName = GetPropertyName(propertySelector);

            return GetValue<T>(propertyName);
        }

        /// <summary>
        /// Obtiene el valor de una propiedad.
        /// </summary>
        /// <typeparam name="T">El tipo del valor de la propiedad.</typeparam>
        /// <param name="propertyName">El nombre de la propiedad.</param>
        /// <returns> El valor de la propiedad o el valor por defecto si no existe. </returns>
        protected T GetValue<T>(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("Invalid property name", propertyName);
            }

            object value;
            if (!_values.TryGetValue(propertyName, out value))
            {
                value = default(T);
                _values.Add(propertyName, value);
            }
            ValidateProperty(propertyName,value);
            return (T)value;
        }

        /// <summary>
        /// Valida las propiedades de la instancia acutal utilizando Anotaciones de datos. 
        /// </summary>
        /// <param name="propertyName">Propiedad de la instanca a validar.</param>
        protected virtual void ValidateProperty(string propertyName, object value)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("Invalid property name", propertyName);
            }

            //var value = GetValue(propertyName);
            var results = new List<ValidationResult>(); 
            bool isValid = Validator.TryValidateProperty(value, new ValidationContext(this, null, null) { MemberName = propertyName }, results); 
            if (isValid) RemoveErrorsForProperty(propertyName);
            else AddErrorsForProperty(propertyName, results);
            RaiseErrorsChanged(propertyName);
        } 
        private void AddErrorsForProperty(string propertyName, IEnumerable<ValidationResult> validationResults)
        { 
            RemoveErrorsForProperty(propertyName);
            _errorMessages.Add(propertyName, validationResults.Select(vr => vr.ErrorMessage).ToList()); 
        } 
        private void RemoveErrorsForProperty(string propertyName) 
        {
            if (_errorMessages.ContainsKey(propertyName))
                _errorMessages.Remove(propertyName); 
        }

        public bool ValidateObject() 
        { 
            var objectToValidate = this;
            _errorMessages.Clear(); 
            Type objectType = objectToValidate.GetType(); 
            PropertyInfo[] properties = objectType.GetProperties(); 
            foreach (PropertyInfo property in properties) 
            { 
                if (property.GetCustomAttributes(typeof(ValidationAttribute), true).Any()) 
                { 
                    object value = property.GetValue(objectToValidate, null);
                    ValidateProperty(property.Name, value);
                } 
            } 
            return !HasErrors; 
        }
        #endregion

        #region Change Notification
        /// <summary>
        /// Se dispara cuando una propiedad de este objeto se actualiza. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Dispara el evento de la propiedad del objeto. 
        /// </summary>
        /// <param name="propertyName">La propiedad que cambia de valor.</param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            this.VerifyPropertyName(propertyName);

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        protected void NotifyPropertyChanged<T>(Expression<Func<T>> propertySelector)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                string propertyName = GetPropertyName(propertySelector);
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion 
       
        #region Privates
        private string GetPropertyName(LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new InvalidOperationException();
            }

            return memberExpression.Member.Name;
        }

        private object GetValue(string propertyName)
        {
            object value;
            if (!_values.TryGetValue(propertyName, out value))
            {
                var propertyDescriptor = TypeDescriptor.GetProperties(GetType()).Find(propertyName, false);
                if (propertyDescriptor == null)
                {
                    throw new ArgumentException("Invalid property name", propertyName);
                }

                value = propertyDescriptor.GetValue(this);
                _values.Add(propertyName, value);
            }
            return value;
        }
        #endregion

        #region Debugging

        /// <summary>
        /// Warns the developer if this object does not have
        /// a public property with the specified name. This 
        /// method does not exist in a Release build.
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real,  
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;

                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        /// <summary>
        /// Returns whether an exception is thrown, or if a Debug.Fail() is used
        /// when an invalid property name is passed to the VerifyPropertyName method.
        /// The default value is false, but subclasses used by unit tests might 
        /// override this property's getter to return true.
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

        #endregion // Debugging Aides

        #region INotifyDataErrorInfo Members
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName) 
        {
            if (_errorMessages.ContainsKey(propertyName)) 
            {
                IList<string> propertyErrors = _errorMessages[propertyName]; 
                foreach (string propertyError in propertyErrors) 
                {
                    yield return propertyError; 
                } 
            } 
            yield break; 
        }
        public bool HasErrors
        {
            get { return _errorMessages.Count > 0; }
        }

        public void RaiseErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        #endregion
    }
}
