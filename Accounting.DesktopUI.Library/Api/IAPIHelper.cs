using Accounting.DesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        void LogOffUser();
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserInfo(string token);
    }
}