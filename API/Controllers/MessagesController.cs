using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesViewModelService _service;
        public MessagesController(IMessagesViewModelService service)
        {
            _service = service;
   
        }
        [HttpGet]
        public async Task<IActionResult> GetInbox(int id)
        {
            return Ok(await _service.GetInbox(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] MessagesViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
        [HttpPost]
        public async Task<IActionResult> SaveMessagesToEmpId([FromBody] MessagesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveMessagesToEmpId(model));
            }
            return Ok(new ServiceResponse("Validation Error"));

        }
        [HttpPost]
        public async Task<IActionResult> SaveMessagesFiles([FromBody] MessagesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.SaveMessagesFiles(model));
            }
            return Ok(new ServiceResponse("Validation Error"));

        }
        [HttpGet]
        public async Task<IActionResult> GetMessageWithToId(int id)
        {
            return Ok(await _service.GetMessageWithToId(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetMessagesEmailsToEmpIdWithMsgId(int id)
        {

            
            return Ok(await _service.GetMessagesEmailsToEmpIdWithMsgId(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetMessageWithToIdEmails(int id)
        {

            var result = await _service.GetMessageWithToIdEmails(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetMessageWithToIdNoti(int id)
        {
            return Ok(await _service.GetMessageWithToIdNoti(id));
        }
    }
}
