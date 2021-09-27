using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using MVVMBasicoWpfApp.Services;

namespace MVVMBasicoWpfApp.Behaviors
{
    public static class MouseBehavior
    {
        public static readonly DependencyProperty MouseEnterProperty;

        static MouseBehavior()
        {
            MouseEnterProperty =  DependencyProperty.RegisterAttached("MouseEnter",
                typeof(ICommand), typeof(MouseBehavior), new PropertyMetadata(MouseEnterCallback));
        }

        public static ICommand GetMouseEnter(UIElement element)
        {
            return (ICommand)element.GetValue(MouseEnterProperty);
        }

        public static void SetMouseEnter(UIElement element, ICommand value)
        {
            element.SetValue(MouseEnterProperty, value);
        }

        private static void MouseEnterCallback(object obj, DependencyPropertyChangedEventArgs e)
        {
            var element = obj as UIElement;

            element.MouseEnter += (sender, ev) =>
            {
                var el = sender as UIElement;

                var command = GetMouseEnter(el);

                if (command.CanExecute(null))
                {
                    command.Execute(el);
                }
            };
        }
    }
}
