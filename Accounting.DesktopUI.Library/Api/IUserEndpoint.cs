using Accounting.DesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.Library.Api
{
    public interface IUserEndpoint
    {
        Task AddUserToRole(string userId, string roleName);
        Task<List<UserModel>> GettAll();
        Task<Dictionary<string, string>> GettAllRoles();
        Task RemoveUserFromRole(string userId, string roleName);
    }
}