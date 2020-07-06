using Accounting.Model.EntityLibrary.Entityes.Computers;
using Accounting.Model.EntityLibrary.Interfaces;
using System.Collections.Generic;

namespace Accounting.Model.EntityLibrary.Entityes.Licenses
{
    public class License : IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }

        public int ComputerId { get; set; }
        public virtual Computer Computer { get; set; }

        public int LaptopId { get; set; }
        public virtual Laptop Laptop { get; set; }

        public virtual IEnumerable<OS> OSs { get; set; }
        public virtual IEnumerable<Soft> Softs { get; set; }
    }
}
