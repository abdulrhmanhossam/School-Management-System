using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrustructure.Abstract;
using School.Infrustructure.Data;
using School.Infrustructure.InfrustructureBases;

namespace School.Infrustructure.Repositories;

public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
{
    private readonly DbSet<Student> _students;
    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
        _students = dbContext.Set<Student>();
    }
    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _students
            .Include(x => x.Department).ToListAsync();
    }
}
