using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(500)]
        public string Address { get; set; }
        
        [StringLength(500)]
        public string Phone { get; set; }

        public int? DepartmentId {  get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

    }
}
