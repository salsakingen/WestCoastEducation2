using System;

namespace WestCoastEducation2.Models;

public class Teacher : Person
{
    public string KnowledgeArea { get; set; }
    public List<Course> ResponsibleCourses { get; } = [];

    public Teacher(
        string firstName,
        string lastName,
        string phone,
        string personalNumber,
        string address,
        string postalCode,
        string city,
        string knowledgeArea
    )
    : base(firstName, lastName, phone, personalNumber, address, postalCode, city)
    {
        KnowledgeArea = knowledgeArea;
    }

    public void AddCourse(Course course)
    {
        foreach (Course existingCourse in ResponsibleCourses)
        {
            if (existingCourse.CourseNumber == course.CourseNumber)
            {
                Console.WriteLine("Course already exists!");
            }
            else
            {
                ResponsibleCourses.Add(course);
                Console.WriteLine("Course added successfully");
            }
        }
    }
    public override string GetInfo()
    {
        return base.GetInfo() + $", KnowledgeArea: {KnowledgeArea}, + ResponibleCourses: {ResponsibleCourses}";
    }
}
