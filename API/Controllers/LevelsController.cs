using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        private readonly ILevelsService _service;

        public LevelsController(ILevelsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetLevels()
        {
            return Ok(await _service.GetLevels());
        }

        [HttpGet]
        public async Task<IActionResult> GetLevelsById(int id)
        {
            return Ok(await _service.GetLevelsById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveLevels([FromBody] LevelsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveLevels(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLevels([FromBody] LevelsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateLevels(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLevels(int id)
        {
            return Ok(await _service.DeleteLevels(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetLevelsStat()
        {
            return Ok(await _service.GetLevelsStat());
        }
    }
}
