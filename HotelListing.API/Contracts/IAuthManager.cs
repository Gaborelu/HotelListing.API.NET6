using HotelListing.API.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<AuthReponseDto> Login(LoginDto loginDto);
        Task<string> CreateRefreshToken();
        Task<AuthReponseDto> VerifyRefreshToken(AuthReponseDto request);
    }
}
