using School.Core.Features.Students.Commands.Models;
using School.Data.Entities;

namespace School.Core.Mapping.Students;

public partial class StudentProfile
{
    public void AddStudentCommadMapping()
    {
        CreateMap<AddStudentCommand, Student>()
            .ForMember(dest => dest.DepartmentId,
            opt => opt.MapFrom(src => src.DepartmentId));
    }
}
