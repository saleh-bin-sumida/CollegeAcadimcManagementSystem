namespace CollegeAcadimcManagementSystem.Core.DTOs;

public class InstructorDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

public class AddInstructorDto
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public required string PhoneNumber { get; set; }
}

public class UpdateInstructorDto
{
    public int Id { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public required string PhoneNumber { get; set; }
}
