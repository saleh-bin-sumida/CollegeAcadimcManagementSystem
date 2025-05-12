namespace CollegeAcadimcManagementSystem.Core.Entites;

public class DepartmentStudyLevel
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public int StudyLevelId { get; set; }
    public StudyLevel StudyLevel { get; set; }

    public ICollection<OfferedCourse> OfferedCourses { get; set; } = new List<OfferedCourse>();
}


