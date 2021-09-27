using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolaMundoWpfApplication
{
    /// <summary>
    /// Esta es una clase de Validación de una Propiedad de Dependencia ValorActual que
    /// depende de otras dos, valor mínimo y valor máximo. 
    /// </summary>
    public class RangoValores : Control
    {
        public RangoValores() : base() { }

        #region Propiedad de dependencia de Valor Actual 
        /// <summary>
        /// ValorActual Propiedad de dependencia
        /// </summary>
        public static readonly DependencyProperty ValorActualProperty = DependencyProperty.Register(
            "ValorActual",
            typeof(double),
            typeof(RangoValores),
            new FrameworkPropertyMetadata(
                Double.NaN,
                FrameworkPropertyMetadataOptions.None,
                new PropertyChangedCallback(OnValorActualChanged),
                new CoerceValueCallback(CoerceValorActual)
            ),
            new ValidateValueCallback(EsValidoValorActual)
        );

    
        public double ValorActual
        {
            get { return (double)GetValue(ValorActualProperty); }
            set { SetValue(ValorActualProperty, value); }
        }
        #endregion

        #region Valor Minimo
        /// <summary>
        /// ValorMinimo Propiedad de dependencia
        /// </summary>
        public static readonly DependencyProperty ValorMinimoProperty = DependencyProperty.Register(
        "ValorMinimo",
        typeof(double),
        typeof(RangoValores),
        new FrameworkPropertyMetadata(
            double.NaN,
            FrameworkPropertyMetadataOptions.None,
            new PropertyChangedCallback(OnValorMinimoChanged),
            new CoerceValueCallback(CoerceValorMinimo)
        ),
        new ValidateValueCallback(EsValidoValorActual));

  
        public double ValorMinimo
        {
            get { return (double)GetValue(ValorMinimoProperty); }
            set { SetValue(ValorMinimoProperty, value); }
        }
        #endregion


        #region Valor Maximo  DP
        /// <summary>
        /// ValorMaximo Propiedad de dependencia
        /// </summary>
        public static readonly DependencyProperty ValorMaximoProperty = DependencyProperty.Register(
        "ValorMaximo",
        typeof(double),
        typeof(RangoValores),
        new FrameworkPropertyMetadata(
            double.NaN,
            FrameworkPropertyMetadataOptions.None,
            new PropertyChangedCallback(OnValorMaximoChanged),
            new CoerceValueCallback(CoerceValorMaximo)
        ),
        new ValidateValueCallback(EsValidoValorActual));

        public double ValorMaximo
        {
            get { return (double)GetValue(ValorMaximoProperty); }
            set { SetValue(ValorMaximoProperty, value); }
        }
        #endregion




        #region ValorActual  Callbacks/validation/Coerces
        /// <summary>
        /// Actualiza el ValorActual para que esté dentro de los límites
        /// </summary>
        private static object CoerceValorActual(DependencyObject d, object value)
        {
            RangoValores g = (RangoValores)d;
            double current = (double)value;
            if (current < g.ValorMinimo) current = g.ValorMinimo;
            if (current > g.ValorMaximo) current = g.ValorMaximo;
            return current;
        }

        private static void OnValorActualChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(ValorMinimoProperty);  //invoca al delegado CoerceValueCallback ("CoerceValorMinimo")
            d.CoerceValue(ValorMaximoProperty);  //invoca al delegado CoerceValueCallback  ("CoerceValorMaximo")
        }
        #endregion

        #region ValorMinimo Callbacks/validation/Coerces
        /// <summary>
        /// Actualiza el ValorMinimo para que esté dentro de los límites (por debajo de  ValorMaximo)
        /// </summary>
        private static void OnValorMinimoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(ValorMaximoProperty);   //invoca al delegado CoerceValueCallback  ("CoerceValorMaximo")
            d.CoerceValue(ValorActualProperty);   //invoca al delegado CoerceValueCallback  ("CoerceValorActual")
        }

        private static object CoerceValorMinimo(DependencyObject d, object value)
        {
            RangoValores g = (RangoValores)d;
            double min = (double)value;
            if (min > g.ValorMaximo) min = g.ValorMaximo;
            return min;
        }
        #endregion

        #region ValorMaximo Callbacks/validation/Coerces
        /// <summary>
        /// Actualiza el ValorMaximo para que esté dentro de los límites (por encima de ValorMínimo)
        /// </summary>
        private static object CoerceValorMaximo(DependencyObject d, object value)
        {
            RangoValores g = (RangoValores)d;
            double max = (double)value;
            if (max < g.ValorMinimo) max = g.ValorMinimo;
            return max;
        }

        private static void OnValorMaximoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(ValorMinimoProperty); //invoca al delegado CoerceValueCallback ("CoerceValorMinimo")
            d.CoerceValue(ValorActualProperty);  //invoca al delegado CoerceValueCallback  ("CoerceValorActual")
        }
        #endregion

        #region ValorActual
        /// <summary>
        /// Validación de Valor Actual
        /// </summary>
        public static bool EsValidoValorActual(object value)
        {
            Double v = (Double)value;
            if (Double.IsNaN(v)) return true;
            try
            {
                int i = (int)v;
                return (i == v);
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }


}

