namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private readonly IServiceProvider _serviceProvider;

    private IStudentRepository? _studentRepository;
    private IInstructorsRepository? _instructorRepository;
    private IDepartmentRepository? _departmentRepository;

    public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
    }

    public IStudentRepository Students => _studentRepository ??=
        new StudentRepository(_context, _serviceProvider.GetRequiredService<ILogger<StudentRepository>>());

    public IInstructorsRepository Instructors => _instructorRepository ??=
        new InstructorRepository(_context, _serviceProvider.GetRequiredService<ILogger<InstructorRepository>>());

    public IDepartmentRepository Departments => _departmentRepository ??=
        new DepartmentRepository(_context, _serviceProvider.GetRequiredService<ILogger<DepartmentRepository>>());

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}

