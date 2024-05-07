using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using u20530545_HW01_API.Models;
using u20530545_HW01_API.Interface;
using Microsoft.Extensions.Configuration;

namespace u20530545_HW01_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // Initialize Repo
        private readonly ICourseRepo _courseRepo;
        private readonly IConfiguration _configuration;
        public CourseController(ICourseRepo courseRepo, IConfiguration configuration)
        {
            _courseRepo = courseRepo;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("getAllCourses")]
        public async Task<IActionResult> GetAllCourses()
        {
            try
            {
                return Ok(await _courseRepo.GetAllCourses());
            }
            catch (Exception ex)
            {
                // Notify  Admins
                return BadRequest("An Error Occoured , Please Try Again Later");
            }
        }


        [HttpGet]
        [Route("getAllCourses/{courseId}")]
        public async Task<IActionResult> GetCourse(int courseId)
        {
            try
            {
                var course = await _courseRepo.GetCourse(courseId);
                if (course == null)
                {
                    return NotFound("Not able to locate course ");
                }
                return Ok(course);
            }
            catch (Exception ex)
            {
                // Notify  Admins
                return BadRequest("An Error Occoured , Please Try Again Later");
            }
        }


        [HttpPost]
        [Route("addCourse")]
        public async Task<IActionResult> AddCourse([FromBody] Course courseSchool)
        {
            try
            {
                var message = "Successfully Added School Coursse";
                var added = await _courseRepo.AddCourse(courseSchool);
                if (!added)
                {
                    message = "Received Data but Failed to Add ";
                }
                return Ok(message);
            }
            catch (Exception ex)
            {
                // Notify  Admins
                return BadRequest("An Error Occoured , Please Try Again Later");
            }
        }

        [HttpPost]
        [Route("updateCourse")]
        public async Task<IActionResult> updateCourse([FromBody] Course courseSchool)
        {
            try
            {
                var message = "Successfully Updated School Course";
                var added = await _courseRepo.UpdateCourse(courseSchool);
                if (!added)
                {
                    message = "Received Data but Failed to Update";
                }
                return Ok(message);
            }
            catch (Exception ex)
            {
                // Notify  Admins
                return BadRequest("An Error Occoured , Please Try Again Later");
            }
        }


        [HttpDelete]
        [Route("deleteCourse/{courseId}")]
        public async Task<IActionResult> deleteCourse(int courseId)
        {
            try
            {
                var message = "Successfully Delete School Course";
                var added = await _courseRepo.DeleteCourse(courseId);
                if (!added)
                {
                    message = "Received Data but Failed to Delete";
                }
                return Ok(message);
            }
            catch (Exception ex)
            {
                // Notify  Admins
                return BadRequest("An Error Occoured , Please Try Again Later");
            }
        }
    }
}
