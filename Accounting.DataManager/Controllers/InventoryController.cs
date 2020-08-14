﻿using Accounting.Model.DataAccess;
using Accounting.Model.EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Accounting.DataManager.Controllers
{
    [Authorize]
    public class InventoryController : ApiController
    {
        public List<InventoryModel> Get()
        {
            InventoryData data = new InventoryData();
            return data.GetInventory();
        }

        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData();
            data.SaveInventoryRecord(item);
        }
    }
}
