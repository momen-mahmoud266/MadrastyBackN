using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
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
        public async Task<IActionResult> Post([FromBody] StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] StudentViewModel model)
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
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetByClassId(int id)
        {
            return Ok(await _service.GetByClassId(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetByGradeId(int id)
        {
            return Ok(await _service.GetByGradeId(id));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateStudentBranch(int studentId, int studentBranch)
        {
            return Ok(await _service.UpdateStudentBranch( studentId,  studentBranch));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateStudentClass(int studentId, int studentClassId, string studentClassName)
        {
            return Ok(await _service.UpdateStudentClass( studentId,  studentClassId,  studentClassName));
        }
        [HttpGet]
        public async Task<IActionResult> GetBranchStatistics()
        {
            return Ok(await _service.GetBranchStatistics());
        }
    }
}
