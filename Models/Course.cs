using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReservationWebApp.Models
{
    public enum CourseType
    {
        A, B, C
    }
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public CourseType? CourseType { get; set; }
        [DisplayName("コース名")]
        public string Name { get; set; }
    }
}