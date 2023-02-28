using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeUserPriviligeController : ControllerBase
    {
        private readonly IEmployeeeUserPrivilige _service;

        public EmployeeUserPriviligeController(IEmployeeeUserPrivilige service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet]
        public async Task<IActionResult> GetByEmployeeId(int employeeId)
        {
            return Ok(await _service.GetByEmployeeId(employeeId));
        }
        [HttpGet]
        public async Task<IActionResult> GetBySubjectId(int employeeId, string route)
        {
            return Ok(await _service.GetMenusRouteFromEmployeePriviligeByRoute(employeeId,route));
        }
        [HttpGet]
        public async Task<IActionResult> GetBySubjectIdAndValidation(int employeeId )
        {
            return Ok(await _service.GetMenusRoutesFromEmployeePrivilige(employeeId));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] EmployeeUserPriviligeViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EmployeeUserPriviligeViewModel model)
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
