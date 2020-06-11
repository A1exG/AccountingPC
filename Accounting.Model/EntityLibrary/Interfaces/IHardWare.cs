using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface IHardWare
    {
        string Vendor { get; set; }
        DateTime DateBuy { get; set; }
        string Manufacturer { get; set; }
        string Name { get; set; }
    }
}
