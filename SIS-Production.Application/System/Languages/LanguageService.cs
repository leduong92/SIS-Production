using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIS_Production.Data.EF;
using SIS_Production.ViewModels.Common;
using SIS_Production.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Production.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _configuration;
        public readonly SisSqlDbContext _context;

        public LanguageService(IConfiguration configuration, SisSqlDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name,
                IsDefault = x.IsDefault
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}
