using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class AbsenceCaseService : IAbsenseCaseService
    {
        private readonly IDatabaseContext _db;

        public AbsenceCaseService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int absenceCaseId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absenceCaseId), absenceCaseId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAbsenceCase", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAbsenceCases");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int absenceCaseId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absenceCaseId), absenceCaseId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsenceCaseById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AbsenceCaseViewModel absenceCase)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAbsenceCase",
               _db.CreateListOfSqlParams(absenceCase, new List<string>() { "AbsenceCasesId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AbsenceCaseViewModel absenceCase)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAbsenceCase",
               _db.CreateListOfSqlParams(absenceCase, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
