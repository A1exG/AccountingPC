using Accounting.Model.DataAccess;
using Accounting.Model.EntityLibrary;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Accounting.DataManager.Controllers
{
    [Authorize]
    public class SaleController : ApiController
    {
        public void Post(SaleModel sale)
        {
            if (sale != null)
            {
                SaleData data = new SaleData();
                string userId = RequestContext.Principal.Identity.GetUserId();

                data.SaveSale(sale, userId);
            }
        }

        [Route("GetSalesReport")]
        public List<SaleReportModel> GetSalesReport()
        {
            SaleData data = new SaleData();
            return data.GetSaleReport();
        }
    }
}
