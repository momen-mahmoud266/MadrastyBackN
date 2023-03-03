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
    public class TakeemMasterService : ITakeemMasterService
    {
        private readonly IDatabaseContext _db;

        public TakeemMasterService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int takeemMasterId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(takeemMasterId), takeemMasterId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTakeemMaster", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetTakeemMasters");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int takeemMasterId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(takeemMasterId), takeemMasterId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTakeemMasterById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TakeemMasterViewModel takeemMaster)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTakeemMaster",
               _db.CreateListOfSqlParams(takeemMaster, new List<string>() { "TakeemMasterId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(TakeemMasterViewModel takeemMaster)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTakeemMaster",
               _db.CreateListOfSqlParams(takeemMaster, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        //////////
       

        public async Task<ServiceResponse> DeleteDetails(int takeemMasterDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(takeemMasterDetailsId), takeemMasterDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTakeemMasterDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetDetails()
        {
            var dalResponse = await _db.ExecuteQuery("GetTakeemMasterDetailss");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetDetailsById(int takeemMasterDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(takeemMasterDetailsId), takeemMasterDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTakeemMasterDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveDetails(TakeemMasterDetailsViewModel takeemMasterDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTakeemMasterDetails",
               _db.CreateListOfSqlParams(takeemMasterDetails, new List<string>() { "TakeemMasterDetailsId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateDetails(TakeemMasterDetailsViewModel takeemMasterDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTakeemMasterDetails",
               _db.CreateListOfSqlParams(takeemMasterDetails, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetDetailsByTakeemId(int takeemMasterId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(takeemMasterId), takeemMasterId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDetailsByTakeemId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetEvaluationWithEvaluationSubject(int EvaluationSubjectId, string EvaluationDate)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(EvaluationSubjectId), EvaluationSubjectId.ToString());
            pars.Add(nameof(EvaluationDate), EvaluationDate.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEvaluationWithEvaluationSubject", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
