using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IBoardService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int boardId);
        Task<ServiceResponse> Delete(int boardId);
        Task<ServiceResponse> Save(BoardViewModel Board);
        Task<ServiceResponse> Update(BoardViewModel Board);
    }
}
