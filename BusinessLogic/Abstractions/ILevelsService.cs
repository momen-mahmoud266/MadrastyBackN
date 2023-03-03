using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ILevelsService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int levelId);
        Task<ServiceResponse> Delete(int levelId);
        Task<ServiceResponse> Save(LevelsViewModel level);
        Task<ServiceResponse> Update(LevelsViewModel level);
        Task<ServiceResponse> GetLevelsStat();
    }
}
