using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IInstructionsService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int instructionsId);
        Task<ServiceResponse> Delete(int instructionsId);
        Task<ServiceResponse> Save(InstructionsViewModel instructions);
        Task<ServiceResponse> Update(InstructionsViewModel instructions);
    }
}
