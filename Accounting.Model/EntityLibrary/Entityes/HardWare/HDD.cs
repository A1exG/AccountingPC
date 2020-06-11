using Accounting.Model.EntityLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model.EntityLibrary.Entityes.HardWare
{
    public class HDD : IEntity, IHardWare
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Vendor { get; set; }
        public DateTime DateBuy { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public int HDDCapacity { get; set; }
    }
}
