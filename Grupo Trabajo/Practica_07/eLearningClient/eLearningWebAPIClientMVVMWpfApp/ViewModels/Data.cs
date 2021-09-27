using eLearningWebAPIClientMVVMWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace eLearningWebAPIClientMVVMWpfApp.ViewModels
{
    public sealed class Data : ViewModelBase
    {
     
        private ICommand _searchCommand;
        private ICollectionView _CoursesView;
        private ICollectionView _StudentsView;
        private string _searchName = "";
        private ICommand _SaveChanges;
        private ICommand _AddCourse;
        private ICommand _DeleteCourse;
        private string _Panel1StatusBar;
        private string _Panel2StatusBar;

        public String Panel1StatusBar { get; set;}
        public String Panel2StatusBar{get;set;}
        private ObservableCollection<CourseModel> _CoursesCollection;
        public ObservableCollection<CourseModel> CoursesCollection
        {
            get
            {
                return _CoursesCollection;
            }
            set
            {
                _CoursesCollection = value;
                
            }
        }

        private ObservableCollection<StudentModel> _StudentsCollection;
        public ObservableCollection<StudentModel> StudentsCollection
        {
            get
            {
                return _StudentsCollection;
            }
            set
            {
                _StudentsCollection = value;
               
            }
        }
        public void StudentInCourse()
        {
            Console.WriteLine("Aqui entrad");
            HttpClient webClient = new HttpClient();
            webClient.BaseAddress = new Uri("http://localhost:55853/");
            webClient.DefaultRequestHeaders.Accept.Clear();
            webClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
           
            HttpResponseMessage response = webClient.GetAsync("api/courses/"+CurrentCourse.Id+"/students/").Result;
            if (response.IsSuccessStatusCode)
            {

                StudentsCollection = new ObservableCollection<StudentModel>(response.Content.ReadAsAsync<IEnumerable<StudentModel>>().Result);
                _StudentsView = CollectionViewSource.GetDefaultView(StudentsCollection);
                NotifyPropertyChanged("StudentsCollection");
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            
        }

        public Data()
        {
            HttpClient webClient = new HttpClient();
            webClient.BaseAddress = new Uri("http://localhost:55853/");
            webClient.DefaultRequestHeaders.Accept.Clear();
            webClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = webClient.GetAsync("api/courses").Result;
            if (response.IsSuccessStatusCode)
            {

                CoursesCollection = new ObservableCollection<CourseModel>(response.Content.ReadAsAsync<IEnumerable<CourseModel>>().Result);

                _CoursesView = CollectionViewSource.GetDefaultView(CoursesCollection);
                _CoursesView.CurrentChanged += (sender, e) =>
                {
                    NotifyPropertyChanged("CurrentCourse");
                    StudentInCourse();
                };


            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
           
        }

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


        public CourseModel CurrentCourse
        {
            get
            {
                if (_CoursesView == null)
                {
                    return new CourseModel();
                }
                else
                {
                    return _CoursesView.CurrentItem as CourseModel;
                }
            }
                      
        }
        private void Search()
        {
            _CoursesView.Filter = c => ((CourseModel)c).Name.Contains(SearchName) ||
            ((CourseModel)c).Description.Contains(SearchName);
            StudentInCourse();
        }
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


        public ICommand AddCourse
        {
            get
            {
                this._AddCourse = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p =>
                    {
                        var newCourse = new CourseModel();
                        newCourse.Name ="Curso de DRA";
                        newCourse.Url = "";
                        newCourse.Description = "Descripción del curso";
                        newCourse.Duration = 10;
                        newCourse.Subject = new SubjectModel();
                        newCourse.Subject.Id = 1;
                        newCourse.Tutor = new TutorModel();
                        newCourse.Tutor.Id = 1;
                       this.CoursesCollection.Add(newCourse);

                        HttpClient webClient = new HttpClient();
                        webClient.BaseAddress = new Uri("http://localhost:55853/");
                        // Add an Accept header for JSON format.
                        webClient.DefaultRequestHeaders.Add("Accept", "application/json");
                        webClient.DefaultRequestHeaders.Add("ContentType", "application/json");
                       
                        var response = webClient.PostAsJsonAsync("api/courses", newCourse).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Curso añadido");
                        }
                        else
                        {
                            MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                        }
                      
                        _CoursesView.Refresh();
                    }
                };
                return this._AddCourse;
            }
        }
        public ICommand DeleteCourse
        {
            get
            {
                this._DeleteCourse = new RelayCommand()
                {
                    CanExecuteDelegate = o => CurrentCourse != null,
                    ExecuteDelegate = o =>
                    {
                        if (CurrentCourse != null)
                        {
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri("http://localhost:55853/");
                            var id = CurrentCourse.Id;
                            var url = "api/courses/" + id;
                            HttpResponseMessage response = client.DeleteAsync(url).Result;
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Curso Borrado");
                            }
                            else
                            {
                                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                            }
                           
                            this.CoursesCollection.Remove(CurrentCourse as CourseModel);
                            _CoursesView.Refresh();
                        }
                    }
                };
                return this._DeleteCourse;
            }
        }
        public ICommand SaveChanges
        {
            get
            {
                this._SaveChanges = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p =>
                    {
                        // _dbContext.SaveChanges();
                        _CoursesView.Refresh();
                    }
                };
                return this._SaveChanges;
            }
        }


    }
}
