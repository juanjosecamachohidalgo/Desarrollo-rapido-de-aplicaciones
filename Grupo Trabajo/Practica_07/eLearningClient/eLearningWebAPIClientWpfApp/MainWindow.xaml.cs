using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Headers;
using eLearningWebAPIClientWpfApp.Models;
using Newtonsoft.Json;

namespace eLearningWebAPIClientWpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            HttpClient webClient = new HttpClient();
            webClient.BaseAddress = new Uri("http://localhost:55853/");

            webClient.DefaultRequestHeaders.Accept.Clear();
            webClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = webClient.GetAsync("api/courses").Result;

            if (response.IsSuccessStatusCode)
            {
                //var resultString = await response.Content.ReadAsStringAsync();
                //MessageBox.Show(resultString);
                //var courses = JsonConvert.DeserializeObject<IEnumerable<CourseModel>>(resultString);
                //courseDataGrid.ItemsSource = courses;


                var courses = response.Content.ReadAsAsync<IEnumerable<CourseModel>>().Result;
                //string s = "";
                //foreach(CourseModel course in courses)
                //{
                //    s = s + course.Tutor.FirstName + " - " + course.Subject.Name + "\n";
                //}
                //MessageBox.Show(s);
                courseDataGrid.ItemsSource = courses;


                //CourseModel course = await response.Content.ReadAsAsync<CourseModel>();
                //String message = String.Format("{0}\n{1}\n{2}", course.Id, course.Name, course.Description);
                //MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

        }

        private void addCourseButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient webClient = new HttpClient();
            webClient.BaseAddress = new Uri("http://localhost:55853/");

            // Add an Accept header for JSON format.
            //webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            webClient.DefaultRequestHeaders.Add("Accept", "application/json");
            webClient.DefaultRequestHeaders.Add("ContentType", "application/json");

            var newCourse = new CourseModel();
            newCourse.Name = nameTextBox.Text;
            newCourse.Url = "";
            newCourse.Description = descriptionTextBox.Text;
            newCourse.Duration = double.Parse(durationTextBox.Text);    // Convert.ToDouble(durationTextBox.Text);
            newCourse.Subject = new SubjectModel();
            newCourse.Subject.Id = int.Parse(subjectIDTextBox.Text);    // Convert.ToInt32(subjectIDTextBox.Text);
            newCourse.Tutor = new TutorModel();
            newCourse.Tutor.Id = int.Parse(tutorIDTextBox.Text);        // Convert.ToInt32(tutorIDTextBox.Text);
            //string newCourseJson = JsonConvert.SerializeObject(newCourse);
            //MessageBox.Show(newCourseJson);

            //string newCourseJson = "{\"name\":\"" + nameTextBox.Text + "\",";
            //newCourseJson += "\"duration\":" + durationTextBox.Text + ",";
            //newCourseJson += "\"description\":\"" + descriptionTextBox.Text + "\",";
            //newCourseJson += "\"subject\":{\"id\":" + subjectIDTextBox.Text + "},";
            //newCourseJson += "\"tutor\":{\"id\":" + tutorIDTextBox.Text + "}}";
            //var newCourse = JsonConvert.DeserializeObject<CourseModel>(newCourseJson);

            var response = webClient.PostAsJsonAsync("api/courses", newCourse).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Course Added");
                nameTextBox.Text = "";
                descriptionTextBox.Text = "";
                durationTextBox.Text = "";
                subjectIDTextBox.Text = "";
                tutorIDTextBox.Text = "";
                GetData();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient webClient = new HttpClient();
            webClient.BaseAddress = new Uri("http://localhost:55853/");

            webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var id = searchTextBox.Text.Trim();

            var url = "api/courses/" + id;

            HttpResponseMessage response = webClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var course = response.Content.ReadAsAsync<CourseModel>().Result;

                MessageBox.Show("Course Found:\n" + course.Name + "\n" + course.Description + "\n" + course.Duration);
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void showAllButton_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55853/");

            var id = deleteTextBox.Text.Trim();

            var url = "api/courses/" + id;

            HttpResponseMessage response = client.DeleteAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Course Deleted");
                GetData();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

    }
}
