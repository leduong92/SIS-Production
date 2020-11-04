using SIS_Production.ViewModels.Common;
using SIS_Production.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Production.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);
        Task<ApiResult<bool>> Update(string id, UserUpdateRequest request);
        Task<ApiResult<UserVm>> GetById(string id);
    }
}
