using System.ComponentModel.DataAnnotations;
namespace NETCoreDemo.DTOs;

using NETCoreDemo.Models;

public class StudentDTO : BaseDTO<Student>
{
    [MinLength(3)]
    public string FirstName { get; set; } = string.Empty;

    [MinLength(3)]
    public string LastName { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public AddressDTO Address { get; set; } = null!;

    public int CourseId { get; set; }

    public override void UpdateModel(Student model)
    {
        model.FirstName = FirstName;
        model.LastName = LastName;
        model.Email = Email;
        var address = new Address();
        Address.UpdateModel(address);
        model.Address = address;
        model.CourseId = CourseId;
    }
}