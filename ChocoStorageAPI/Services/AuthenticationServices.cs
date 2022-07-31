using ChocoStorageAPI.Data;
using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Services
{
    public class AutenticacionService : IAuthenticationServices
    {
        private readonly IUsersRepository _userRepository;

        public AutenticacionService(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? ValidateUser(AuthenticationRequestBody authenticationRequest)
        {
            if (string.IsNullOrEmpty(authenticationRequest.UserName) || string.IsNullOrEmpty(authenticationRequest.Password))
                return null;

            return _userRepository.ValidateUser(authenticationRequest);
        }
    }
}