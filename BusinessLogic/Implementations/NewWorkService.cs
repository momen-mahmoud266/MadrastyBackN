using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;

namespace BusinessLogic.Implementations
{
    public class NewWorkService : INewWorkService
    {
        private readonly IDatabaseContext _db;

        public NewWorkService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteNewWork", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetNewWorks");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetNewWorkById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(NewWorkViewModel newWork)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveNewWork",
               _db.CreateListOfSqlParams(newWork, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(NewWorkViewModel newWork)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateNewWork",
               _db.CreateListOfSqlParams(newWork, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
