using School.Data.Entities;
using School.Infrustructure.Abstract;
using School.Service.Abstracts;

namespace School.Service.Implementations;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _studentRepository.GetStudentsListAsync();
    }
}
