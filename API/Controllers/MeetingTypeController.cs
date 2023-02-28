using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MeetingTypeController : ControllerBase
    {
        private readonly IMeetingTypeService _service;

        public MeetingTypeController(IMeetingTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetMeetingType()
        {
            return Ok(await _service.GetMeetingType());
        }

        [HttpGet]
        public async Task<IActionResult> GetMeetingTypeById(int id)
        {
            return Ok(await _service.GetMeetingTypeById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveMeetingType([FromBody] MeetingTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveMeetingType(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMeetingType([FromBody] MeetingTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateMeetingType(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMeetingType(int id)
        {
            return Ok(await _service.DeleteMeetingType(id));
        }
    }
}
