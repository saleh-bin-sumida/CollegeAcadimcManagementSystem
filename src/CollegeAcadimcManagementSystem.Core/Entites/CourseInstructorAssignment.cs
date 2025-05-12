namespace CollegeAcadimcManagementSystem.Core.Entites;

public class CourseInstructorAssignment
{
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; }
    public DateOnly Date { get; set; }
    public int OfferedCourseId { get; set; }
    public OfferedCourse OfferedCourse { get; set; }
}
