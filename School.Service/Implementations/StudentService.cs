using Microsoft.EntityFrameworkCore;
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

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        var student = await _studentRepository
            .GetTableNoTracking()
            .Include(s => s.Department)
            .Where(s => s.StudentId == id)
            .FirstOrDefaultAsync();

        return student!;
    }

    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _studentRepository.GetStudentsListAsync();
    }

    public async Task<string> AddAsync(Student newStudent)
    {
        var dbStudent = _studentRepository
            .GetTableNoTracking()
            .Where(x => x.Name.Equals(newStudent.Name))
            .FirstOrDefault();

        if (dbStudent is not null)
            return "Exist";

        await _studentRepository.AddAsync(newStudent);
        await _studentRepository.SaveChangeAsync();

        return "Success";
    }
}
