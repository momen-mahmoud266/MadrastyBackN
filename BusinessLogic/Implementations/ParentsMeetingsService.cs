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
    public class ParentsMeetingsService : IParentsMeetingsService
    {

        private readonly IDatabaseContext _db;

        public ParentsMeetingsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteParentsMeeting", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetParentsMeetings");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetParentMeetingById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(ParentsMeetingsViewModel parentMeeting)
        {
            var dalResponse = await _db.ExecuteNonQuery("SvaeParentMeeting",
               _db.CreateListOfSqlParams(parentMeeting, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ParentsMeetingsViewModel parentMeeting)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateParentMeeting",
               _db.CreateListOfSqlParams(parentMeeting, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
