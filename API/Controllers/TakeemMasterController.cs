﻿using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TakeemMasterController : ControllerBase
    {
        private readonly ITakeemMasterService _service;

        public TakeemMasterController(ITakeemMasterService service)
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
        public async Task<IActionResult> Post([FromBody] TakeemMasterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TakeemMasterViewModel model)
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
        public async Task<IActionResult> GetDetails()
        {
            return Ok(await _service.GetDetails());
        }

        [HttpGet]
        public async Task<IActionResult> GetDetailsById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> PostDetails([FromBody] TakeemMasterDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveDetails(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> PutDetails([FromBody] TakeemMasterDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.UpdateDetails(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDetails(int id)
        {
            return Ok(await _service.DeleteDetails(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetDetailsByTakeemId(int id)
        {
            return Ok(await _service.GetDetailsByTakeemId(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetEvaluationWithEvaluationSubject(int EvaluationSubjectId, string EvaluationDate)
        {
            return Ok(await _service.GetEvaluationWithEvaluationSubject( EvaluationSubjectId,  EvaluationDate));
        }
    }
}
