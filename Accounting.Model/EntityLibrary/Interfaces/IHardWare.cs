using System;

namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface IHardWare
    {
        DateTime DateBuy { get; set; }
        string Manufacturer { get; set; }
        string Name { get; set; }
        int Count { get; set; }
    }
}
