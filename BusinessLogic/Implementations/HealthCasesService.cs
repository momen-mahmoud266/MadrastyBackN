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
    public class HealthCasesService : IHealthCasesService
    {
        private readonly IDatabaseContext _db;

        public HealthCasesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> DeleteHealthCases(int healthCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(healthCasesId), healthCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteHealthCases", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetHealthCases()
        {
            var dalResponse = await _db.ExecuteQuery("GetHealthCases");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetHealthCasesWithId(int healthCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(healthCasesId), healthCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetHealthCasesWithId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveHealthCases(HealthCasesViewModel healthCases)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveHealthCases",
               _db.CreateListOfSqlParams(healthCases, new List<string>() { "HealthId", "HealthDetId", "OtherSituations", "Date" , "EffortResults", "EndYearState" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateHealthCases(HealthCasesViewModel healthCases)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateHealthCases",
               _db.CreateListOfSqlParams(healthCases, new List<string>() { "HealthDetId", "OtherSituations", "Date", "EffortResults", "EndYearState" }));

            return new ServiceResponse(dalResponse);
        }
 
     
        public async Task<ServiceResponse> DeleteHealthCasesDetails(int healthCasesDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(healthCasesDetailsId), healthCasesDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteHealthCasesDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetHealthCasesDetails()
        {
            var dalResponse = await _db.ExecuteQuery("GetHealthCasesDetails");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetHealthCasesDetailsWithId(int healthCasesDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(healthCasesDetailsId), healthCasesDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetHealthCasesDetailsWithId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveHealthCasesDetails(HealthCasesViewModel healthCasesDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveHealthCasesDetails",
               _db.CreateListOfSqlParams(healthCasesDetails, new List<string>() { 
                   "LevelId", 
                   "ClassId",
                   "ClassName",
                   "StudentId",
               "StudentName",
               "NationalityId",
               "Nationality",
               "PhoneNo",
               "BirthDate",
               "WorkStartDate",
               "DisStatus",
               "HealthRecomm",
               "YearEndState",
               "HealthDetId"}));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateHealthCasesDetails(HealthCasesViewModel healthCasesDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateHealthCasesDetails",
                _db.CreateListOfSqlParams(healthCasesDetails, new List<string>() {
                   "LevelId",
                   "ClassId",
                   "ClassName",
                   "StudentId",
               "StudentName",
               "NationalityId",
               "Nationality",
               "PhoneNo",
               "BirthDate",
               "WorkStartDate",
               "DisStatus",
               "HealthRecomm",
               "YearEndState",
               }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteHealthCasesDetailsWithHealthId(int healthCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(healthCasesId), healthCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteHealthCasesDetailsWithHealthId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetHealthCasesDetailsWithHealthId(int healthCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(healthCasesId), healthCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetHealthCasesDetailsWithHealthId", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
