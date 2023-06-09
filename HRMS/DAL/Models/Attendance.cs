﻿using System;

public class Attendance
{
    public int AttendanceID { get; set; }
    public DateTime Date { get; set; }
    public DateTime ShiftStartTime { get; set; }
    public DateTime ShiftEndTime { get; set; }
    public DateTime ActualStartTime { get; set; }
    public DateTime ActualEndTime { get; set; }
    public int Overtime { get; set; }
    public int AttendanceStatus { get; set; }
    public string AttendanceNote { get; set; }
    public virtual Employee Employee { get; set; }
}