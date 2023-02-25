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
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.LevelId), Value = absenceCase.LevelId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.LevelName), Value = absenceCase.LevelName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.ClassId), Value = absenceCase.ClassId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.ClassName), Value = absenceCase.ClassName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.StudentId), Value = absenceCase.StudentId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.StudentName), Value = absenceCase.StudentName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.NationalityId), Value = absenceCase.NationalityId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.NationalityName), Value = absenceCase.NationalityName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.PhoneNo), Value = absenceCase.PhoneNo });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.BirthDate), Value = absenceCase.BirthDate });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.WorkStartDate), Value = absenceCase.WorkStartDate });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.BehavioralNotes), Value = absenceCase.BehavioralNotes });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.SelfReasons), Value = absenceCase.SelfReasons });


            var result = await _db.ExecuteNonQuery("SaveAbsenceCase", param);
            return new ServiceResponse(result);
        }

        public async Task<ServiceResponse> Update(AbsenceCaseViewModel absenceCase)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.AbsenceCasesId), Value = absenceCase.AbsenceCasesId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.LevelId), Value = absenceCase.LevelId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.LevelName), Value = absenceCase.LevelName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.ClassId), Value = absenceCase.ClassId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.ClassName), Value = absenceCase.ClassName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.StudentId), Value = absenceCase.StudentId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.StudentName), Value = absenceCase.StudentName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.NationalityId), Value = absenceCase.NationalityId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.NationalityName), Value = absenceCase.NationalityName });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.PhoneNo), Value = absenceCase.PhoneNo });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.BirthDate), Value = absenceCase.BirthDate });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.WorkStartDate), Value = absenceCase.WorkStartDate });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.BehavioralNotes), Value = absenceCase.BehavioralNotes });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCase.SelfReasons), Value = absenceCase.SelfReasons });

            var result = await _db.ExecuteNonQuery("UpdateAbsenceCase", param);
            return new ServiceResponse(result);
        }
    }
}
