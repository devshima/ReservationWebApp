using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReservationWebApp.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        [DisplayName("姓")]
        public string LastName { get; set; }
        [DisplayName("名")]
        public string FirstName { get; set; }

    }
}