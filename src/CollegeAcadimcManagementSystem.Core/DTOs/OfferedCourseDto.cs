namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class OfferedCourseDto
{
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public string InstructorName { get; set; }
    public int DepStudyLevelCourseId { get; set; }
    public string CourseTitle { get; set; }
}
