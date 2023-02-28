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
    public class DivisionService : IDivisionService
    {
        private readonly IDatabaseContext _db;

        public DivisionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteDivision", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetDivisions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDeviionById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByEmployeeId(int employeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDevisionByEmployeeId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(DivisionViewModel devision)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveDivision",
               _db.CreateListOfSqlParams(devision, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(DivisionViewModel devision)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateDivision",
               _db.CreateListOfSqlParams(devision, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
