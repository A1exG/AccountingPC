using Accounting.DesktopUI.Models;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}