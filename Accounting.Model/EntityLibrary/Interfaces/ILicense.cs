namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface ILicense
    {
        string VendorName { get; set; }
        string LicenseType { get; set; }
        string LicenseCode { get; set; }
    }
}
