namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IStudentRepository Students { get; }
    Task<int> SaveAsync();

}

