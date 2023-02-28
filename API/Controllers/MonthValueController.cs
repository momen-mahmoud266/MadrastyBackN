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
        public async Task<IActionResult> GetMonthValue()
        {
            return Ok(await _service.GetMonthValue());
        }

        [HttpGet]
        public async Task<IActionResult> GetByMonthValueId(int id)
        {
            return Ok(await _service.GetMonthValueWithId(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveMonthValue([FromBody] MonthValueViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveMonthValue(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMonthValue([FromBody] MonthValueViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateMonthValue(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMonthValue(int id)
        {
            return Ok(await _service.DeleteFromMonthValue(id));
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
