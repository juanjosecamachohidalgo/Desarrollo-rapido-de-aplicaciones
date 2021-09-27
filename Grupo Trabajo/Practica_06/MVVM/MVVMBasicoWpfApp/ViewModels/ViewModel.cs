using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MVVMBasicoWpfApp.Services;
using MVVMBasicoWpfApp.Models;

namespace MVVMBasicoWpfApp.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            Title = "My title";
            Items = new ObservableCollection<Model>();
        }

        private ICommand _setTitleCommand;
        public ICommand SetTitleCommand
        {
            get
            {
                this._setTitleCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => CanUpdateTitle(),
                    ExecuteDelegate = p => SetTitle()
                };
                return this._setTitleCommand;
            }
        }

        private bool CanUpdateTitle()
        {
            return Title.Length < 50;
        }

        private void SetTitle()
        {
            Title += " grows! ";
        }

        private ICommand _resetTitleCommand;
        public ICommand ResetTitleCommand
        {
            get
            {
                this._resetTitleCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p => ResetTitle()
                };
                return this._resetTitleCommand;
            }
        }

        private void ResetTitle()
        {
            Title = "The title";
        }

        private ICommand _addItemCommand;
        public ICommand AddItemCommand
        {
            get
            {
                this._addItemCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p => AddItem()
                };
                return this._addItemCommand;
            }
        }

        private void AddItem()
        {
            Model newItem = new Model();
            newItem.Code = Items.Count == 0 ? 1 : Items[Items.Count - 1].Code + 1;
            newItem.Name = "Item #" + newItem.Code;

            Items.Add(newItem);
            SelectedItem = newItem;
            NotifyPropertyChanged("Items");
        }

        private ICommand _removeItemCommand;
        public ICommand RemoveItemCommand
        {
            get
            {
                this._removeItemCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => CanRemove(),
                    ExecuteDelegate = p => RemoveItem()
                };
                return this._removeItemCommand;
            }
        }

        private bool CanRemove()
        {
            return SelectedItem != null;
        }

        private void RemoveItem()
        {
            Items.Remove(SelectedItem);
            NotifyPropertyChanged("Items");
        }

        private ICommand _showYesNoQuestionCommand;
        public ICommand BadShowYesNoQuestionCommand
        {
            get
            {
                this._showYesNoQuestionCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p => BadShowYesNoQuestion("Are you sure?")
                };
                return this._showYesNoQuestionCommand;
            }
        }

        public ICommand ShowYesNoQuestionCommand
        {
            get
            {
                this._showYesNoQuestionCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p => GoodShowYesNoQuestion("Are you sure?")
                };
                return this._showYesNoQuestionCommand;
            }
        }

        private void BadShowYesNoQuestion(string message)
        {
            MessageBoxResult result;
            result = MessageBox.Show(message, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Answer = "Your answer is Yes";
                    break;

                default:
                    this.Answer = "Your answer is No";
                    break;
            }
        }

        private void GoodShowYesNoQuestion(string message)
        {
            IMsgBoxService msgbox = GetService<IMsgBoxService>();

            MessageBoxResult result = msgbox.Show(message, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Answer = "Your answer is Yes";
                    break;

                default:
                    this.Answer = "Your answer is No";
                    break;
            }
        }

        public ICommand ShowWelcomeMsgCommand
        {
            get
            {
                this._showYesNoQuestionCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p =>
                    {
                        IMsgBoxService msgbox = GetService<IMsgBoxService>();

                        MessageBoxResult result = msgbox.Show("Welcome! This message appears when 'Loaded' event is fired.", "Welcome message", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                };
                return this._showYesNoQuestionCommand;
            }
        }

        private ICommand _changeColorCommand;
        public ICommand ChangeColorCommand
        {
            get
            {
                this._changeColorCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p =>
                    {
                        MouseEnterText = "Mouse entered! " + DateTime.Now.ToLongTimeString();
                        ColorText = GetRandomBrush();
                    }
                };
                return this._changeColorCommand;
            }
        }

        public static Brush GetRandomBrush()
        {
            Random r = new Random();
            byte red = (byte)r.Next(0, byte.MaxValue + 1);
            byte green = (byte)r.Next(0, byte.MaxValue + 1);
            byte blue = (byte)r.Next(0, byte.MaxValue + 1);
            return new SolidColorBrush(Color.FromArgb(255, red, green, blue));
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }

        private Model _selectedItem;
        public Model SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        private string _answer;
        public string Answer
        {
            get
            {
                return _answer;
            }

            set
            {
                _answer = value;
                NotifyPropertyChanged("Answer");
            }
        }

        private string _mouseentertext;
        public string MouseEnterText
        {
            get
            {
                return _mouseentertext;
            }

            set
            {
                _mouseentertext = value;
                NotifyPropertyChanged("MouseEnterText");
            }
        }

        private Brush _colortext;
        public Brush ColorText
        {
            get
            {
                return _colortext;
            }

            set
            {
                _colortext = value;
                NotifyPropertyChanged("ColorText");
            }
        }

        public ObservableCollection<Model> Items { get; set; }

    }
}
