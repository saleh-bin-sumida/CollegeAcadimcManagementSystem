namespace CollegeAcadimcManagementSystem.API.Controllers;

[ApiController]
public class CourseInstructorAssignmentsController(IUnitOfWork _unitOfWork) : ControllerBase
{


    [HttpGet(SystemApiRouts.CourseInstructorAssignments.Base)]
    public async Task<IActionResult> GetAll(int pageNumber = 1, int pageSize = 10)
    {
        var response = await _unitOfWork.CourseInstructorAssignments.GetAllAsync(pageNumber, pageSize);
        return Ok(response);
    }

    [HttpGet(SystemApiRouts.CourseInstructorAssignments.GetById)]
    public async Task<IActionResult> GetById(int id)
    {
        var response = await _unitOfWork.CourseInstructorAssignments.GetByIdAsync(id);
        return Ok(response);
    }

    [HttpGet(SystemApiRouts.CourseInstructorAssignments.GetbyInstructor)]
    public async Task<IActionResult> GetByInstructorId(int instructorId, int pageNumber = 1, int pageSize = 10)
    {
        var response = await _unitOfWork.CourseInstructorAssignments.GetByInstructorIdAsync(instructorId, pageNumber, pageSize);
        return Ok(response);
    }

    [HttpGet(SystemApiRouts.CourseInstructorAssignments.GetbyOfferedCourse)]
    public async Task<IActionResult> GetByOfferedCourseId(int offeredCourseId, int pageNumber = 1, int pageSize = 10)
    {
        var response = await _unitOfWork.CourseInstructorAssignments.GetByOfferedCourseIdAsync(offeredCourseId, pageNumber, pageSize);
        return Ok(response);
    }
}
