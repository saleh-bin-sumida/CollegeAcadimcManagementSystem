//namespace CollegeAcadimcManagementSystem.API.Controllers;

//[ApiController]
//public class CoursesController(IUnitOfWork _unitOfWork, ILogger<CoursesController> _logger) : ControllerBase
//{
//    #region Get Methods

//    [HttpGet(SystemApiRouts.Courses.GetAll)]
//    [ProducesResponseType(typeof(BaseResponse<PagedResult<CourseDto>>), StatusCodes.Status200OK)]
//    public async Task<IActionResult> GetAllCourses(
//        int pageSize = 10,
//        int pageNumber = 1,
//        string? searchTerm = null)
//    {
//        var response = await _unitOfWork.Courses.GetPagedCourses(pageSize, pageNumber, searchTerm);
//        return Ok(response);
//    }

//    [HttpGet(SystemApiRouts.Courses.GetById)]
//    [ProducesResponseType(typeof(BaseResponse<CourseDto>), StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(BaseResponse<CourseDto>), StatusCodes.Status404NotFound)]
//    public async Task<IActionResult> GetCourseById(int id)
//    {
//        var response = await _unitOfWork.Courses.GetCourseById(id);
//        if (!response.Success)
//        {
//            _logger.LogWarning("Course with ID: {Id} not found", id);
//            return BadRequest(response);
//        }
//        return Ok(response);
//    }

//    #endregion

//    #region Post Methods

//    [HttpPost(SystemApiRouts.Courses.Add)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
//    public async Task<IActionResult> CreateCourse(AddCourseDto courseDto)
//    {
//        var response = await _unitOfWork.Courses.AddCourseAsync(courseDto);
//        if (!response.Success)
//        {
//            _logger.LogError("Failed to create course: {Errors}", response.Errors);
//            return BadRequest(response);
//        }
//        return Ok(response);
//    }

//    #endregion

//    #region Put Methods

//    [HttpPut(SystemApiRouts.Courses.Update)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
//    public async Task<IActionResult> UpdateCourse(int id, UpdateCourseDto courseDto)
//    {
//        var response = await _unitOfWork.Courses.UpdateCourseAsync(id, courseDto);
//        if (!response.Success)
//        {
//            _logger.LogError("Failed to update course with ID: {Id}", id);
//            return BadRequest(response);
//        }
//        return Ok(response);
//    }

//    #endregion

//    #region Delete Methods

//    [HttpDelete(SystemApiRouts.Courses.Delete)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
//    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status404NotFound)]
//    public async Task<IActionResult> DeleteCourse(int id)
//    {
//        var response = await _unitOfWork.Courses.DeleteCourseAsync(id);
//        if (!response.Success)
//        {
//            _logger.LogError("Failed to delete course with ID: {Id}", id);
//            return BadRequest(response);
//        }
//        return Ok(response);
//    }

//    #endregion
//}
