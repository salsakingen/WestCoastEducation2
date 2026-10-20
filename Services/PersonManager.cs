using System;
using WestCoastEducation2.Models;
namespace WestCoastEducation2.Services;

public class PersonManager
{
    private readonly List<Student> _student = [];
    private readonly List<Teacher> _teacher = [];
    private readonly List<EducationLeader> _leaders = [];
    private readonly List<Admin> _admin = [];

    public bool AddStudent(Student student)
    {
        foreach (Student existingStudent in _student)
        {
            if (existingStudent.PersonalNumber == student.PersonalNumber)
            {
                return false;
            }
        }

        _student.Add(student);
        return true;
    }

    public bool AddTeacher(Teacher teacher)
    {
        foreach (Teacher existingTeacher in _teacher)
        {
            if (existingTeacher.PersonalNumber == teacher.PersonalNumber)
            {
                return false;
            }
        }

        _teacher.Add(teacher);
        return true;
    }

    public bool AddEducationLeader(EducationLeader leader)
    {
        foreach (EducationLeader existingLeader in _leaders)
        {
            if (existingLeader.PersonalNumber == leader.PersonalNumber)
            {
                return false;
            }
        }

        _leaders.Add(leader);
        return true;
    }

    public bool AddAdmin(Admin admin)
    {
        foreach (Admin existingAdmin in _admin)
        {
            if (existingAdmin.PersonalNumber == admin.PersonalNumber)
            {
                return false;
            }
        }

        _admin.Add(admin);
        return true;
    }

public void ListStudents()
    {
        if (_student.Count == 0)
        {
            Console.WriteLine("There is no Students");
            return;
        }
        foreach (Student student in _student)
        {
            Console.WriteLine(student.GetInfo());
        }
    }
}
