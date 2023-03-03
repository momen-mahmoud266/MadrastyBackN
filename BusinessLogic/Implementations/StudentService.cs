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
    public class StudentService : IStudentService
    {
        private readonly IDatabaseContext _db;

        public StudentService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int studentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentId), studentId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteStudent", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetStudents");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int studentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentId), studentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetStudentById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(StudentViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveStudent",
               _db.CreateListOfSqlParams(student, new List<string>() { "StudentId","Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(StudentViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateStudent",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByClassId(int studentId)
        {
            var pars = new Dictionary<string, string>();
        pars.Add(nameof(studentId), studentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByClassId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByGradeId(int studentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentId), studentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByGradeId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> UpdateStudentBranch(int studentId, int studentBranch)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(studentId), studentId.ToString());
            pars.Add(nameof(studentBranch), studentBranch.ToString());

            var dalResponse = await _db.ExecuteQuery("UpdateStudentBranch", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> UpdateStudentClass(int studentId, int studentClassId, string studentClassName)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentId), studentId.ToString());
            pars.Add(nameof(studentClassId), studentClassId.ToString());
            pars.Add(nameof(studentClassName), studentClassName.ToString());

            var dalResponse = await _db.ExecuteQuery("UpdateStudentClass", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetStartDateFromSchoolYearConfig()
        {
            var dalResponse = await _db.ExecuteQuery("GetStartDateFromSchoolYearConfig");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetBranchStatistics()
        {
            var dalResponse = await _db.ExecuteQuery("GetBranchStatistics");
            return new ServiceResponse(dalResponse);
        }
    }
}
