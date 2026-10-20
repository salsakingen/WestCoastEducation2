using System;

namespace WestCoastEducation2.Models;

public class Student : Person
{
    public List<Course> Courses { get; } = [];

    public Student(
        string firstName,
        string lastName,
        string phone,
        string personalNumber,
        string address,
        string postalCode,
        string city
    )
    : base(firstName, lastName, phone, personalNumber, address, postalCode, city)
    {

    }
    public void AddCourse(Course course)
    {
        foreach (Course existingCourse in Courses)
        {
            if (existingCourse.CourseNumber == course.CourseNumber)
            {
                Console.WriteLine("Course already exists!");
            }
            else
            {
                Courses.Add(course);
                Console.WriteLine("Course added successfully");
            }
        }
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Number of Courses: {Courses.Count}";
    }
}
