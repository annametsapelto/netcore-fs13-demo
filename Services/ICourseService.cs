namespace NETCoreDemo.Services;

using NETCoreDemo.Models;
using NETCoreDemo.DTOs;

public interface ICourseService : ICrudService<Course, CourseDTO>
{
    Task<ICollection<Course>> GetCoursesByStatusAsync(Course.CourseStatus status);
    // TODO: Add and implement a method to remove a student from a course
}