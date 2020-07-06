using Accounting.Model.EntityLibrary.Interfaces;
using System;

namespace Accounting.Model.EntityLibrary.Entityes.HardWare
{
    public class Processor : IEntity, IHardWare
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime DateBuy { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public string MBSocket { get; set; }

        public int HardWareId { get; set; }
        public virtual HardWare HardWare { get; set; }

        public int Count { get; set; }
    }
}
