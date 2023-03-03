using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MonthValueController : ControllerBase
    {
        private readonly IMonthValueService _service;

        public MonthValueController(IMonthValueService service)
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
        public async Task<IActionResult> Save([FromBody] MonthValueViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] MonthValueViewModel model)
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
        public async Task<IActionResult> UpdateMonthValueState(int id, int state)
        {
            return Ok(await _service.UpdateMonthValueState(id,state));
        }
        [HttpGet]
        public async Task<IActionResult> GetMonthValueForDashboard()
        {
            return Ok(await _service.GetMonthValueForDashboard());
        }
    }
}
