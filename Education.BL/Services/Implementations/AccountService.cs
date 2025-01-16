using AutoMapper;
using Education.BL.DTOs.UserDtos;
using Education.BL.Services.Abstractions;
using Education.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;


        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<bool> LoginAsync(LoginDto loginDto)
        {
           AppUser? user = await _userManager.FindByEmailAsync(loginDto.EmailOrUserName);
            if (user is null)
            {
                user = await _userManager.FindByNameAsync(loginDto.EmailOrUserName);
                if(user is null)
                {
                    throw new Exception("Invalid login");
                }
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, loginDto.isPersistant, true);
            if (!result.Succeeded) { throw new Exception("Invalid login"); }

            return result.Succeeded;


        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegisterAsync(CreateDto createDto)
        {
            AppUser user = _mapper.Map<AppUser>(createDto);
            var result = await _userManager.CreateAsync(user, createDto.Password);

            if (!result.Succeeded) { throw new Exception("Invalid login"); }

            return result.Succeeded;
        }
    }
}
