using MediatR;
using School.Core.Bases;
using System.ComponentModel.DataAnnotations;

namespace School.Core.Features.Students.Commands.Models;

public class AddStudentCommand : IRequest<Response<string>>
{
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public int DepartmentId { get; set; }
}
