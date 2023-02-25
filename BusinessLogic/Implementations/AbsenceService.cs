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
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceLevel), Value = absence.AbsenceLevel });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceClass), Value = absence.AbsenceClass });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceDate), Value = absence.AbsenceDate });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceStudentId), Value = absence.AbsenceStudentId });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceStudentName), Value = absence.AbsenceStudentName });
           
            var result = await _db.ExecuteNonQuery("SaveAbsence", param);
            return new ServiceResponse(result);
        }

        public async Task<ServiceResponse> Update(AbsenceViewModel absence)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceId), Value = absence.AbsenceId });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceLevel), Value = absence.AbsenceLevel });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceClass), Value = absence.AbsenceClass });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceDate), Value = absence.AbsenceDate });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceStudentId), Value = absence.AbsenceStudentId });
            param.Add(new SqlParameter { ParameterName = nameof(absence.AbsenceStudentName), Value = absence.AbsenceStudentName });

            var result = await _db.ExecuteNonQuery("UpdateAbsence", param);
            return new ServiceResponse(result);
        }
    }
}
