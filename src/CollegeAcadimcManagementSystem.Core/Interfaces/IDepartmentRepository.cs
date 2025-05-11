namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IDepartmentRepository : IBaseRepository<Department>
{
    Task<BaseResponse<PagedResult<DepartmentDto>>> GetPagedDepartments(int pageSize, int pageNumber, string? searchTerm = null);
    //Task<BaseResponse<DepartmentDto>> GetDepartmentsByCourse(int courseId);
    //Task<BaseResponse<DepartmentDto>> GetDepartmentsByStudyLevel(int studyLevelId);
    //Task<BaseResponse<DepartmentDto>> GetDepartmentByStudent(int studentId);
    //Task<BaseResponse<DepartmentDto>> GetDepartmentsByInstructor(int instructorId);
    Task<BaseResponse<DepartmentDto>> GetDepartmentById(int id);
    Task<BaseResponse<string>> AddDepartmentAsync(AddDepartmentDto departmentDto);
    Task<BaseResponse<string>> AddStudyLevelToDepartmentAsync(int departmentId, int studyLevelId);
    Task<BaseResponse<string>> UpdateDepartmentAsync(int id, UpdateDepartmentDto departmentDto);
    Task<BaseResponse<string>> DeleteDepartmentAsync(int id);
}
