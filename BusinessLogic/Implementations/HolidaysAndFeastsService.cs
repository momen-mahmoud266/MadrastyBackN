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
    public class HolidaysAndFeastsService : IHolidaysAndFeastsService
    {
        private readonly IDatabaseContext _db;

        public HolidaysAndFeastsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> DeleteHolidaysAndFeasts(int holidaysAndFeastsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(holidaysAndFeastsId), holidaysAndFeastsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteHolidaysAndFeasts", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetHolidaysAndFeasts()
        {
            var dalResponse = await _db.ExecuteQuery("GetHolidaysAndFeasts");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetHolidaysAndFeastsById(int holidaysAndFeastsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(holidaysAndFeastsId), holidaysAndFeastsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetHolidaysAndFeastsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveHolidaysAndFeasts(HolidaysAndFeastsViewModel holidaysAndFeasts)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveHolidaysAndFeasts",
               _db.CreateListOfSqlParams(holidaysAndFeasts, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateHolidaysAndFeasts(HolidaysAndFeastsViewModel holidaysAndFeasts)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateHolidaysAndFeasts",
               _db.CreateListOfSqlParams(holidaysAndFeasts, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetHolidaysAndFeastsStat()
        {
            var dalResponse = await _db.ExecuteQuery("GetHolidaysAndFeastsStat");
            return new ServiceResponse(dalResponse);
        }
    }
}
