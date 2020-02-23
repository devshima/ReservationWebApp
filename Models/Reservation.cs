using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReservationWebApp.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        [DisplayName("予約日")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ReservationDate { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

}