namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IDepartmentRepository : IBaseRepository<Department>
{
    Task<BaseResponse<PagedResult<DepartmentDto>>> GetPagedDepartments(int pageSize, int pageNumber, string? searchTerm = null);
    Task<BaseResponse<DepartmentDto>> GetDepartmentById(int id);
    Task<BaseResponse<string>> AddDepartmentAsync(AddDepartmentDto departmentDto);
    Task<BaseResponse<string>> UpdateDepartmentAsync(int id, UpdateDepartmentDto departmentDto);
    Task<BaseResponse<string>> DeleteDepartmentAsync(int id);
    Task<BaseResponse<string>> AddStudyLevelToDepartmentAsync(int departmentId, int studyLevelId);
    Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetStudyLevelsInDepartmentAsync(int departmentId);
}
