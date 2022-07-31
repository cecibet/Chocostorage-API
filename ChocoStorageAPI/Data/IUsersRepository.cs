using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;
using static ChocoStorageAPI.Controllers.AuthenticationController;

namespace ChocoStorageAPI.Data
{
    public interface IUsersRepository
    {
        public User? ValidateUser(AuthenticationRequestBody authRequestBody);
        public bool SaveChange();
    }
}
