namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class DepartmentStudyLevelDto
{
    public int StudyLevelId { get; set; }
    public string StudyLevelName { get; set; }
}


public class AddStudyLevelToDepartmentDto
{
    public int DepartmentId { get; set; }
    public int StudyLevelId { get; set; }
}
