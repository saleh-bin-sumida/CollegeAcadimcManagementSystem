namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class DepartmentStudyLevelDto
{
    public string DepartmentName { get; set; }
    public string StudyLevelName { get; set; }
}


public class AddStudyLevelToDepartmentDto
{
    public int DepartmentId { get; set; }
    public int StudyLevelId { get; set; }
}
