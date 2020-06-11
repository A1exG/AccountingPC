using Accounting.Model.EntityLibrary.Interfaces;
using System;

namespace Accounting.Model.EntityLibrary.Entityes.Computers
{
    public class Laptop : IEntity, IComputer
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string DomenName { get; set; }
        public DateTime DateInstallOS { get; set; }
        public string HardWare { get; set; }
    }
}
