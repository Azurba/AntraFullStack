using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Model.Response;
using HRM.ApllicationCore.Repository;
using HRM.ApllicationCore.Service;
using HRM.Infrastructure.Repository;

namespace HRM.Infrastructure.Service
{
	public class UserServiceAsync: IUserServiceAsync
	{
        private readonly IUserRepositoryAsync userRepositoryAsync;

        public UserServiceAsync(IUserRepositoryAsync _userRepositoryAsync)
		{
            userRepositoryAsync = _userRepositoryAsync;
        }

        public Task<int> AddUserAsync(UserRequestModel model)
        {
            User user = new User()
            {
                UserName = model.Username,
                Email = model.EmailId,
                Password = model.Password
            };
            return userRepositoryAsync.InsertAsync(user);
        }

        public Task<int> DeleteUserAsync(int id)
        {
            return userRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserResponseModel>> GetAllUsersAsync()
        {
            var result = await userRepositoryAsync.GetAllAsync();
            if(result != null)
            {
                return result.ToList().Select(x => new UserResponseModel()
                { Id = x.Id, EmailId = x.Email, Password = x.Password, Username = x.UserName });
            }
            return null;
        }

        public async Task<UserResponseModel> GetUserByIdAsync(int id)
        {
            var result = await userRepositoryAsync.GetByIdAsync(id);
            if(result != null)
            {
                return new UserResponseModel()
                {
                    Id = result.Id,
                    EmailId = result.Email,
                    Password = result.Password,
                    Username = result.UserName
                };
            }
            return null;
        }

        public Task<int> UpdateUserAsync(UserRequestModel model)
        {
            User user = new User()
            {
                UserName = model.Username,
                Email = model.EmailId,
                Password = model.Password
            };
            return userRepositoryAsync.UpdateAsync(user);
        }
    }
}

