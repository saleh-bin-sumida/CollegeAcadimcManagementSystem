namespace CollegeAcadimcManagementSystem.Core.Entites;

public class StudentEnrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int DepartmentStudyLevelCourseId { get; set; }
    public DepartmentStudyLevelCourse DepartmentStudyLevelCourse { get; set; }
}
