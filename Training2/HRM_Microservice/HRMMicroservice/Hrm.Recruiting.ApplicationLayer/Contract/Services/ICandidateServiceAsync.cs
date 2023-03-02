using Hrm.Recruiting.ApplicationLayer.Model.Request;
using Hrm.Recruiting.ApplicationLayer.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.ApplicationLayer.Contract.Services
{
    public interface ICandidateServiceAsync
    {
        Task<int> AddCandidateAsync(CandidateRequestModel model);
        Task<int> UpdateCandidateAsync(CandidateRequestModel model);
        Task<int> DeleteCandidateAsync(int id);
        Task<CandidateResponseModel> GetCandidateByIdAsync(int id);
        Task<IEnumerable<CandidateResponseModel>> GetAllCandidateAsync();

    }
}
