using Accounting.DataManager.Library.DataAccess;
using Accounting.Model.EntityLibrary;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace Accounting.DataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId).First();
        }
    }
}
