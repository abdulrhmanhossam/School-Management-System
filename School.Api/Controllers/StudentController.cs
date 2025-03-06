using Microsoft.AspNetCore.Mvc;
using School.Api.Base;
using School.Core.Features.Students.Commands.Models;
using School.Core.Features.Students.Queries.Models;
using School.Data.AppMetaData;

namespace School.Api.Controllers;

[ApiController]
public class StudentController : AppControllerBase
{

    [HttpGet(Router.StudentRouting.List)]
    public async Task<IActionResult> GetStudentList()
    {
        return Ok(await Mediator
            .Send(new GetStudentListQuery()));
    }

    [HttpGet(Router.StudentRouting.GetById)]
    public async Task<IActionResult> GetStudentById([FromRoute] int id)
    {
        return NewResult(await Mediator
            .Send(new GetStudentByIdQuery(id)));
    }

    [HttpPost(Router.StudentRouting.Create)]
    public async Task<IActionResult> CreateStudent
        ([FromBody] AddStudentCommand studentCommand)
    {
        return NewResult(await Mediator
            .Send(studentCommand));
    }
}
