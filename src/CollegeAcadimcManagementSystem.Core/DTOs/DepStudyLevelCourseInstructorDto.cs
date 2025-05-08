namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class DepStudyLevelCourseInstructorDto
{
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public string InstructorName { get; set; } // Combines FirstName and LastName
    public int DepStudyLevelCourseId { get; set; }
    public string CourseTitle { get; set; } // Title of the associated course
}
