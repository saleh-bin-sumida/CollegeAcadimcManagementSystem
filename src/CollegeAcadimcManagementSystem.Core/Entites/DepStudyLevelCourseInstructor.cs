namespace CollegeAcadimcManagementSystem.Core.Entites;

public class DepStudyLevelCourseInstructor
{
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; }

    public int DepStudyLevelCourseId { get; set; }
    public DepartmentStudyLevelCourse DepStudyLevelCourse { get; set; }
}
