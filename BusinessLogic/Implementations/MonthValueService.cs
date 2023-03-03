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
    public class MonthValueService : IMonthValueService
    {
        private readonly IDatabaseContext _db;

        public MonthValueService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int monthValueId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(monthValueId), monthValueId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteMonthValue", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetMonthValue");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int monthValueId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(monthValueId), monthValueId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMonthValueWithId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(MonthValueViewModel monthValue)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveMonthValue",
               _db.CreateListOfSqlParams(monthValue, new List<string>() { "Ser" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(MonthValueViewModel monthValue)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateMonthValue",
               _db.CreateListOfSqlParams(monthValue, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
       
        public async Task<ServiceResponse> GetMonthValueForDashboard()
        {
            var dalResponse = await _db.ExecuteQuery("GetMonthValueForDashboard");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> UpdateMonthValueState(int monthValueId, int monthValueState)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(monthValueId), monthValueId.ToString());
            pars.Add(nameof(monthValueState), monthValueState.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMonthValuewithId", pars);
            return new ServiceResponse(dalResponse);
        }


    }
}
