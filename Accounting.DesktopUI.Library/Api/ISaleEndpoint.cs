using Accounting.DesktopUI.Library.Models;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.Library.Api
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}