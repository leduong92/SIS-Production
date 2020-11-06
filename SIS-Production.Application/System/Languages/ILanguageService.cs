using SIS_Production.ViewModels.Common;
using SIS_Production.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIS_Production.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
