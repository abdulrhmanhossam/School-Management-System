using AutoMapper;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Students.Queries.Responses;
using School.Service.Abstracts;

namespace School.Core.Features.Students.Queries.Handlers;

public class StudentHandler : 
    ResponseHandler,
    IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
    IRequestHandler<GetStudentByIdQuery, Response<GetSingleStudentResponse>>

{
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;

    public StudentHandler(IStudentService studentService, IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }

    public async Task<Response<List<GetStudentListResponse>>> Handle
        (GetStudentListQuery request, CancellationToken cancellationToken)
    {
        var studentList = await _studentService
            .GetStudentsListAsync();
        var studentListMapper = _mapper
            .Map<List<GetStudentListResponse>>(studentList);
        return Success(studentListMapper);
    }

    public async Task<Response<GetSingleStudentResponse>> Handle
        (GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        var student = await _studentService
            .GetStudentByIdAsync(request.Id);

        if (student is null)
            return NotFound<GetSingleStudentResponse>();

        var studentMapper = _mapper
            .Map<GetSingleStudentResponse>(student);

        return Success(studentMapper);
    }
}
