using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Model.Response;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Service
{
	public interface IJobCategoryServiceAsync
	{
        Task<int> AddJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> UpdateJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> DeleteJobCategoryAsync(int id);
        Task<JobCategoryResponseModel> GetJobCategoryByIdAsync(int id);
        Task<IEnumerable<JobCategoryResponseModel>> GetAllJobCategoriesAsync();

    }
}

