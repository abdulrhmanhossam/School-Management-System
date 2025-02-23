﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Students.Queries.Models;

namespace School.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("/student/list")]
    public async Task<IActionResult> GetStudentList()
    {
        var response = await _mediator.Send(new GetStudentListQuery());
        return Ok(response);
    }
}
