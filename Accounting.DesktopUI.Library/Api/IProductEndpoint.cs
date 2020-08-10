using Accounting.DesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}