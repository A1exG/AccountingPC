using Accounting.Model.EntityLibrary.Entityes.Computers;
using Accounting.Model.EntityLibrary.Interfaces;
using System.Collections.Generic;

namespace Accounting.Model.EntityLibrary.Entityes.HardWare
{
    public class HardWare : IEntity
    {

        public int Id { get; set; }
        public string DisplayName { get; set; }

        public int ComputerId { get; set; }
        public virtual Computer Computer { get; set; }

        public int LaptopId { get; set; }
        public virtual Laptop Laptop { get; set; }


        public virtual IEnumerable<Processor> Processors { get; set; }
        public virtual IEnumerable<Motherboard> Motherboards { get; set; }
        public virtual IEnumerable<RAM> RAMs { get; set; }
        public virtual IEnumerable<StorageDevice> StorageDevices { get; set; }
        public virtual IEnumerable<PowerSupply> PowerSupples { get; set; }
        public virtual IEnumerable<GraphicsCard> GraphicsCards { get; set; }
    }
}
