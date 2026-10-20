using System;
using System.Runtime.InteropServices;
using WestCoastEducation2.InterFaces;


namespace WestCoastEducation2.Models;

public abstract class Course : IDisplayable
{
    public string CourseNumber { get; set; }
    public string Title { get; set; }
    public int DurationDays { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    protected Course(
        string courseNumber,
        string title,
        int durationDays,
        DateTime startDate,
        DateTime endDate
    )
    {
        CourseNumber = courseNumber;
        Title = title;
        DurationDays = durationDays;
        StartDate = startDate;
        EndDate = endDate;
    }

    public virtual string GetInfo()
    {
        return $"{CourseNumber}: {Title}, {DurationDays} days, {StartDate: 2012-08-10} - {EndDate: 2012-08-30}";
    }
    public override string ToString() => GetInfo();
}
