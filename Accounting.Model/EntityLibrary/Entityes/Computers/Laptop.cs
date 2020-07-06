﻿using Accounting.Model.EntityLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace Accounting.Model.EntityLibrary.Entityes.Computers
{
    public class Laptop : IEntity, IComputer
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string DomenName { get; set; }
        public DateTime DateInstallOS { get; set; }

        public virtual IEnumerable<HardWare.HardWare> HardWares { get; set; }
        public virtual IEnumerable<Licenses.License> Licenses { get; set; }
    }
}
