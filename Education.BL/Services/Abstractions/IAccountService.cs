using Education.BL.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services.Abstractions
{
    public interface IAccountService
    {
        Task<bool> RegisterAsync(CreateDto createDto);
        Task<bool> LoginAsync(LoginDto loginDto);
        Task LogoutAsync();
        
    }
}
