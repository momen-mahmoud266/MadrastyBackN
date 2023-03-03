using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HealthCasesController : ControllerBase
    {
        private readonly IHealthCasesService _service;
        public HealthCasesController(IHealthCasesService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] HealthCasesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
        [HttpPost]
        public async Task<IActionResult> SaveHealthCasesDetails([FromBody] HealthCasesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveHealthCasesDetails(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }
        [HttpGet]
        public async Task<IActionResult> GetHealthCasesDetails()
        {
          
            return Ok(await _service.GetHealthCasesDetails());
        }

        [HttpGet]
        public async Task<IActionResult> GetHealthCasesDetailsWithHealthId(int id)
        {
            return Ok(await _service.GetHealthCasesDetailsWithHealthId(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetHealthCasesDetailsWithId(int id)
        {
            var result = await _service.GetHealthCasesDetailsWithId(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetById(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] HealthCasesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
        [HttpPut]
        public async Task<IActionResult> update_HealthCases_details([FromBody] HealthCasesViewModel model)
        {
            var result = await _service.UpdateHealthCasesDetails(model);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.Delete(id);

            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHealthCasesDetails(int id)
        {
            var result = await _service.DeleteHealthCasesDetails(id);

            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHealthCasesDetailsWithHealthId(int id)
        {
            var result = await _service.DeleteHealthCasesDetailsWithHealthId(id);

            return Ok(result);
        }
    }
}
