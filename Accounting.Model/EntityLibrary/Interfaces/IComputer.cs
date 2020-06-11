using System;

namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface IComputer
    {
        string DomenName { get; set; }
        DateTime DateInstallOS { get; set; }
    }
}
