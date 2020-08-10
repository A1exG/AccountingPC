using Accounting.DataManager.Library.DataAccess;
using Accounting.Model.EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "AccountingDataDb");

            return output;
        }
    }
}
