namespace NETCoreDemo.Services;

using NETCoreDemo.Models;
using NETCoreDemo.DTOs;

public interface IStudentService : ICrudService<Student, StudentDTO>
{
    ICollection<Student> GetTopStudents();
    ICollection<Student> GetStudentsWithJobs();
    // TODO: Add and implement a method to load students by course
    // TODO: Add and implement a method to list students from a city
}