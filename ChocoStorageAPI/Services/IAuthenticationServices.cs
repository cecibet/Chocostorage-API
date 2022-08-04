using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;
using static ChocoStorageAPI.Controllers.AuthenticationController;

namespace ChocoStorageAPI.Services
{
    public interface IAuthenticationServices
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
    }
}