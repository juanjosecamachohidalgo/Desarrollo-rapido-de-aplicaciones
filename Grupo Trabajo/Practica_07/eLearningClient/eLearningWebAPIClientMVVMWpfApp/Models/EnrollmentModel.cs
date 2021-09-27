using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearningWebAPIClientMVVMWpfApp.Models
{
    public class EnrollmentModel
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public CourseModel Tutor { get; set; }
        public SubjectModel Subject { get; set; }
    }
}
