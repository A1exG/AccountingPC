using Accounting.Model.EntityLibrary.Interfaces;

namespace Accounting.Model.EntityLibrary.Entityes.Licenses
{
    public class OS : IEntity, ILicense
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string VendorName { get; set; }
        public string LicenseType { get; set; }
    }
}
