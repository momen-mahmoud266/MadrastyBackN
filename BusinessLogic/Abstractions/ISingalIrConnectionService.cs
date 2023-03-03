using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISingalIrConnectionService
    {
        Task<ServiceResponse> SendNotifications(SingalIrConnectionViewModel signalIRConnection);
        Task<ServiceResponse> SendNotificationsEmails(SingalIrConnectionViewModel signalIRConnection);
        Task<ServiceResponse> Save(int connectionId);
        Task<ServiceResponse> Get();
      
        Task<ServiceResponse> Delete(int connectionId);
      
      
    }
}
