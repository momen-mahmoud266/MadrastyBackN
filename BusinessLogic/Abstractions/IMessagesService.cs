using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IMessagesViewModelService
    {
        Task<ServiceResponse> Save(MessagesViewModel messages);
        Task<ServiceResponse> SaveMessagesToEmpId(MessagesViewModel messages);
        Task<ServiceResponse> GetInbox(int id);
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> SaveMessagesFiles(MessagesViewModel messages);
        Task<ServiceResponse> GetMessageWithToId(int id);
        Task<ServiceResponse> GetMessagesEmailsToEmpIdWithMsgId(int id);
        Task<ServiceResponse> GetMessageWithToIdEmails(int id);
        Task<ServiceResponse> GetMessageWithToIdNoti(int id);
    }
}
