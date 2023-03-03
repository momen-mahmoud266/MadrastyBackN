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
    public class LevelsService : ILevelsService
    {

        private readonly IDatabaseContext _db;

        public LevelsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int levelsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(levelsId), levelsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteLevels", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetLevels");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int levelsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(levelsId), levelsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetLevelsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(LevelsViewModel levels)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveLevels",
               _db.CreateListOfSqlParams(levels, new List<string>() { "LevelId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(LevelsViewModel levels)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateLevels",
               _db.CreateListOfSqlParams(levels, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetLevelsStat()
        {
            var dalResponse = await _db.ExecuteQuery("GetLevelsStat");
            return new ServiceResponse(dalResponse);
        }

    }
}
