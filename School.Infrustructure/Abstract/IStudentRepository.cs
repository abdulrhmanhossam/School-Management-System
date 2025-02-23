using School.Data.Entities;

namespace School.Infrustructure.Abstract;

public interface IStudentRepository
{
    Task<List<Student>> GetStudentsListAsync();
}
