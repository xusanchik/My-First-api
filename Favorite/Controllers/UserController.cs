using favorite.Entitys;
using favorite.Interfacce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace favorite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepastory _userRepastory;
        public UserController(IUserRepastory userRepastory)
        {
            _userRepastory = userRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers() => Ok(await _userRepastory.GetAllUers());
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id) => Ok(await _userRepastory.GetById(id));
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user) => Ok(await _userRepastory.CereateUser(user));
        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, User user) => Ok(await _userRepastory.UpdeteUser(id, user));
        [HttpDelete]
        public async Task<IActionResult> DeleteUser (int id)
        {
            await _userRepastory.DeleteUser(id);
            return Ok();
        }



    }
}
