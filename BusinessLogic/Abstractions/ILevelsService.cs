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
        Task<ServiceResponse> GetLevels();
        Task<ServiceResponse> GetLevelsById(int levelId);
        Task<ServiceResponse> DeleteLevels(int levelId);
        Task<ServiceResponse> SaveLevels(LevelsViewModel level);
        Task<ServiceResponse> UpdateLevels(LevelsViewModel level);
        Task<ServiceResponse> GetLevelsStat();
    }
}
