using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElevenNote.WebAPI.Controllers{

    [Route("api/[controller]")]
    [ApiController]

    public class UserController: ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserServices service)
        {
            _service = service;
        }
    }

    [HttpPost("Register")]
    public async Task<IActionResult> await; RegisterUser([FromBody] UserRegister model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

    var registerResult = await _service.RegisterUserAsync(model);
    if (registerResult)
    {
        return Ok("User was registered.");
    }

    return BadRequest("User could not be registered");
    }
    
}