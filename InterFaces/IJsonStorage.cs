using System;
using System.Runtime.InteropServices;

namespace WestCoastEducation2.InterFaces;

public interface IJsonStorage
{
    void SaveCourses(IEnumerable<Course>courses);
    List<Course> LoadCourses();

}
