namespace CollegeAcadimcManagementSystem.API.Controllers
{
    [ApiController]
    [Route(SystemApiRouts.StudentEnrollments.Base)]
    public class StudentEnrollmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentEnrollmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(SystemApiRouts.StudentEnrollments.GetByStudent)]
        public IActionResult GetByStudentId(int studentId)
        {
            var response = _unitOfWork.StudentEnrollments.GetByStudentId(studentId);
            return Ok(response);
        }

        [HttpGet(SystemApiRouts.StudentEnrollments.GetByDepStudyLevel)]
        public IActionResult GetByDepStudyLevelId(int depStudyLevelId)
        {
            var response = _unitOfWork.StudentEnrollments.GetByDepStudyLevelId(depStudyLevelId);
            return Ok(response);
        }

        [HttpGet(SystemApiRouts.StudentEnrollments.GetByOfferedCourse)]
        public IActionResult GetByOfferedCourseId(int offeredCourseId)
        {
            var response = _unitOfWork.StudentEnrollments.GetByOfferedCourseId(offeredCourseId);
            return Ok(response);
        }
    }
}
