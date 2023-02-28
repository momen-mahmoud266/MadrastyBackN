using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MentalityInquiriesController : ControllerBase
    {
        private readonly IMentalityInquiriesService _service;

        public MentalityInquiriesController(IMentalityInquiriesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentalityInquiries()
        {
            return Ok(await _service.GetMentalityInquiries());
        }

        [HttpGet]
        public async Task<IActionResult> GetByMentalityInquiriesId(int id)
        {
            return Ok(await _service.GetMentalityInquiriesById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveMentalityInquiries([FromBody] MentalityInquiriesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveMentalityInquiries(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentalityInquiries([FromBody] MentalityInquiriesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateMentalityInquiries(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMentalityInquiries(int id)
        {
            return Ok(await _service.DeleteMentalityInquiries(id));
        }
    }
}
