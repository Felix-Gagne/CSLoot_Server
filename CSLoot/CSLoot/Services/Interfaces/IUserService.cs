using CSLoot.Models;

namespace CSLoot.Services.Interfaces
{
    public interface IUserService
    {
        public User GetUserFromIdentityId(string userId);
    }
}
