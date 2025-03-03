﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Students.Commands.Models;
using School.Core.Features.Students.Queries.Models;
using School.Data.AppMetaData;

namespace School.Api.Controllers;

[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Router.StudentRouting.List)]
    public async Task<IActionResult> GetStudentList()
    {
        var response = await _mediator
            .Send(new GetStudentListQuery());
        return Ok(response);
    }

    [HttpGet(Router.StudentRouting.GetById)]
    public async Task<IActionResult> GetStudentById([FromRoute] int id)
    {
        var response = await _mediator
            .Send(new GetStudentByIdQuery(id));
        return Ok(response);
    }

    [HttpPost(Router.StudentRouting.Create)]
    public async Task<IActionResult> CreateStudent
        ([FromBody] AddStudentCommand studentCommand)
    {
        var response = await _mediator
            .Send(studentCommand);
        return Ok(response);
    }
}
