using Accounting.DesktopUI.Models;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserInfo(string token);
    }
}