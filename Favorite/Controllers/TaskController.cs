using favorite.Entitys;
using favorite.Interfacce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace favorite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepastory _taskRepastory;
        public TaskController(ITaskRepastory taskRepastory)
        {
            _taskRepastory = taskRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTasde() => Ok(await _taskRepastory.GetTasdeList());
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id) => Ok(await _taskRepastory.GetTasde(id));
        [HttpPost]
        public async Task<IActionResult> Create( Tasde tasde) => Ok(await _taskRepastory.Create(tasde));
        [HttpPut]
        public async Task<IActionResult> Update(int id, Tasde tasde) => Ok(await _taskRepastory.Update(id,tasde));
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _taskRepastory.Delete(id);
            return Ok();
        }
    }
}
