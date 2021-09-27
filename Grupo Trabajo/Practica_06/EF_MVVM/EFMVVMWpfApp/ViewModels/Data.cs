using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using System.Linq;
using System.Windows.Data;
using System.Data.Entity;
using EFMVVMClassLibrary;

namespace EFMVVMWpfApp.ViewModels
{
    public sealed class Data : ViewModelBase, IDisposable
    {
        #region Private members

        private readonly AdventureWorksLT2008Entities _dbContext;
        private ObservableCollection<Customer> _CustomersCollection;
        private ICommand _searchCommand;
        private ICollectionView _CustomersView;
        private string _searchName = "";
        private ICommand _SaveChanges;
        private ICommand _AddCustomer;
        private ICommand _DeleteCustomer;
        private string _Panel1StatusBar;
        private string _Panel2StatusBar;

        #endregion

        #region Properties

        public bool InstantSearch { get; set; }

        public string SearchName
        {
            get
            {
                return _searchName;
            }
            set
            {
                _searchName = value;
                if (InstantSearch) this.Search();
            }
        }

        public ObservableCollection<Customer> CustomersCollection
        {
            get
            {
                return _CustomersCollection;
            }
            set
            {
                _CustomersCollection = value;
                NotifyPropertyChanged("CustomersList");
            }
        }

        public Customer CurrentCustomer
        {
            get
            {
                if (_CustomersView == null)
                {
                    return new Customer();
                }
                else
                {
                    return _CustomersView.CurrentItem as Customer;
                }
            }
        }

        public string Panel1StatusBar
        {
            get
            {
                return _Panel1StatusBar;
            }
            set
            {
                _Panel1StatusBar = value;
                NotifyPropertyChanged("Panel1StatusBar");
            }
        }

        public string Panel2StatusBar
        {
            get
            {
                return _Panel2StatusBar;
            }
            set
            {
                _Panel2StatusBar = value;
                NotifyPropertyChanged("Panel2StatusBar");
            }
        }

        #endregion

        #region Constructor

        public Data()
        {
#if DEBUG
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                CustomersCollection = new ObservableCollection<Customer> {
                    new Customer { FirstName="John", LastName="Doe", CompanyName="Nomen nescio" },
                    new Customer { FirstName="Jane", LastName="Doe", CompanyName="Nomen nescio" }
                };
                return;
            }
#endif               
            _dbContext = new AdventureWorksLT2008Entities();
            CustomersCollection = new ObservableCollection<Customer>(from c in _dbContext.Customer 
                                                                     select c);

            _CustomersView = CollectionViewSource.GetDefaultView(CustomersCollection);

            _CustomersView.CurrentChanged += (sender, e) => { 
                NotifyPropertyChanged("CurrentCustomer");
                Panel1StatusBar = String.Format("Total customers: {0}, Filtered results: {1}",
                   CustomersCollection.Count,
                   ((ListCollectionView)_CustomersView).Count);
                Panel2StatusBar = String.Format("Total address: {0}",
                    CurrentCustomer.CustomerAddress.Count);

            };
        }

        #endregion  

        #region SearchCommand
        
        public ICommand SearchCommand
        {
            get
            {
                this._searchCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p => Search()
                };
                return this._searchCommand;
            }
        }

        private void Search()
        {
            _CustomersView.Filter = c => ((Customer)c).FirstName.Contains(SearchName) ||
                ((Customer)c).LastName.Contains(SearchName);
        }

        #endregion

        #region AddCustomer

        public ICommand AddCustomer
        {
            get
            {
                this._AddCustomer = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p =>
                    {
                        Customer nc = new Customer
                        {
                            FirstName = "NewCustomer",
                            LastName = "NewCustomer",
                            PasswordHash = "",
                            PasswordSalt = "",
                            rowguid = Guid.NewGuid(),
                            ModifiedDate = DateTime.Now
                        };

                        this.CustomersCollection.Add(nc);
                        _dbContext.Customer.Add(nc);
                        _dbContext.SaveChanges();
                        _CustomersView.Refresh();
                    }
                };
                return this._AddCustomer;
            }
        }

        #endregion

        #region DeleteCustomer

        public ICommand DeleteCustomer
        {
            get
            {
                this._DeleteCustomer = new RelayCommand()
                {
                    CanExecuteDelegate = o => CurrentCustomer != null,
                    ExecuteDelegate = o =>
                    {
                        //if (CurrentCustomer.EntityKey != null)
                        if (CurrentCustomer != null)
                        {
                            _dbContext.Customer.Remove(CurrentCustomer);
                            _dbContext.SaveChanges();
                            _CustomersView.Refresh();
                        }
                    }
                };
                return this._DeleteCustomer;
            }
        }

        #endregion

        #region SaveChanges

        public ICommand SaveChanges
        {
            get
            {
                this._SaveChanges = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p =>
                    {
                        _dbContext.SaveChanges();
                        _CustomersView.Refresh();
                    }
                };
                return this._SaveChanges;
            }
        }

        #endregion

        #region IDisposable members

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        #endregion
    }
 }
