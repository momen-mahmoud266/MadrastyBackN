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
    public class AbsenceService : IAbsenceService
    {
        private readonly IDatabaseContext _db;

        public AbsenceService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int absenceId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absenceId), absenceId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAbsence", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAbsence");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int absenceId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absenceId), absenceId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsenceById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AbsenceViewModel absence)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAbsence",
               _db.CreateListOfSqlParams(absence, new List<string>() { "AbsenceId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AbsenceViewModel absence)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAbsence",
               _db.CreateListOfSqlParams(absence, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
