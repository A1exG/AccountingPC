using System;

namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface IPrinter
    {
        DateTime DateBuy { get; set; }
        Manufacturer Manufacturer { get; set; }
        string ModelName { get; set; }
        bool Color { get; set; }
        PaperFormat PaperFormat { get; set; }  
    }
    public enum PrinterType
    {
        printer,
        MFU
    }

    public enum Manufacturer
    {
        HP,
        Canon,
        Kyocera,
        Xerox
    }

    public enum PaperFormat
    {
        A4,
        A3
    }
}
