using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ILectureService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int lectureId);
        Task<ServiceResponse> Delete(int lectureId);
        Task<ServiceResponse> Save(LectureViewModel lecture);
        Task<ServiceResponse> Update(LectureViewModel lecture);
    }
}
