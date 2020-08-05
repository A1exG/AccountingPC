using Accounting.Model.EntityLibrary.Entityes.Users;
using System.Collections.Generic;

namespace Accounting.Model.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "AccountingDataDb");

            return output;
        }
    }
}
