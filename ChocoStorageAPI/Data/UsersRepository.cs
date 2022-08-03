using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Data
{
    public class UsersRepository : IUsersRepository
    {
        internal readonly Context _context;

        public UsersRepository (Context context)
        {
            this._context = context;
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }

        public bool SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
