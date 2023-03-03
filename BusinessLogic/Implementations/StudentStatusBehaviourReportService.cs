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
    public class StudentStatusBehaviourReportService : IStudentStatusBehaviourReportService
    {
        private readonly IDatabaseContext _db;

        public StudentStatusBehaviourReportService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int studentStatusBehaviourReportId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentStatusBehaviourReportId), studentStatusBehaviourReportId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteStudentStatusBehaviourReport", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetStudentStatusBehaviourReports");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int studentStatusBehaviourReportId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentStatusBehaviourReportId), studentStatusBehaviourReportId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetStudentStatusBehaviourReportById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(StudentStatusBehaviourReportViewModel studentStatusBehaviourReport)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveStudentStatusBehaviourReport",
               _db.CreateListOfSqlParams(studentStatusBehaviourReport, new List<string>() { "StudentStatusBehaviourReportId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(StudentStatusBehaviourReportViewModel studentStatusBehaviourReport)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateStudentStatusBehaviourReport",
               _db.CreateListOfSqlParams(studentStatusBehaviourReport, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByClassId(int classId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(classId), classId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByClassId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByEmpId(int empId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(empId), empId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByEmpId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByDepId(int depId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(depId), depId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByDepId", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
