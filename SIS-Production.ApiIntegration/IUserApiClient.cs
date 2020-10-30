using SIS_Production.ViewModels.Common;
using SIS_Production.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Production.ApiIntegration
{
    public interface IUserApiClient
    {
        Task<ApiResult<bool>> ResisterUser(RegisterRequest request);
        Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);
    }
}
