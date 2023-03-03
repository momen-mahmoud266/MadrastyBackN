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
    public class IndividualCasesService : IIndividualCasesService
    {
        private readonly IDatabaseContext _db;

        public IndividualCasesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int individualCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(individualCasesId), individualCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteIndividualCases", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetIndividualCases");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int individualCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(individualCasesId), individualCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetIndividualCasesById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(IndividualCasesViewModel individualCases)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveIndividualCases",
              _db.CreateListOfSqlParams(individualCases, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(IndividualCasesViewModel individualCases)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateIndividualCases",
               _db.CreateListOfSqlParams(individualCases, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
