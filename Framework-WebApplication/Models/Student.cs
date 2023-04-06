using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Framework_WebApplication.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter student name")]
        [Display(Name = "Name")]
        public string name { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
    }
}