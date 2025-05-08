namespace CollegeAcadimcManagementSystem.Core.Entites;

public class StudyLevel : IEntity, ISoftDeletable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public ICollection<DepartmentStudyLevel> DepartmentStudyLevels { get; set; } = new List<DepartmentStudyLevel>();
}
