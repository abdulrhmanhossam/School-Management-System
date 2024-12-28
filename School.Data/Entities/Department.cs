using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
            DepartmentSubjects = new HashSet<DepartmentSubject>();
        }

        [Key]
        public int DepartmentId {  get; set; }
        
        [StringLength(500)]
        public string DepartmentName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
    }
}
