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
    public class LectureService : ILectureService
    {
        private readonly IDatabaseContext _db;

        public LectureService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int lectureId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(lectureId), lectureId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteLecture", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetLectures");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int lectureId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(lectureId), lectureId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetLectureById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(LectureViewModel lecture)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveLecture",
               _db.CreateListOfSqlParams(lecture, new List<string>() { "LectureId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(LectureViewModel lecture)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateLecture",
                _db.CreateListOfSqlParams(lecture, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
