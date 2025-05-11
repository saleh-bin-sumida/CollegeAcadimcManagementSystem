namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IDepartmentStudyLevelRepo
{
    Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetAllDepartmentStudyLevels();
    Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetDepartmentStudyLevelsByCourse(int courseId);
    Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetDepartmentStudyLevelsByStudyLevel(int studyLevelId);
    Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetDepartmentStudyLevelsByDepartment(int departmentId);
}

