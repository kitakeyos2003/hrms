using System;
using System.ComponentModel;

public class Employee
{
    public int EmployeeID { get; set; }
    [DisplayName("Employee")]
    public string FullName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public Department Department { get; set; }
    public Position Position { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Status { get; set; }
}
