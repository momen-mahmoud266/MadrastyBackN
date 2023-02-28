using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstructionsController : ControllerBase
    {
        private readonly IInstructionsService _service;

        public InstructionsController(IInstructionsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetInstructions()
        {
            return Ok(await _service.GetInstructions());
        }

        [HttpGet]
        public async Task<IActionResult> GetInstructionsById(int id)
        {
            return Ok(await _service.GetInstructionsById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveInstructions([FromBody] InstructionsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveInstructions(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateInstructions([FromBody] InstructionsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateInstructions(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteInstructions(int id)
        {
            return Ok(await _service.DeleteInstructions(id));
        }
    }
}
