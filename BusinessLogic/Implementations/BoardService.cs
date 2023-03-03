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
    public class BoardService : IBoardService
    {
        private readonly IDatabaseContext _db;

        public BoardService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int BoardId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(BoardId), BoardId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBoard", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBoards");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int BoardId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(BoardId), BoardId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBoardById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BoardViewModel Board)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBoard",
               _db.CreateListOfSqlParams(Board, new List<string>() { "BoardId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BoardViewModel Board)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBoard",
               _db.CreateListOfSqlParams(Board, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
