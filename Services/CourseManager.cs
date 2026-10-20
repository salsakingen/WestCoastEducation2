using System;
using WestCoastEducation2.Models;
namespace WestCoastEducation2.Services;

public class CourseManager
{
    private readonly List<Course> _courses = new();
    public IReadOnlyList<Course> Courses => _courses.AsReadOnly();

    public bool AddCourse(Course course)
    {
        if (string.IsNullOrWhiteSpace(course.CourseNumber) ||
        string.IsNullOrWhiteSpace(course.Title))
        {
            return false;
        }
        if (course.StartDate > course.EndDate ||
        course.DurationDays <= 0)
        {
            return false;
        }
        foreach (Course exstingCourse in _courses)
        {
            if (exstingCourse.CourseNumber == course.CourseNumber)
            {
                return false;
            }
        }

        _courses.Add(course);
        return true;
    }
    public void ListCourses()
    {
        if (_courses.Count == 0)
        {
            Console.WriteLine("Det finns inga kurser.");
            return;
        }
        foreach (Course course in _courses)
        {
            Console.WriteLine(course.GetInfo());
        }
    }
    public bool RemoveCourse(string courseNumber)
    {
        Course? course = _courses.FirstOrDefault(c => c.CourseNumber == courseNumber);

        if (course == null)
        {
            return false;
        }
        
        _courses.Remove(course);
        return true;
    }
}
