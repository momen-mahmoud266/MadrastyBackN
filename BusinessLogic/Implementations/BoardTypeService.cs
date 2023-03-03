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
    public class BoardTypeService : IBoardTypeService
    {
        private readonly IDatabaseContext _db;

        public BoardTypeService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int BoardTypeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(BoardTypeId), BoardTypeId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBoardType", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBoardTypes");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int BoardTypeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(BoardTypeId), BoardTypeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBoardTypeById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BoardTypeViewModel BoardType)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBoardType",
               _db.CreateListOfSqlParams(BoardType, new List<string>() { "BoardTypeId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BoardTypeViewModel BoardType)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBoardType",
               _db.CreateListOfSqlParams(BoardType, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
