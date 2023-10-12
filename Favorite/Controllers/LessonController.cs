using favorite.Entitys;
using favorite.Interfacce;
using favorite.Repastory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace favorite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonRepastory _lessonRepastory;
        public LessonController(ILessonRepastory lessonRepastory)
        {
            _lessonRepastory = lessonRepastory;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLessons() => Ok(await _lessonRepastory.GetAllLesson());
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id) => Ok(await _lessonRepastory.GetById(id));

        [HttpPost]
        public async Task<IActionResult> CreateLesson(Lesson lesson) => Ok(await _lessonRepastory.CreateLesson(lesson));
        [HttpPut]
        public async Task<IActionResult> UpdateLesson(int id, Lesson lesson) => Ok(await _lessonRepastory.UpdateLesson(id, lesson));
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _lessonRepastory.DeleteLesson(id);
            return Ok();
        }
    }
}
