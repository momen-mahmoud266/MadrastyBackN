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
    public class SchoolYearDataService : ISchoolYearDataService
    {

        private readonly IDatabaseContext _db;

        public SchoolYearDataService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int schoolYearDataId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(schoolYearDataId), schoolYearDataId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSchoolYearData", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSchoolYearDatas");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int schoolYearDataId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(schoolYearDataId), schoolYearDataId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSchoolYearDataById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SchoolYearDataViewModel schoolYearData)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSchoolYearData",
               _db.CreateListOfSqlParams(schoolYearData, new List<string>() { "SchoolYearDataId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SchoolYearDataViewModel schoolYearData)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSchoolYearData",
               _db.CreateListOfSqlParams(schoolYearData, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetSchoolYearDataForDropdown()
        {
            var dalResponse = await _db.ExecuteQuery("GetSchoolYearDataForDropdown");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> DeleteDetails(int schoolYearDataDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(schoolYearDataDetailsId), schoolYearDataDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSchoolYearDataDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetDetails()
        {
            var dalResponse = await _db.ExecuteQuery("GetSchoolYearDataDetailss");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetDetailsById(int schoolYearDataDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(schoolYearDataDetailsId), schoolYearDataDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSchoolYearDataDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveDetails(SchoolYearDataDetailsViewModel schoolYearDataDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSchoolYearDataDetails",
               _db.CreateListOfSqlParams(schoolYearDataDetails, new List<string>() { "SchoolYearDataDetailsId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateDetails(SchoolYearDataDetailsViewModel schoolYearDataDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSchoolYearDataDetails",
               _db.CreateListOfSqlParams(schoolYearDataDetails, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetDetailsByYearId(int schoolYearDataId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(schoolYearDataId), schoolYearDataId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDetailsByYearId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteDetailsByYear(int schoolYearDataId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(schoolYearDataId), schoolYearDataId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteDetailsByYear", pars);
            return new ServiceResponse(dalResponse);
        }

    }
}
