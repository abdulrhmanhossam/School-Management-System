﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int DepartmentSubjectId { get; set; }
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subjects { get; set; }
    }
}
