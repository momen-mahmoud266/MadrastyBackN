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
    public class AbsenceCaseDetailsService : IAbsenceCaseDetailsService
    {
        private readonly IDatabaseContext _db;

        public AbsenceCaseDetailsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int absenceCaseDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absenceCaseDetailsId), absenceCaseDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAbsenceCaseDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAbsenceCaseDetails");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int absenceCaseDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absenceCaseDetailsId), absenceCaseDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsenceCaseDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AbsenceCaseDetailsViewModel absenceCaseDetails)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.AbsenceCaseId), Value = absenceCaseDetails.AbsenceCaseId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.OtherSituations), Value = absenceCaseDetails.OtherSituations });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.Date), Value = absenceCaseDetails.Date });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.EffortResults), Value = absenceCaseDetails.EffortResults });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.EndYearState), Value = absenceCaseDetails.EndYearState });

            var result = await _db.ExecuteNonQuery("SaveAbsenceCaseDetails", param);
            return new ServiceResponse(result);
        }

        public async Task<ServiceResponse> Update(AbsenceCaseDetailsViewModel absenceCaseDetails)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.AbsenceCaseDetailsId), Value = absenceCaseDetails.AbsenceCaseDetailsId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.AbsenceCaseId), Value = absenceCaseDetails.AbsenceCaseId });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.OtherSituations), Value = absenceCaseDetails.OtherSituations });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.Date), Value = absenceCaseDetails.Date });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.EffortResults), Value = absenceCaseDetails.EffortResults });
            param.Add(new SqlParameter { ParameterName = nameof(absenceCaseDetails.EndYearState), Value = absenceCaseDetails.EndYearState });

            var result = await _db.ExecuteNonQuery("UpdateAbsenceCaseDetails", param);
            return new ServiceResponse(result);
        }
    }
}
