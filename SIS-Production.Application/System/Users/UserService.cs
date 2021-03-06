﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SIS_Production.Data.EF;
using SIS_Production.Data.Entities;
using SIS_Production.Utilities.Constants;
using SIS_Production.ViewModels.Common;
using SIS_Production.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Production.Application.System.Users
{
    
    public class UserService : IUserService
    {
        private readonly SisSqlDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;
        public UserService(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration configuration,
            SisSqlDbContext context
            )
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _userManager = userManager;
            _context = context;
        }
        public async Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserVm()
                {
                    UserName = x.UserName,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Location = x.Location,
                    Id = x.Id,
                    Division = x.Division,
                    Department = x.Department,
                    Section = x.Section,
                    CreatedDate = x.CreatedDate,
                    Email = x.Email
                    
                }).ToListAsync();

            var pagedResult = new PagedResult<UserVm>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new ApiSuccessResult<PagedResult<UserVm>>(pagedResult);
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
                return new ApiErrorResult<string>("Tài khoản không tồn tại.");

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Đăng nhập không đúng");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.GivenName,  user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, request.UserName) //nhung thong tin gi muon hien ra Website thi se duoc gan vao day
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return new ApiErrorResult<bool>("Tài khoản đã tồn tại.");
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return new ApiErrorResult<bool>("Email đã tồn tại.");
            }
            var hasher = new PasswordHasher<AppUser>();
            user = new AppUser()
            {
                Id = request.UserName,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Location = request.Location,
                Division = request.Division,
                Department = request.Department,
                Section = request.Section,
                CreatedDate = request.CreatedDate,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                PasswordHash = request.Password == null ? hasher.HashPassword(null, SystemConstants.AppSettings.DefaultPassword) :  hasher.HashPassword(null, request.Password),
            };
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Đăng ký tài khoản thất bại.");
        }

        public async Task<ApiResult<bool>> Update(string id, UserUpdateRequest request)
        {
            if (await _userManager.Users.AnyAsync(x=>x.UserName == request.UserName && x.Id != id))
            {
                return new ApiErrorResult<bool>("Tài khoản đã tồn tại.");
            }
            var user = await _userManager.FindByIdAsync(id);
            user.UserName = request.UserName;
            user.Email = request.Email;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            user.SecurityStamp = Guid.NewGuid().ToString();

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Cập nhật không thành công");
        }

        public async Task<ApiResult<UserVm>> GetById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return new ApiErrorResult<UserVm>("User không tồn tại");
            }
            var userVm = new UserVm()
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                CreatedDate = user.CreatedDate,
                Id = user.Id,
                Email = user.Email
            };
            return new ApiSuccessResult<UserVm>(userVm);
        }
    }
}
