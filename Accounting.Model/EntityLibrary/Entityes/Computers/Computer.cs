using Accounting.Model.EntityLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace Accounting.Model.EntityLibrary.Entityes.Computers
{
    /// <summary>
    /// Компьютер
    /// </summary>
    public class Computer : IEntity, IComputer
    {
        public Computer()
        {
            this.HardWares = new HashSet<HardWare.HardWare>();
            this.Licenses = new HashSet<Licenses.License>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string DomenName { get; set; }
        public DateTime DateInstallOS { get; set; }
        public ComputerType ComputerType { get; set; }


        public virtual IEnumerable<HardWare.HardWare> HardWares { get; set; }
        public virtual IEnumerable<Licenses.License> Licenses { get; set; }
        
    }
}
