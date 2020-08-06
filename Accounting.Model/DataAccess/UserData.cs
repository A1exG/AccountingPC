using Accounting.Model.EntityLibrary;
using System.Collections.Generic;

namespace Accounting.DataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "AccountingDataDb");

            return output;
        }
    }
}
