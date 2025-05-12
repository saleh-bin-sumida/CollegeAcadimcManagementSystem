
namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IStudentEnrollmentRepository
{
    BaseResponse<List<StudentEnrollmentDto>> GetByStudentId(int studentId);

    BaseResponse<List<StudentEnrollmentDto>> GetByDepStudyLevelId(int depStudyLevelId);
    BaseResponse<List<StudentEnrollmentDto>> GetByOfferedCourseId(int offeredCourseId);
}
