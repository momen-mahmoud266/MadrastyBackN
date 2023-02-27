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
    public class ExcellentStudentService : IExcellentStudentService
    {
        private readonly IDatabaseContext _db;

        public ExcellentStudentService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteExcellentStudent", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetExcellentStudents");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetExcellentStudentById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(ExcellentStudentViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveExcellentStudent",
               _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ExcellentStudentViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateExcellentStudent",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
