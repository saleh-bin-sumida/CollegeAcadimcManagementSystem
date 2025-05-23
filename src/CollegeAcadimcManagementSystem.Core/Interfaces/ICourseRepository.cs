namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface ICourseRepository : IBaseRepository<Course>
{
    Task<BaseResponse<PagedResult<CourseDto>>> GetPagedCourses(int pageSize, int pageNumber, string? searchTerm = null);
    Task<BaseResponse<IEnumerable<CourseDto>>> GetCoursesByDepartment(int departmentId);

    Task<BaseResponse<IEnumerable<CourseDto>>> GetCoursesByDepStudyLevel(int depStudyLevelId);
    Task<BaseResponse<IEnumerable<CourseDto>>> GetCoursesByInstrucotr(int instructorId);

    Task<BaseResponse<CourseDto>> GetCourseById(int id);
    Task<BaseResponse<string>> AddCourseAsync(AddCourseDto courseDto);
    Task<BaseResponse<string>> UpdateCourseAsync(int id, UpdateCourseDto courseDto);
    Task<BaseResponse<string>> DeleteCourseAsync(int id);
}
