using Accounting.Model.DataAccess;
using Accounting.Model.EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Accounting.DataManager.Controllers
{
    public class ProductController : ApiController
    {
        [Authorize]
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
