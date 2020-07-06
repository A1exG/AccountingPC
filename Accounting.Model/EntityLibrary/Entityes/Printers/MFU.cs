using Accounting.Model.EntityLibrary.Interfaces;
using System;

namespace Accounting.Model.EntityLibrary.Entityes.Printers
{
    public class MFU : IEntity, IPrinter
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }

        public DateTime DateBuy { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string ModelName { get; set; }
        public bool Color { get; set; }
        public PaperFormat PaperFormat { get; set; }
        public PrinterType PrinterType { get; set; } 
    }
}
