using AutoMapper;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Commands.Models;
using School.Data.Entities;
using School.Service.Abstracts;

namespace School.Core.Features.Students.Commands.Handlers;

public class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
{
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;

    public StudentCommandHandler(IStudentService studentService, IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle
        (AddStudentCommand request, CancellationToken cancellationToken)
    {
        var studentMapper = _mapper.Map<Student>(request);

        var result = await _studentService.AddAsync(studentMapper);

        if (result == "Exist")
            return UnprocessableEntity<string>("Name is Exist");
        else if (result == "Success")
            return Created("Added Successfully");
        else
            return BadRequest<string>();
    }
}
