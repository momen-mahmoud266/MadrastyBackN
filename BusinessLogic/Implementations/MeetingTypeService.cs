using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class MeetingTypeService : IMeetingTypeService
    {

        private readonly IDatabaseContext _db;

        public MeetingTypeService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> DeleteMeetingType(int meetingTypeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(meetingTypeId), meetingTypeId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteMeetingType", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetMeetingType()
        {
            var dalResponse = await _db.ExecuteQuery("GetMeetingType");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetMeetingTypeById(int meetingTypeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(meetingTypeId), meetingTypeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMeetingTypeById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveMeetingType(MeetingTypeViewModel meetingType)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveMeetingType",
               _db.CreateListOfSqlParams(meetingType, new List<string>() { "MeetingTypeId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateMeetingType(MeetingTypeViewModel meetingType)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateMeetingType",
               _db.CreateListOfSqlParams(meetingType, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
      
    }
}
