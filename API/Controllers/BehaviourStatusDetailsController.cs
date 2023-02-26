using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BehaviourStatusDetailsController : ControllerBase
    {
        private readonly IBehaviourStatusDetailsService _service;

        public BehaviourStatusDetailsController(IBehaviourStatusDetailsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetByStudentId(int studentId)
        {
            var result = await _service.GetByStudentId(studentId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByBehaviourStatusId(int behaviourStatusId)
        {
            var result = await _service.GetByBehaviourStatusId(behaviourStatusId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BehaviourStatusDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] BehaviourStatusDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _service.Delete(id));
        }
    }
}
