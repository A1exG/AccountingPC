using System;

namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface IComputer
    {
        string DomenName { get; set; }
        DateTime DateInstallOS { get; set; }
        ComputerType ComputerType { get; set; }
    }
    public enum ComputerType
    {
        Computer,
        Laptop,
        Monoblock
    }
}
