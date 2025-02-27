using School.Data.Entities;
using School.Infrustructure.InfrustructureBases;

namespace School.Infrustructure.Abstract;

public interface IStudentRepository : IGenericRepositoryAsync<Student>
{
    Task<List<Student>> GetStudentsListAsync();
}
