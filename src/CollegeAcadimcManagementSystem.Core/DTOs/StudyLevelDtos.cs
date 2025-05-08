namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class StudyLevelDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class AddStudyLevelDto
{
    public required string Name { get; set; }
}

public class UpdateStudyLevelDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
}
