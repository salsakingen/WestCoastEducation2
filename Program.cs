using System;
using WestCoastEducation2.Models;
using WestCoastEducation2.Services;

Console.WriteLine("=== WestCoast Education Test ===\n");

// Create managers
CourseManager courseManager = new CourseManager();
PersonManager personManager = new PersonManager();

// 1. Test adding a classroom course
Console.WriteLine("--- Test 1: Add Course ---");

Course course1 = new ClassroomCourse(
    "C001",
    "C# Programming",
    5,
    new DateTime(2026, 11, 2),
    new DateTime(2026, 11, 6),
    "Room 101"
);

if (courseManager.AddCourse(course1))
{
    Console.WriteLine("PASS: Course added successfully.");
}
else
{
    Console.WriteLine("FAIL: Could not add course.");
}

// 2. Test adding a duplicate course
Console.WriteLine("\n--- Test 2: Prevent Duplicate Course ---");

Course duplicateCourse = new ClassroomCourse(
    "C001",
    "Another C# Course",
    3,
    new DateTime(2026, 12, 1),
    new DateTime(2026, 12, 3),
    "Room 102"
);

if (!courseManager.AddCourse(duplicateCourse))
{
    Console.WriteLine("PASS: Duplicate course rejected.");
}
else
{
    Console.WriteLine("FAIL: Duplicate course was added.");
}

// 3. Test adding a student
Console.WriteLine("\n--- Test 3: Add Student ---");

Student student1 = new Student(
    "Anna",
    "Andersson",
    "0701234567",
    "TEST-STUDENT-001",
    "Main Street 1",
    "41101",
    "Gothenburg"
);

if (personManager.AddStudent(student1))
{
    Console.WriteLine("PASS: Student added successfully.");
}
else
{
    Console.WriteLine("FAIL: Could not add student.");
}

// Connect student to course
student1.AddCourse(course1);

Console.WriteLine("Student connected to course.");

// 4. Test preventing duplicate students
Console.WriteLine("\n--- Test 4: Prevent Duplicate Student ---");

Student duplicateStudent = new Student(
    "Anna",
    "Andersson",
    "0701234567",
    "TEST-STUDENT-001",
    "Main Street 1",
    "41101",
    "Gothenburg"
);

if (!personManager.AddStudent(duplicateStudent))
{
    Console.WriteLine("PASS: Duplicate student rejected.");
}
else
{
    Console.WriteLine("FAIL: Duplicate student was added.");
}

// 5. Test adding a teacher
Console.WriteLine("\n--- Test 5: Add Teacher ---");

Teacher teacher1 = new Teacher(
    "Erik",
    "Johansson",
    "0707654321",
    "TEST-TEACHER-001",
    "Teacher Street 2",
    "41102",
    "Gothenburg",
    "C# and .NET"
);

teacher1.AddCourse(course1);

Console.WriteLine("Teacher created and connected to course.");
Console.WriteLine(teacher1.GetInfo());

// 6. Test listing courses
Console.WriteLine("\n--- Test 6: List Courses ---");

courseManager.ListCourses();

// 7. Test listing students
Console.WriteLine("\n--- Test 7: List Students ---");

personManager.ListStudents();


Console.WriteLine("\n=== Tests Finished ===");