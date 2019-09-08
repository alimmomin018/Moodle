using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Models
{
    public class Schedule
    {
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public string Time { get; set; }
        public string RoomNumber { get; set; }
        public string Professor { get; set; }
        public string Date { get; set; }
    }
}
