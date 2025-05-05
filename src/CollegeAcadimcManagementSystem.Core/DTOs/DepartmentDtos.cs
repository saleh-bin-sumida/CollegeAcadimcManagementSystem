namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class DepartmentDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class AddDepartmentDto
{
    public required string Name { get; set; }
    public string Description { get; set; }
}

public class UpdateDepartmentDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; }
}
