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
    public class AbsenceStatisticsService : IAbsenceStatisticsService
    {
        private readonly IDatabaseContext _db;

        public AbsenceStatisticsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAbsenceStatistics", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAbsenceStatistics");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsenceStatisticeById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AbsenceStatisticsViewModel absenceStatistics)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAbsenceStatistics",
               _db.CreateListOfSqlParams(absenceStatistics, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AbsenceStatisticsViewModel absenceStatistics)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAbsenceStatistics",
               _db.CreateListOfSqlParams(absenceStatistics, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
