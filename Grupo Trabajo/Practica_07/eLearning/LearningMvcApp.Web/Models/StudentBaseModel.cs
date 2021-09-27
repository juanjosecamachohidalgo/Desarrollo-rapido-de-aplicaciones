using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningClassLibrary.Data.Enums;

namespace LearningMvcApp.Web.Models
{
    public class StudentBaseModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int EnrollmentsCount { get; set; }
    }
}

