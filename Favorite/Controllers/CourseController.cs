using favorite.Entitys;
using favorite.Interfacce;
using favorite.Repastory;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace favorite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepastory _courseRepastory;
        public CourseController(ICourseRepastory courseRepastory)
        {
            _courseRepastory = courseRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourseAsync() => Ok(await _courseRepastory.GetAllCourses());
        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsync(int id) => Ok(await _courseRepastory.GetByid(id));

        [HttpPost]
        public async Task<IActionResult> CreateUser(Course course) => Ok(await _courseRepastory.CreataCourse(course));
        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, Course course) => Ok(await _courseRepastory.UpdateCourse(id,course));
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _courseRepastory.DeleteCourse(id);
            return Ok();
        }








    }
}
