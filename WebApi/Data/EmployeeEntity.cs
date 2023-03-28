using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data
{
    [Table("employee")]
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
