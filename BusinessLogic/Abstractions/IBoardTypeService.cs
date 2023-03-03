using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IBoardTypeService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int boardTypeId);
        Task<ServiceResponse> Delete(int boardTypeId);
        Task<ServiceResponse> Save(BoardTypeViewModel boardType);
        Task<ServiceResponse> Update(BoardTypeViewModel boardType);
    }
}
