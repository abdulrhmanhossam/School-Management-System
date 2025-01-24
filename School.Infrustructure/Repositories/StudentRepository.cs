using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrustructure.Abstract;
using School.Infrustructure.Data;

namespace School.Infrustructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _dbContext;
        public StudentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _dbContext.Students.Include(x => x.Department).ToListAsync();
        }
    }
}
