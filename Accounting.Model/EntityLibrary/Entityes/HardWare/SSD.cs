using Accounting.Model.EntityLibrary.Interfaces;
using System;

namespace Accounting.Model.EntityLibrary.Entityes.HardWare
{
    public class SSD : IEntity, IHardWare
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Vendor { get; set; }
        public DateTime DateBuy { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public int SSDCapacity { get; set; }
    }
}
