namespace CollegeAcadimcManagementSystem.Core.Entites;

public class DepartmentStudyLevel
{
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public int StudyLevelId { get; set; }
    public StudyLevel StudyLevel { get; set; }

    //public ICollection<DepartmentStudyLevelCourse> DepartmentStudyLevelCourses { get; set; } = new List<DepartmentStudyLevelCourse>();

}


