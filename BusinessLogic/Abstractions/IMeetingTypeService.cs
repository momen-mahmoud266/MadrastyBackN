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
        Task<ServiceResponse> GetMeetingType();
        Task<ServiceResponse> GetMeetingTypeById(int meetingTypeId);
        Task<ServiceResponse> DeleteMeetingType(int meetingTypeId);
        Task<ServiceResponse> SaveMeetingType(MeetingTypeViewModel meetingType);
        Task<ServiceResponse> UpdateMeetingType(MeetingTypeViewModel meetingType);
    }
}
