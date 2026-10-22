using WestCoastEducation2.Models;
using WestCoastEducation2.Services;

CourseManager courseManager = new();
PersonManager personManager = new();

ClassroomCourse history = new("1", "History", 14,
    new DateTime(2026, 9, 1), new DateTime(2026, 9, 14), "A101");

    DistanceCourse math = new("2", "Math", 14,
    new DateTime(2026, 10, 1), new DateTime(2026, 10, 14), "https://example.com/meet");

Console.WriteLine(courseManager.AddCourse(history)); // True
Console.WriteLine(courseManager.AddCourse(history)); // False, dubblett
courseManager.AddCourse(math);
courseManager.ListCourses();

Student student = new("Findus", "Person", "031575819", "199001011234",
    "Långtorget 12", "45256", "Gothenburg");
Console.WriteLine(personManager.AddStudent(student)); // True
Console.WriteLine(personManager.AddStudent(student)); // False, dubblett
student.AddCourse(history);
student.AddCourse(history); // "Course already exists!"
personManager.ListStudents();

Teacher teacher = new("Neo", "Andersson", "031576890", "198001021234",
    "Linneagatan 4", "45351", "Gothenburg", "History");
Console.WriteLine(teacher.GetInfo()); // visar "none"
teacher.AddCourse(history);
Console.WriteLine(teacher.GetInfo()); // visar kursen

Console.WriteLine(personManager.AddTeacher(teacher));  // True
Console.WriteLine(personManager.AddTeacher(teacher));  // False, dubblett

EducationLeader leader = new("Pelle", "Svanslös", "031578090", "198805062012",
    "Backagatan 3", "43560", "Gothenburg", "Management",
    new DateTime(2012, 10, 2));
Console.WriteLine(personManager.AddEducationLeader(leader)); // True
Console.WriteLine(leader.GetInfo());

Admin admin = new("Gustav", "Svensson", "031570980", "197901035060",
    "Dahlströmsgatan 3", "43154", "Gothenburg", "Administration",
    new DateTime(2010, 11, 3));
Console.WriteLine(personManager.AddAdmin(admin)); // True
Console.WriteLine(admin.GetInfo());