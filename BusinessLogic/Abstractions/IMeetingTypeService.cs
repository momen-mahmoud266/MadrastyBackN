using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IMeetingTypeService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int meetingTypeId);
        Task<ServiceResponse> Delete(int meetingTypeId);
        Task<ServiceResponse> Save(MeetingTypeViewModel meetingType);
        Task<ServiceResponse> Update(MeetingTypeViewModel meetingType);
    }
}
