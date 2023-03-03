using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Ta7dierMasterController : ControllerBase
    {
        private readonly ITa7dierMasterService _service;

        public Ta7dierMasterController(ITa7dierMasterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ta7dierMasterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Ta7dierMasterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _service.Delete(id));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateState(int ta7dierId, int state)
        {
            return Ok(await _service.UpdateState( ta7dierId,  state));
        }
        [HttpGet]
        public async Task<IActionResult> GetByDepId(int depId)
        {
            return Ok(await _service.GetById(depId));
        }
        [HttpGet]
        public async Task<IActionResult> GetForDashBoard(int empId)
        {
            return Ok(await _service.GetById(empId));
        }
        [HttpGet]
        public async Task<IActionResult> GetBySubjectId(int id)
        {
            return Ok(await _service.GetBySubjectId(id));
        }
    }
}
