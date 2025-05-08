namespace CollegeAcadimcManagementSystem.Core.Entites;

public class StudentEnrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int DepartmentStudyLevelId { get; set; }
    public DepartmentStudyLevel DepartmentStudyLevel { get; set; }
}
