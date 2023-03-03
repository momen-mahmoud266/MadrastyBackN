using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SignalIrConnectionController : ControllerBase
    {
        private readonly ISingalIrConnectionService _service;

        public SignalIrConnectionController(ISingalIrConnectionService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> SendNotifications([FromBody] SingalIrConnectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SendNotifications(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
        [HttpPost]
        public async Task<IActionResult> SendNotificationsEmails([FromBody] SingalIrConnectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SendNotificationsEmails(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.Save(id));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _service.Delete(id));
        }
    }
}
