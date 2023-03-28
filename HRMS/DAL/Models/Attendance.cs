using HRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    internal class Attendance
    {
        public int AttendanceID { get; set; }
        public string Department { get; set; }
        public DateTime Date { get; set; }
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }
        public DateTime ActualStartTime { get; set; }
        public DateTime ActualEndTime { get; set; }
        public TimeSpan LateTime { get; set; }
        public TimeSpan EarlyLeaveTime { get; set; }
        public TimeSpan Overtime { get; set; }
        public string AttendanceStatus { get; set; }
        public string AttendanceNote { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
