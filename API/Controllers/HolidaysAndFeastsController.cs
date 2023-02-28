using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HolidaysAndFeastsController : ControllerBase
    {
        private readonly IHolidaysAndFeastsService _service;

        public HolidaysAndFeastsController(IHolidaysAndFeastsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetHolidaysAndFeasts()
        {
            return Ok(await _service.GetHolidaysAndFeasts());
        }

        [HttpGet]
        public async Task<IActionResult> GetHolidaysAndFeastsById(int id)
        {
            return Ok(await _service.GetHolidaysAndFeastsById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveHolidaysAndFeasts([FromBody] HolidaysAndFeastsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveHolidaysAndFeasts(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHolidaysAndFeasts([FromBody] HolidaysAndFeastsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateHolidaysAndFeasts(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHolidaysAndFeasts(int id)
        {
            return Ok(await _service.DeleteHolidaysAndFeasts(id));
        }
    }
}
