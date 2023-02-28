using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndividualCasesController : ControllerBase
    {
        private readonly IIndividualCasesService _service;

        public IndividualCasesController(IIndividualCasesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetIndividualCases()
        {
            return Ok(await _service.GetIndividualCases());
        }

        [HttpGet]
        public async Task<IActionResult> GetByIndividualCasesId(int id)
        {
            return Ok(await _service.GetByIndividualCasesId(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveIndividualCases([FromBody] IndividualCasesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveIndividualCases(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateIndividualCases([FromBody] IndividualCasesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateIndividualCases(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteIndividualCases(int id)
        {
            return Ok(await _service.DeleteIndividualCases(id));
        }
    }
}
