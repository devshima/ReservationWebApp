using System;

namespace ReservationWebApp.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime ReservationDate { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

}