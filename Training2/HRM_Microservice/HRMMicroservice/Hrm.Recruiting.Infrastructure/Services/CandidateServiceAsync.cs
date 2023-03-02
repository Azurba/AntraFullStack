using Hrm.Recruiting.ApplicationLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationLayer.Contract.Services;
using Hrm.Recruiting.ApplicationLayer.Entity;
using Hrm.Recruiting.ApplicationLayer.Model.Request;
using Hrm.Recruiting.ApplicationLayer.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.Infrastructure.Services
{
    public class CandidateServiceAsync : ICandidateServiceAsync
    {
        private readonly ICandidateRepositoryAsync candidateRepositoryAsync;

        public CandidateServiceAsync(ICandidateRepositoryAsync _candidateRepositoryAsync)
        {
            candidateRepositoryAsync = _candidateRepositoryAsync;
        }

        public Task<int> AddCandidateAsync(CandidateRequestModel model)
        {
            Candidate candidate = new Candidate()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.EmailId,
                Mobile = model.Mobile
            };
            return candidateRepositoryAsync.InsertAsync(candidate);
        }

        public Task<int> DeleteCandidateAsync(int id)
        {
            return candidateRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<CandidateResponseModel>> GetAllCandidateAsync()
        {
            var result = await candidateRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new CandidateResponseModel
                {
                    Id = x.CandidateId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    EmailId = x.Email,
                    Mobile = x.Mobile
                });
            }
            return null;
        }

        public async Task<CandidateResponseModel> GetCandidateByIdAsync(int id)
        {
            var result = await candidateRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new CandidateResponseModel
                {
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Id = result.CandidateId,
                    EmailId = result.Email,
                    Mobile = result.Mobile
                };
            }
            return null;
        }

        public Task<int> UpdateCandidateAsync(CandidateRequestModel model)
        {
            Candidate candidate = new Candidate()
            {
                CandidateId = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Mobile = model.Mobile,
                Email = model.EmailId
            };
            return candidateRepositoryAsync.UpdateAsync(candidate);
        }
    }
}
