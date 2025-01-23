using MediatR;
using School.Core.Features.Students.Queries.Responses;

namespace School.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<List<GetStudentListResponse>>
    {

    }
}
