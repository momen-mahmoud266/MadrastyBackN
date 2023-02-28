using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly IMaintenanceService _service;

        public MaintenanceController(IMaintenanceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetMaintenance()
        {
            return Ok(await _service.GetMaintenance());
        }

        [HttpGet]
        public async Task<IActionResult> GetMaintenanceById(int id)
        {
            return Ok(await _service.GetMaintenanceById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveMaintenance([FromBody] MaintenanceViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveMaintenance(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMaintenance([FromBody] MaintenanceViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateMaintenance(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMaintenance(int id)
        {
            return Ok(await _service.DeleteMaintenance(id));
        }
    }
}