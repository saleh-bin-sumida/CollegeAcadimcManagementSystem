namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IStudentRepository
{
    Task<BaseResponse<PagedResult<StudentDto>>> GetPagedStudents(
        int pageSize,
        int pageNumber,
        string? searchTerm);


    Task<BaseResponse<PagedResult<StudentDto>>> GetStudentsByDepartment(
        int departmentId,
        int pageSize,
        int pageNumber,
        string? searchTerm);

    Task<BaseResponse<PagedResult<StudentDto>>> GetStudentsByDepartmentStudyLevel(
        int departmentStudyLevelId,
        int pageSize,
        int pageNumber,
        string? searchTerm);


    Task<BaseResponse<StudentDto>> GetStudentById(int id);


    Task<BaseResponse<string>> AddStudentAsync(AddStudentDto studentDto);


    Task<BaseResponse<string>> UpdateStudentAsync(int id, UpdateStudentDto studentDto);



    Task<BaseResponse<string>> DeleteStudentAsync(int id);

}
