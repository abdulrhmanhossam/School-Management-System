using School.Core.Features.Students.Queries.Responses;
using School.Data.Entities;

namespace School.Core.Mapping.Students;

public partial class StudentProfile
{
    public void GetStudentByIdMapping()
    {

        CreateMap<Student, GetSingleStudentResponse>()
            .ForMember(dest => dest.DepartmentName, opt
            => opt.MapFrom(src => src.Department.DepartmentName));
    }
}
