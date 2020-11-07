using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SIS_Production.Application.System.Languages;
using SIS_Production.Application.System.Users;
using SIS_Production.Data.Entities;

namespace SIS_Production.BackendApi.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //DI inject
            //khi khai bao 1 service nao do thi se phai inject vao day. Neu khong app se bi die
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ILanguageService, LanguageService>();

            return services;
        }
    }
}
