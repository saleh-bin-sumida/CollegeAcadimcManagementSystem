namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class CourseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string DepartmentStudyLevel { get; set; }
}

public class AddCourseDto
{
    public required string Title { get; set; }
    public int DepartmentStudyLevelId { get; set; }

}

public class UpdateCourseDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
}
