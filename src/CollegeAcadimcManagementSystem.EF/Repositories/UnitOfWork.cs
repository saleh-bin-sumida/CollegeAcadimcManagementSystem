﻿namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private readonly IServiceProvider _serviceProvider;

    private IStudentRepository? _studentRepository;
    private IInstructorsRepository? _instructorRepository;
    private IDepartmentRepository? _departmentRepository;
    private IStudyLevelRepository? _studyLevelRepository;
    private ICourseRepository? _courseRepository;
    private IDepartmentStudyLevelRepo? _departmentStudyLevelRepository;
    private IStudentEnrollmentRepository? _studentEnrollmentRepository;
    private ICourseInstructorAssignmentRepository? _courseInstructorAssignmentRepository;

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

    public IStudyLevelRepository StudyLevels => _studyLevelRepository ??=
        new StudyLevelRepository(_context, _serviceProvider.GetRequiredService<ILogger<StudyLevelRepository>>());

    public ICourseRepository Courses => _courseRepository ??=
        new CourseRepository(_context, _serviceProvider.GetRequiredService<ILogger<CourseRepository>>());

    public IDepartmentStudyLevelRepo DepartmentStudyLevels => _departmentStudyLevelRepository ??=
        new DepartmentStudyLevelRepo(_context, _serviceProvider.GetRequiredService<ILogger<DepartmentStudyLevelRepo>>());

    public IStudentEnrollmentRepository StudentEnrollments => _studentEnrollmentRepository ??=
        new StudentEnrollmentRepository(_context, _serviceProvider.GetRequiredService<ILogger<StudentEnrollmentRepository>>());

    public ICourseInstructorAssignmentRepository CourseInstructorAssignments => _courseInstructorAssignmentRepository ??=
        new CourseInstructorAssignmentRepository(_context, _serviceProvider.GetRequiredService<ILogger<CourseInstructorAssignmentRepository>>());

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}

