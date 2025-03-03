using School.Data.Entities;

namespace School.Service.Abstracts;

public interface IStudentService
{
    Task<List<Student>> GetStudentsListAsync();
    Task<Student> GetStudentByIdAsync(int id);
    Task<string> AddAsync(Student newStudent);
}
