using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ILibraryService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int libraryId);
        Task<ServiceResponse> Delete(int libraryId);
        Task<ServiceResponse> Save(LibraryViewModel library);
        Task<ServiceResponse> Update(LibraryViewModel library);
    }
}
